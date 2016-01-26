using System;
using System.Linq;
using System.Windows.Forms;
using Dergi.Business;
using Dergi.Business.Uow;
using Dergi.Model;
using DergiSatisTakip.Generic;
using Util = Dergi.Business.Util;

namespace DergiSatisTakip.AboneUI
{
    public partial class AboneForm : MainForm
    {
        private readonly bool _isOut;

        public AboneForm(bool isOut)
        {
            _isOut = isOut;
            InitializeComponent();
        }
        public AboneForm()
        {
            InitializeComponent();
        }

        private void tool_SwSaveButtonClicked(object sender, EventArgs e)
        {
            var abone = new Abone();
            SetFromScreen(abone, groupBox1);
            AboneService.Instance.AboneInsert(abone);
            MessageBox.Show(@"Abone Eklendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
            
        }
        private void tool_SwGetButtonClicked(object sender, EventArgs e)
        {
            grdAbone.DataSource = UnitOfWork.Instance.GetRepository<Abone>().Filter(x=>x.Name.Contains(txtName.Text) && x.Surname.Contains(txtSurname.Text)).AsEnumerable().ToList();
            grdAbone.Refresh();
        }
        private void grdAbone_Click(object sender, EventArgs e)
        {
            if (grdAbone.CurrentRow == null) return;
            var obj = (Abone)grdAbone.CurrentRow.DataBoundItem;
            if (_isOut)
            {
                Tag = obj;
                Close();
                return;
            }
            FillScreen(obj, groupBox1);
        }

        private void tool_SwDeleteButtonClicked(object sender, EventArgs e)
        {
            UnitOfWork.Instance.GetRepository<Abone>().Delete(Util.ConvertInt32(numId.Text));
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Silindi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void tool_SwClearButtonClicked(object sender, EventArgs e)
        {
            Clear(groupBox1);
        }

        private void tool_SwUpdateButtonClicked(object sender, EventArgs e)
        {
            var abone = new Abone();
            SetFromScreen(abone, groupBox1);
            UnitOfWork.Instance.GetRepository<Abone>().Update(abone);
            UnitOfWork.Instance.Save();
            MessageBox.Show(@"Abone Guncellendi");
            Clear(groupBox1);
            tool_SwGetButtonClicked(sender, e);
        }

        private void AboneForm_Load(object sender, EventArgs e)
        {
            var birims = UnitOfWork.Instance.GetRepository<Birim>().SelectAll().ToList();
            cmbBirim.DataSource = birims;
            cmbFirstDergi.DataSource = DergiService.Instance.GetAllList();
            cmbLastDergi.DataSource = DergiService.Instance.GetAllList();
            SetEnumValues(cmbStatus, typeof(Dergi.Model.Util.StatusType));
            cmbAboneType.DataSource = UnitOfWork.Instance.GetRepository<AboneType>().SelectAll().ToList();
            GridAboneTypeCombo.DataSource = cmbAboneType.DataSource;
            GridBirimCombo.DataSource = birims;
            numId.Text = @"0";
        }
    }
}
