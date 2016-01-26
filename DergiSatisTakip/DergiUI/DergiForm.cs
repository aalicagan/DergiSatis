using System;
using System.Linq;
using System.Windows.Forms;
using Dergi.Business;
using Dergi.Business.Uow;
using DergiSatisTakip.Generic;

namespace DergiSatisTakip.DergiUI
{
    public partial class DergiForm : MainForm
    {
        public DergiForm()
        {
            InitializeComponent();
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<Dergi.Model.Dergi>().Delete(Util.ConvertInt32(numId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Dergi Silindi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            //Filtre yaz.
            grdDergi.DataSource = UnitOfWork.Instance.GetRepository<Dergi.Model.Dergi>().SelectAll().ToList();
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            if(!CheckRequiredValues(groupBox1))return; 
            var dergi = new Dergi.Model.Dergi();
            SetFromScreen(dergi, groupBox1);
            UnitOfWork.Instance.GetRepository<Dergi.Model.Dergi>().Create(dergi);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Dergi Eklendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            if (!CheckRequiredValues(groupBox1)) return; 
            var dergi = new Dergi.Model.Dergi();
            SetFromScreen(dergi, groupBox1);
            UnitOfWork.Instance.GetRepository<Dergi.Model.Dergi>().Update(dergi);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Dergi Guncellendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void grdDergi_Click(object sender, EventArgs e)
        {
            if (grdDergi.CurrentRow == null) return;
            var obj = (Dergi.Model.Dergi)grdDergi.CurrentRow.DataBoundItem;
            FillScreen(obj, groupBox1);
        }
    }
}
