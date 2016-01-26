using System;
using System.Linq;
using System.Windows.Forms;
using Dergi.Business.Uow;
using Dergi.Model;
using DergiSatisTakip.Generic;
using Util = Dergi.Business.Util;

namespace DergiSatisTakip.Parametre
{
    public partial class AboneTypeForm : MainForm
    {
        public AboneTypeForm()
        {
            InitializeComponent();
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<AboneType>().Delete(Util.ConvertInt32(numId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Tipi Silindi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            //Filtre yaz.
            grdAboneTipi.DataSource = UnitOfWork.Instance.GetRepository<AboneType>().SelectAll().ToList();
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            var aboneType = new AboneType();
            SetFromScreen(aboneType, groupBox1);
            UnitOfWork.Instance.GetRepository<AboneType>().Create(aboneType);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Tipi Eklendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            var aboneType =  new AboneType();
            SetFromScreen(aboneType, groupBox1);
            UnitOfWork.Instance.GetRepository<AboneType>().Update(aboneType);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Tipi Guncellendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void grdAboneType_Click(object sender, EventArgs e)
        {
            if (grdAboneTipi.CurrentRow == null) return;
            var obj = (AboneType)grdAboneTipi.CurrentRow.DataBoundItem;
            FillScreen(obj, groupBox1);
        }
    }
}
