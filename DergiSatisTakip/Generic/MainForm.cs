using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Dergi.Business;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DergiSatisTakip.Generic
{
    public class MainForm : Form
    {
        private ErrorProvider _errorProvider;
        private IContainer components;

        public MainForm()
        {
            _errorProvider = new ErrorProvider();
        }

        public void FillScreen(object obj, Control container)
        {
            if (obj == null)
                return;
            foreach (var property in obj.GetType().GetProperties())
            {
                Control ctr = container.Controls.Cast<Control>().FirstOrDefault(x => x.AccessibleName == property.Name);
                dynamic value;
                if (property.PropertyType.BaseType == typeof(Enum))
                    value = (Int32)property.GetValue(obj, null);
                else
                    value = property.GetValue(obj, null);
                if (value == null) continue;
                if (ctr == null) continue;
                if (ctr is TextBox || ctr is RichTextBox)
                    ctr.Text = value.ToString();
                else if (ctr is DateTimePicker)
                    ((DateTimePicker)ctr).Value = value;
                else if (ctr is ComboBox)
                    ((ComboBox)ctr).SelectedValue = value;
                else if (ctr is NumericUpDown)
                    ((NumericUpDown)ctr).Value = value;
                else if (ctr is CheckBox)
                    ((CheckBox)ctr).Checked = value;
            }
        }

        public void SetFromScreen(object obj, Control container)
        {
            if (obj == null)
                return;
            foreach (var property in obj.GetType().GetProperties())
            {
                Control ctr = container.Controls.Cast<Control>().FirstOrDefault(x => x.AccessibleName == property.Name);
                dynamic value = null;
                if (ctr == null) continue;
                if (ctr is TextBox || ctr is RichTextBox)
                    value = ctr.Text;
                else if (ctr is DateTimePicker)
                    value = ((DateTimePicker)ctr).Value;
                else if (ctr is ComboBox)
                    value = ((ComboBox)ctr).SelectedValue;
                else if (ctr is NumericUpDown)
                    value = ((NumericUpDown)ctr).Value;
                else if (ctr is CheckBox)
                    value = ((CheckBox)ctr).Checked;

                if (property.PropertyType == typeof(Int32))
                    value = Util.ConvertInt32(value);
                else if (property.PropertyType == typeof(Decimal))
                    value = Util.ConvertDecimal(value);
                property.SetValue(obj,
                    value);
            }
        }

        public void Clear(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox || control is RichTextBox)
                    control.Text = String.Empty;
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = 0;
                else if (control is NumericUpDown)
                    ((NumericUpDown)control).Value = 0;
                else if (control is DateTimePicker)
                    ((DateTimePicker)control).Value = DateTime.Now;
                else if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
            }
        }

        public static void SetEnumValues(ComboBox cxbx, Type typ)
        {
            if (!typ.IsEnum)
            {
                throw new ArgumentException("Only Enum types can be set");
            }

            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();

            foreach (int i in Enum.GetValues(typ))
            {
                string name = Enum.GetName(typ, i);
                string desc = name;
                FieldInfo fi = typ.GetField(name);

                // Get description for enum element
                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0)
                {
                    string s = attributes[0].Description;
                    if (!string.IsNullOrEmpty(s))
                    {
                        desc = s;
                    }
                }

                list.Add(new KeyValuePair<string, int>(desc, i));
            }
            cxbx.DisplayMember = "Key";
            cxbx.ValueMember = "Value";
            cxbx.DataSource = list;
        }

        public bool CheckRequiredValues(Control container)
        {
            _errorProvider.Clear();
            var check = true;
            foreach (
                Control control in
                    container.Controls.Cast<Control>().Where(control => ReferenceEquals(control.Tag, "Required")))
            {
                _errorProvider.SetError(control, "");
                if ((control is TextBox || control is RichTextBox) && control.Text == "")
                {
                    _errorProvider.SetError(control, "Zorunlu Alan");
                    check = false;
                }
                else if (control is ComboBox && ((ComboBox)control).SelectedIndex == 0)
                {
                    _errorProvider.SetError(control, "Zorunlu Alan");
                    check = false;
                }
                else if (control is NumericUpDown && ((NumericUpDown)control).Value == 0)
                {
                    _errorProvider.SetError(control, "Zorunlu Alan");
                    check = false;
                }
            }
            return check;
        }

        public void CreatePdf(DataGridView gridView, string fileName)
        {
            var stfHelveticaTurkish = BaseFont.CreateFont("Helvetica", "CP1254", BaseFont.NOT_EMBEDDED);
            var fontNormal = new Font(stfHelveticaTurkish, 12, iTextSharp.text.Font.NORMAL);
            var pdfTable = new PdfPTable(gridView.Columns.Cast<DataGridViewColumn>().Count(column => column.Visible));
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (var cell in from DataGridViewColumn column in gridView.Columns
                                 where column.Visible
                                 select new PdfPCell(new Phrase(column.HeaderText, fontNormal))
                                 {
                                     BackgroundColor = new BaseColor(240, 240, 240),
                                 })
            {
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (
                var cell in
                    gridView.Rows.Cast<DataGridViewRow>()
                        .SelectMany(row => row.Cells.Cast<DataGridViewCell>().Where(cell => cell.Visible)))
            {
                pdfTable.AddCell(new Phrase(cell.Value.ToString(), fontNormal));
            }

            //Exporting to PDF
            const string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (var stream = new FileStream(folderPath + fileName + ".pdf", FileMode.Create))
            {
                var pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
        private void InitializeComponent()
        {
            this.components = new Container();
            this._errorProvider = new ErrorProvider(this.components);
            ((ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this._errorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            this._errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "MainForm";
            ((ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
