using System;
using System.Linq;
using System.Windows.Forms;
using Dergi.Business.Uow;
using Dergi.Model;
using DergiSatisTakip.Generic;
using Util = Dergi.Business.Util;

namespace DergiSatisTakip.Parametre
{
    public partial class BolgeForm : MainForm
    {
        public BolgeForm()
        {
            InitializeComponent();
            SetEnumValues(cmbStatus,typeof(Dergi.Model.Util.StatusType));
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<Bolge>().Delete(Util.ConvertInt32(numId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Bölge Silindi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            //Filtre yaz.
            grdBolge.DataSource = UnitOfWork.Instance.GetRepository<Bolge>().SelectAll().ToList();
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            var bolge = new Bolge();
            SetFromScreen(bolge, groupBox1);
            UnitOfWork.Instance.GetRepository<Bolge>().Create(bolge);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Bölge Eklendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            var bolge = new Bolge();
            SetFromScreen(bolge, groupBox1);
            UnitOfWork.Instance.GetRepository<Bolge>().Update(bolge);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Bölge Guncellendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void grdBolge_Click(object sender, EventArgs e)
        {
            if (grdBolge.CurrentRow == null) return;
            var obj = (Bolge)grdBolge.CurrentRow.DataBoundItem;
            FillScreen(obj, groupBox1);
        }
    }
}
