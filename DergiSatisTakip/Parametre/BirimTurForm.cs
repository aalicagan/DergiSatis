using System;
using System.Linq;
using System.Windows.Forms;
using Dergi.Business.Uow;
using Dergi.Model;
using DergiSatisTakip.Generic;
using Util = Dergi.Business.Util;

namespace DergiSatisTakip.Parametre
{
    public partial class BirimTurForm : MainForm
    {
        public BirimTurForm()
        {
            InitializeComponent();
            SetEnumValues(cmbStatus, typeof (Dergi.Model.Util.StatusType));
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<BirimTur>().Delete(Util.ConvertInt32(numId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Birim Tür Silindi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            //Filtre yaz.
            grdBirimTur.DataSource = UnitOfWork.Instance.GetRepository<BirimTur>().SelectAll().ToList();
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            var birimTur = new BirimTur();
            SetFromScreen(birimTur, groupBox1);
            UnitOfWork.Instance.GetRepository<BirimTur>().Create(birimTur);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Birim Tür Eklendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            var birimTur = new BirimTur();
            SetFromScreen(birimTur, groupBox1);
            UnitOfWork.Instance.GetRepository<BirimTur>().Update(birimTur);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Birim Tür Guncellendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void grdBirimTur_Click(object sender, EventArgs e)
        {
            if (grdBirimTur.CurrentRow == null) return;
            var obj = (BirimTur)grdBirimTur.CurrentRow.DataBoundItem;
            FillScreen(obj, groupBox1);
        }
    }
}
