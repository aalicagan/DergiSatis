using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dergi.Business;
using Dergi.Business.ViewModel;
using Dergi.Model;
using DergiSatisTakip.Generic;

namespace DergiSatisTakip.AboneUI
{
    public partial class TahakkukForm : MainForm
    {
        public TahakkukForm()
        {
            InitializeComponent();
            cmbDergi.DataSource = DergiService.Instance.GetAllList();
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
        }

        private void btnTahakkuk_Click(object sender, EventArgs e)
        {
            try
            {
                var tahakkukViewModel = new TahakkukViewModel();
                SetFromScreen(tahakkukViewModel, panel1);
                TahakkukService.Instance.DoTakukkukProcess(tahakkukViewModel);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
