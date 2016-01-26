using System;
using System.Linq;
using System.Windows.Forms;
using Dergi.Business;
using Dergi.Business.Uow;
using Dergi.Business.ViewModel;
using Dergi.Model;
using DergiSatisTakip.Generic;

namespace DergiSatisTakip.AboneUI
{
    public partial class AboneDergiForm : MainForm
    {
        public AboneDergiForm()
        {
            InitializeComponent();
            cmbDergi.DataSource = DergiService.Instance.GetAllList();
            txtId.Text = "0";
        }

        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            var model = AboneService.Instance.GetAboneDergiList(Dergi.Business.Util.ConvertInt32(numAboneId.Text));
            grdAboneDergi.DataSource = model;
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            var aboneDergi = new AboneDergi();
            SetFromScreen(aboneDergi, groupBox1);
            UnitOfWork.Instance.GetRepository<AboneDergi>().Create(aboneDergi);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Dergi Eklendi");
            tool_SwGetButtonClicked(sender, e);
        }

        private void grdAboneDergi_Click(object sender, EventArgs e)
        {
            if (grdAboneDergi.CurrentRow == null) return;
            var obj = (AboneDergiViewModel)grdAboneDergi.CurrentRow.DataBoundItem;
            FillScreen(obj, groupBox1);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            var aboneDergi = new AboneDergi();
            SetFromScreen(aboneDergi, groupBox1);
            UnitOfWork.Instance.GetRepository<AboneDergi>().Update(aboneDergi);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Dergi Guncellendi");
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<Dergi.Model.Dergi>().Delete(Dergi.Business.Util.ConvertInt32(txtId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Dergisi Silindi");
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void btnAboneSec_Click(object sender, EventArgs e)
        {
            var aboneForm = new AboneForm(true);
            aboneForm.ShowDialog();
            var abone = (Abone)aboneForm.Tag;
            if (abone == null) return;
            numAboneId.Text = abone.Id.ToString();
            txtName.Text = abone.Name;
            txtSurname.Text = abone.Surname;
            tool_SwGetButtonClicked(sender, e);
        }
    }
}
