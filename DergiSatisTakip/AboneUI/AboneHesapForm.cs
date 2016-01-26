using System;
using System.Windows.Forms;
using Dergi.Business;
using Dergi.Business.Uow;
using Dergi.Business.ViewModel;
using Dergi.Model;
using DergiSatisTakip.Generic;
using Util = Dergi.Model.Util;

namespace DergiSatisTakip.AboneUI
{
    public partial class AboneHesapForm : MainForm
    {
        public AboneHesapForm()
        {
            InitializeComponent();
            SetEnumValues(cmbIslemType, typeof(Util.IslemType));
            numId.Text = @"0";
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            var aboneHesap = new AboneHesap();
            SetFromScreen(aboneHesap, groupBox1);
            UnitOfWork.Instance.GetRepository<AboneHesap>().Create(aboneHesap);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Hesabı Eklendi");
            tool_SwGetButtonClicked(sender, e);
        }
        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            var model = AboneService.Instance.GetAboneHesapList(Dergi.Business.Util.ConvertInt32(numAboneId.Text));
            grdAboneHesap.DataSource = model.AboneHesapViewModels;
            lblBalance.Text = model.Balance.ToString("C");
        }
        private void grdAboneHesap_Click(object sender, EventArgs e)
        {
            if (grdAboneHesap.CurrentRow == null) return;
            var obj = (AboneHesapViewModel)grdAboneHesap.CurrentRow.DataBoundItem;
            FillScreen(obj, groupBox1);
        }
        private void btnAboneSec_Click(object sender, EventArgs e)
        {
            var aboneForm = new AboneForm(true);
            aboneForm.ShowDialog();
            var abone = (Abone) aboneForm.Tag;
            if (abone == null) return;
            numAboneId.Text = abone.Id.ToString();
            txtName.Text = abone.Name;
            txtSurname.Text = abone.Surname;
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            var aboneHesap = new AboneHesap();
            SetFromScreen(aboneHesap, groupBox1);
            UnitOfWork.Instance.GetRepository<AboneHesap>().Update(aboneHesap);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Hesap İşlemi Guncellendi");
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<AboneHesap>().Delete(Dergi.Business.Util.ConvertInt32(numId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Hesabı Silindi");
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            CreatePdf(grdAboneHesap, "AboneHesap" + DateTime.Now.ToShortDateString());
            MessageBox.Show(@"Pdf Yaratıldı");
        }
    }
}
