using System;
using System.Windows.Forms;

namespace DergiSatisTakip.Main
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            var masterForm = new MasterForm();
            masterForm.Closed += (s, args) => Close();
            masterForm.Show();
        }
    }
}
