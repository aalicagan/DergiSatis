using System;
using System.Linq;
using System.Windows.Forms;
using Dergi.Business.Uow;
using Dergi.Model;
using DergiSatisTakip.Generic;
using Util = Dergi.Business.Util;

namespace DergiSatisTakip.Parametre
{
    public partial class BirimForm : MainForm
    {
        public BirimForm()
        {
            InitializeComponent();
            SetEnumValues(cmbStatus,typeof(Dergi.Model.Util.StatusType));
            cmbBirimTur.DataSource = UnitOfWork.Instance.GetRepository<BirimTur>().SelectAll().ToList();
            cmbBolge.DataSource = UnitOfWork.Instance.GetRepository<Bolge>().SelectAll().ToList();
            GridBirimTurCombo.DataSource = UnitOfWork.Instance.GetRepository<BirimTur>().SelectAll().ToList();
            GridBolgeCombo.DataSource = UnitOfWork.Instance.GetRepository<Bolge>().SelectAll().ToList();
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<Birim>().Delete(Util.ConvertInt32(numId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Birim Silindi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            //Filtre yaz.
            grdBirim.DataSource = UnitOfWork.Instance.GetRepository<Birim>().SelectAll().ToList();
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            var birim = new Birim();
            SetFromScreen(birim, groupBox1);
            UnitOfWork.Instance.GetRepository<Birim>().Create(birim);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Birim Eklendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            var birim = new Birim();
            SetFromScreen(birim, groupBox1);
            UnitOfWork.Instance.GetRepository<Birim>().Update(birim);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Birim Guncellendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void grdBirim_Click(object sender, EventArgs e)
        {
            if (grdBirim.CurrentRow == null) return;
            var obj = (Birim)grdBirim.CurrentRow.DataBoundItem;
            FillScreen(obj, groupBox1);
        }
    }
}
