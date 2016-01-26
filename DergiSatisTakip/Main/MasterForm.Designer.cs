namespace DergiSatisTakip.Main
{
    partial class MasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboneİşlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboneHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboneDetayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dergiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paremetrelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimTürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonelikTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tahakkukİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyelerToolStripMenuItem,
            this.dergiToolStripMenuItem,
            this.paremetrelerToolStripMenuItem,
            this.tahakkukİşlemleriToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(987, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboneİşlemToolStripMenuItem,
            this.aboneHesapToolStripMenuItem,
            this.aboneDetayToolStripMenuItem});
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.üyelerToolStripMenuItem.Tag = "";
            this.üyelerToolStripMenuItem.Text = "Abone";
            this.üyelerToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // aboneİşlemToolStripMenuItem
            // 
            this.aboneİşlemToolStripMenuItem.Name = "aboneİşlemToolStripMenuItem";
            this.aboneİşlemToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.aboneİşlemToolStripMenuItem.Tag = "DergiSatisTakip.AboneUI.AboneForm";
            this.aboneİşlemToolStripMenuItem.Text = "Abone İşlem";
            // 
            // aboneHesapToolStripMenuItem
            // 
            this.aboneHesapToolStripMenuItem.Name = "aboneHesapToolStripMenuItem";
            this.aboneHesapToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.aboneHesapToolStripMenuItem.Tag = "DergiSatisTakip.AboneUI.AboneHesapForm";
            this.aboneHesapToolStripMenuItem.Text = "Abone Hesap";
            // 
            // aboneDetayToolStripMenuItem
            // 
            this.aboneDetayToolStripMenuItem.Name = "aboneDetayToolStripMenuItem";
            this.aboneDetayToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.aboneDetayToolStripMenuItem.Tag = "DergiSatisTakip.AboneUI.AboneDergiForm";
            this.aboneDetayToolStripMenuItem.Text = "Abone Detay";
            // 
            // dergiToolStripMenuItem
            // 
            this.dergiToolStripMenuItem.Name = "dergiToolStripMenuItem";
            this.dergiToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.dergiToolStripMenuItem.Tag = "DergiSatisTakip.DergiUI.DergiForm";
            this.dergiToolStripMenuItem.Text = "Dergi";
            // 
            // paremetrelerToolStripMenuItem
            // 
            this.paremetrelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birimToolStripMenuItem,
            this.birimTürToolStripMenuItem,
            this.bölgeToolStripMenuItem,
            this.abonelikTipiToolStripMenuItem});
            this.paremetrelerToolStripMenuItem.Name = "paremetrelerToolStripMenuItem";
            this.paremetrelerToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.paremetrelerToolStripMenuItem.Tag = "";
            this.paremetrelerToolStripMenuItem.Text = "Paremetreler";
            this.paremetrelerToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // birimToolStripMenuItem
            // 
            this.birimToolStripMenuItem.Name = "birimToolStripMenuItem";
            this.birimToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.birimToolStripMenuItem.Tag = "DergiSatisTakip.Parametre.BirimForm";
            this.birimToolStripMenuItem.Text = "Birim";
            // 
            // birimTürToolStripMenuItem
            // 
            this.birimTürToolStripMenuItem.Name = "birimTürToolStripMenuItem";
            this.birimTürToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.birimTürToolStripMenuItem.Tag = "DergiSatisTakip.Parametre.BirimTurForm";
            this.birimTürToolStripMenuItem.Text = "Birim Tür";
            // 
            // bölgeToolStripMenuItem
            // 
            this.bölgeToolStripMenuItem.Name = "bölgeToolStripMenuItem";
            this.bölgeToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.bölgeToolStripMenuItem.Tag = "DergiSatisTakip.Parametre.BolgeForm";
            this.bölgeToolStripMenuItem.Text = "Bölge";
            // 
            // abonelikTipiToolStripMenuItem
            // 
            this.abonelikTipiToolStripMenuItem.Name = "abonelikTipiToolStripMenuItem";
            this.abonelikTipiToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.abonelikTipiToolStripMenuItem.Tag = "DergiSatisTakip.Parametre.AboneTypeForm";
            this.abonelikTipiToolStripMenuItem.Text = "Abonelik Tipi";
            // 
            // tahakkukİşlemleriToolStripMenuItem
            // 
            this.tahakkukİşlemleriToolStripMenuItem.Name = "tahakkukİşlemleriToolStripMenuItem";
            this.tahakkukİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.tahakkukİşlemleriToolStripMenuItem.Tag = "DergiSatisTakip.AboneUI.TahakkukForm";
            this.tahakkukİşlemleriToolStripMenuItem.Text = "Tahakkuk İşlemleri";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 607);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.Name = "MasterForm";
            this.Text = "Dergi Satış";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem üyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dergiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboneİşlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboneHesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboneDetayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paremetrelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimTürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonelikTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tahakkukİşlemleriToolStripMenuItem;

    }
}

