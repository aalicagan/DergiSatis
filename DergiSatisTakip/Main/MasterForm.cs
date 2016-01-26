using System;
using System.Windows.Forms;

namespace DergiSatisTakip.Main
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = (ToolStripMenuItem)e.ClickedItem;
            if (item.Tag == null) return;
            var t = Type.GetType(item.Tag.ToString());
            if (t == null) return;
            dynamic mdiForm = Activator.CreateInstance(t);
            if (mdiForm == null) return;
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            mdiForm.MdiParent = this;
            mdiForm.WindowState = FormWindowState.Maximized;
            mdiForm.Show();
        }
    }
}
