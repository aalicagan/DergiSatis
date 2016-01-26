using System;
using System.Windows.Forms;

namespace DergiSatisTakip.Generic
{
    public partial class MasterTool : UserControl
    {
        public event EventHandler SwGetButtonClicked;
        public event EventHandler SwUpdateButtonClicked;
        public event EventHandler SwDeleteButtonClicked;
        public event EventHandler SwSaveButtonClicked;
        public event EventHandler SwClearButtonClicked;
        public MasterTool()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (SwGetButtonClicked != null)
            {
                SwGetButtonClicked(sender, e);
            }
        }

        private void bntKaydet_Click(object sender, EventArgs e)
        {
            if (SwSaveButtonClicked != null)
            {
                SwSaveButtonClicked(sender, e);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (SwUpdateButtonClicked != null)
            {
                SwUpdateButtonClicked(sender, e);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (SwClearButtonClicked != null)
            {
                SwClearButtonClicked(sender, e);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SwDeleteButtonClicked != null)
            {
                SwDeleteButtonClicked(sender, e);
            }
        }
    }
}
