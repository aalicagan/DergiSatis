using DergiSatisTakip.Generic;

namespace DergiSatisTakip.AboneUI
{
    partial class AboneHesapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdAboneHesap = new System.Windows.Forms.DataGridView();
            this.aboneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridIslemTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneHesapViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numAboneId = new DergiSatisTakip.NumericTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.aboneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAmount = new DergiSatisTakip.NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtIslemDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbIslemType = new System.Windows.Forms.ComboBox();
            this.btnAboneSec = new System.Windows.Forms.Button();
            this.numId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tool = new DergiSatisTakip.Generic.MasterTool();
            this.ıslemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPdf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAboneHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneHesapViewModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 475);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdAboneHesap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abone Hesap Listesi";
            // 
            // grdAboneHesap
            // 
            this.grdAboneHesap.AutoGenerateColumns = false;
            this.grdAboneHesap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAboneHesap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aboneIdDataGridViewTextBoxColumn,
            this.aboneNameDataGridViewTextBoxColumn,
            this.aboneSurnameDataGridViewTextBoxColumn,
            this.GridIslemTipi,
            this.ıslemDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.grdAboneHesap.DataSource = this.aboneHesapViewModelBindingSource;
            this.grdAboneHesap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAboneHesap.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grdAboneHesap.Location = new System.Drawing.Point(3, 18);
            this.grdAboneHesap.Name = "grdAboneHesap";
            this.grdAboneHesap.RowTemplate.Height = 24;
            this.grdAboneHesap.Size = new System.Drawing.Size(927, 226);
            this.grdAboneHesap.TabIndex = 0;
            this.grdAboneHesap.Click += new System.EventHandler(this.grdAboneHesap_Click);
            // 
            // aboneIdDataGridViewTextBoxColumn
            // 
            this.aboneIdDataGridViewTextBoxColumn.DataPropertyName = "AboneId";
            this.aboneIdDataGridViewTextBoxColumn.HeaderText = "AboneId";
            this.aboneIdDataGridViewTextBoxColumn.Name = "aboneIdDataGridViewTextBoxColumn";
            this.aboneIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // aboneNameDataGridViewTextBoxColumn
            // 
            this.aboneNameDataGridViewTextBoxColumn.DataPropertyName = "AboneName";
            this.aboneNameDataGridViewTextBoxColumn.HeaderText = "Abone Adı";
            this.aboneNameDataGridViewTextBoxColumn.Name = "aboneNameDataGridViewTextBoxColumn";
            // 
            // aboneSurnameDataGridViewTextBoxColumn
            // 
            this.aboneSurnameDataGridViewTextBoxColumn.DataPropertyName = "AboneSurname";
            this.aboneSurnameDataGridViewTextBoxColumn.HeaderText = "Abone Soyadı";
            this.aboneSurnameDataGridViewTextBoxColumn.Name = "aboneSurnameDataGridViewTextBoxColumn";
            this.aboneSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // GridIslemTipi
            // 
            this.GridIslemTipi.DataPropertyName = "IslemType";
            this.GridIslemTipi.HeaderText = "İşlem Tipi";
            this.GridIslemTipi.Name = "GridIslemTipi";
            this.GridIslemTipi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ıslemDateDataGridViewTextBoxColumn
            // 
            this.ıslemDateDataGridViewTextBoxColumn.DataPropertyName = "IslemDate";
            this.ıslemDateDataGridViewTextBoxColumn.HeaderText = "İşlem Tarihi";
            this.ıslemDateDataGridViewTextBoxColumn.Name = "ıslemDateDataGridViewTextBoxColumn";
            this.ıslemDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // aboneHesapViewModelBindingSource
            // 
            this.aboneHesapViewModelBindingSource.DataSource = typeof(Dergi.Business.ViewModel.AboneHesapViewModel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnPdf);
            this.groupBox1.Controls.Add(this.numAboneId);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtIslemDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbIslemType);
            this.groupBox1.Controls.Add(this.btnAboneSec);
            this.groupBox1.Controls.Add(this.numId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Hesap";
            // 
            // numAboneId
            // 
            this.numAboneId.AccessibleName = "AboneId";
            this.numAboneId.AllowSpace = false;
            this.numAboneId.Location = new System.Drawing.Point(888, 21);
            this.numAboneId.Name = "numAboneId";
            this.numAboneId.Size = new System.Drawing.Size(16, 22);
            this.numAboneId.TabIndex = 37;
            this.numAboneId.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(595, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 123);
            this.panel2.TabIndex = 36;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBalance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBalance.Location = new System.Drawing.Point(39, 51);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 20);
            this.lblBalance.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam Borç:";
            // 
            // txtSurname
            // 
            this.txtSurname.AccessibleName = "AboneSurname";
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboneBindingSource, "Name", true));
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(166, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // aboneBindingSource
            // 
            this.aboneBindingSource.DataSource = typeof(Dergi.Model.Abone);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Abone Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Açıklama";
            // 
            // txtDescription
            // 
            this.txtDescription.AccessibleName = "Description";
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboneBindingSource, "Name", true));
            this.txtDescription.Location = new System.Drawing.Point(166, 183);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 22);
            this.txtDescription.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tutar";
            // 
            // numAmount
            // 
            this.numAmount.AccessibleName = "Amount";
            this.numAmount.AllowSpace = false;
            this.numAmount.Location = new System.Drawing.Point(166, 155);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(191, 22);
            this.numAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "İşlem Tarihi";
            // 
            // dtIslemDate
            // 
            this.dtIslemDate.AccessibleName = "IslemDate";
            this.dtIslemDate.Location = new System.Drawing.Point(166, 127);
            this.dtIslemDate.Name = "dtIslemDate";
            this.dtIslemDate.Size = new System.Drawing.Size(191, 22);
            this.dtIslemDate.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "İşlem Tipi";
            // 
            // cmbIslemType
            // 
            this.cmbIslemType.AccessibleName = "IslemType";
            this.cmbIslemType.FormattingEnabled = true;
            this.cmbIslemType.Location = new System.Drawing.Point(166, 97);
            this.cmbIslemType.Name = "cmbIslemType";
            this.cmbIslemType.Size = new System.Drawing.Size(141, 24);
            this.cmbIslemType.TabIndex = 3;
            // 
            // btnAboneSec
            // 
            this.btnAboneSec.Location = new System.Drawing.Point(363, 37);
            this.btnAboneSec.Name = "btnAboneSec";
            this.btnAboneSec.Size = new System.Drawing.Size(55, 50);
            this.btnAboneSec.TabIndex = 21;
            this.btnAboneSec.Text = "Getir";
            this.btnAboneSec.UseVisualStyleBackColor = true;
            this.btnAboneSec.Click += new System.EventHandler(this.btnAboneSec_Click);
            // 
            // numId
            // 
            this.numId.AccessibleName = "Id";
            this.numId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboneBindingSource, "Name", true));
            this.numId.Location = new System.Drawing.Point(879, 49);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(0, 22);
            this.numId.TabIndex = 20;
            this.numId.Text = "0";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "AboneName";
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboneBindingSource, "Name", true));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(166, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone Adı";
            // 
            // tool
            // 
            this.tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(933, 32);
            this.tool.TabIndex = 1;
            this.tool.SwGetButtonClicked += new System.EventHandler(this.tool_SwGetButtonClicked);
            this.tool.SwUpdateButtonClicked += new System.EventHandler(this.tool_SwUpdateButtonClicked);
            this.tool.SwDeleteButtonClicked += new System.EventHandler(this.tool_SwDeleteButtonClicked);
            this.tool.SwSaveButtonClicked += new System.EventHandler(this.tool_SwSaveButtonClicked);
            this.tool.SwClearButtonClicked += new System.EventHandler(this.tool_SwClearButtonClicked);
            // 
            // ıslemTypeBindingSource
            // 
            this.ıslemTypeBindingSource.DataSource = typeof(Dergi.Model.Util.IslemType);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(828, 178);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(93, 44);
            this.btnPdf.TabIndex = 38;
            this.btnPdf.Text = "Pdf\'e Çıkar";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 43);
            this.button2.TabIndex = 39;
            this.button2.Text = "Excel\'e Çıkar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AboneHesapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool);
            this.Name = "AboneHesapForm";
            this.Text = "Abone Hesap";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAboneHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneHesapViewModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MasterTool tool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdAboneHesap;
        private System.Windows.Forms.BindingSource aboneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDergiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDergiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox numId;
        private System.Windows.Forms.BindingSource ıslemTypeBindingSource;
        private System.Windows.Forms.Button btnAboneSec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbIslemType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtIslemDate;
        private System.Windows.Forms.Label label2;
        private NumericTextBox numAmount;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label6;
        private NumericTextBox numAboneId;
        private System.Windows.Forms.BindingSource aboneHesapViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridIslemTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPdf;
    }
}