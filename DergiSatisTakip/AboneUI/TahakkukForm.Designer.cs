namespace DergiSatisTakip.AboneUI
{
    partial class TahakkukForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTahakkuk = new System.Windows.Forms.Button();
            this.chkIsFree = new System.Windows.Forms.CheckBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAboneSec = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDergi = new System.Windows.Forms.ComboBox();
            this.dergiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numAboneId = new DergiSatisTakip.NumericTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numAboneId);
            this.panel1.Controls.Add(this.btnTahakkuk);
            this.panel1.Controls.Add(this.chkIsFree);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAboneSec);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbDergi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 365);
            this.panel1.TabIndex = 0;
            // 
            // btnTahakkuk
            // 
            this.btnTahakkuk.Location = new System.Drawing.Point(132, 175);
            this.btnTahakkuk.Name = "btnTahakkuk";
            this.btnTahakkuk.Size = new System.Drawing.Size(191, 50);
            this.btnTahakkuk.TabIndex = 42;
            this.btnTahakkuk.Text = "Tahakkuk Et";
            this.btnTahakkuk.UseVisualStyleBackColor = true;
            this.btnTahakkuk.Click += new System.EventHandler(this.btnTahakkuk_Click);
            // 
            // chkIsFree
            // 
            this.chkIsFree.AccessibleName = "IsFree";
            this.chkIsFree.AutoSize = true;
            this.chkIsFree.Location = new System.Drawing.Point(132, 134);
            this.chkIsFree.Name = "chkIsFree";
            this.chkIsFree.Size = new System.Drawing.Size(119, 21);
            this.chkIsFree.TabIndex = 41;
            this.chkIsFree.Text = "Tüm Aboneler";
            this.chkIsFree.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkIsFree.UseVisualStyleBackColor = true;
            // 
            // txtSurname
            // 
            this.txtSurname.AccessibleName = "AboneSurname";
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(132, 97);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 22);
            this.txtSurname.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Abone Soyadı";
            // 
            // btnAboneSec
            // 
            this.btnAboneSec.Location = new System.Drawing.Point(329, 69);
            this.btnAboneSec.Name = "btnAboneSec";
            this.btnAboneSec.Size = new System.Drawing.Size(55, 50);
            this.btnAboneSec.TabIndex = 39;
            this.btnAboneSec.Text = "Getir";
            this.btnAboneSec.UseVisualStyleBackColor = true;
            this.btnAboneSec.Click += new System.EventHandler(this.btnAboneSec_Click);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "AboneName";
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(132, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Abone Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dergi Seç";
            // 
            // cmbDergi
            // 
            this.cmbDergi.AccessibleName = "DergiId";
            this.cmbDergi.DataSource = this.dergiBindingSource;
            this.cmbDergi.DisplayMember = "Name";
            this.cmbDergi.FormattingEnabled = true;
            this.cmbDergi.Location = new System.Drawing.Point(132, 39);
            this.cmbDergi.Name = "cmbDergi";
            this.cmbDergi.Size = new System.Drawing.Size(191, 24);
            this.cmbDergi.TabIndex = 15;
            this.cmbDergi.ValueMember = "Id";
            // 
            // dergiBindingSource
            // 
            this.dergiBindingSource.DataSource = typeof(Dergi.Model.Dergi);
            // 
            // numAboneId
            // 
            this.numAboneId.AccessibleName = "AboneId";
            this.numAboneId.AllowSpace = false;
            this.numAboneId.Location = new System.Drawing.Point(417, 270);
            this.numAboneId.Name = "numAboneId";
            this.numAboneId.Size = new System.Drawing.Size(16, 22);
            this.numAboneId.TabIndex = 43;
            this.numAboneId.Visible = false;
            // 
            // TahakkukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 365);
            this.Controls.Add(this.panel1);
            this.Name = "TahakkukForm";
            this.Text = "Tahakkuk İşlemleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDergi;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAboneSec;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTahakkuk;
        private System.Windows.Forms.CheckBox chkIsFree;
        private System.Windows.Forms.BindingSource dergiBindingSource;
        private NumericTextBox numAboneId;
    }
}