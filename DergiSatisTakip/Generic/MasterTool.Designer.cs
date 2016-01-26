namespace DergiSatisTakip.Generic
{
    partial class MasterTool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterTool));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGetir = new System.Windows.Forms.ToolStripButton();
            this.bntKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnGuncelle = new System.Windows.Forms.ToolStripButton();
            this.btnTemizle = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGetir,
            this.bntKaydet,
            this.btnGuncelle,
            this.btnTemizle,
            this.btnSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetir.Image = ((System.Drawing.Image)(resources.GetObject("btnGetir.Image")));
            this.btnGetir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(65, 29);
            this.btnGetir.Text = "Getir";
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // bntKaydet
            // 
            this.bntKaydet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntKaydet.Image = ((System.Drawing.Image)(resources.GetObject("bntKaydet.Image")));
            this.bntKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bntKaydet.Name = "bntKaydet";
            this.bntKaydet.Size = new System.Drawing.Size(79, 29);
            this.bntKaydet.Text = "Kaydet";
            this.bntKaydet.Click += new System.EventHandler(this.bntKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 29);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 29);
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(49, 29);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // MasterTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "MasterTool";
            this.Size = new System.Drawing.Size(600, 32);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGetir;
        private System.Windows.Forms.ToolStripButton bntKaydet;
        private System.Windows.Forms.ToolStripButton btnGuncelle;
        private System.Windows.Forms.ToolStripButton btnTemizle;
        private System.Windows.Forms.ToolStripButton btnSil;
    }
}
