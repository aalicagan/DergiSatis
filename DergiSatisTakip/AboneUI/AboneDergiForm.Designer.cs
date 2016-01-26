using DergiSatisTakip.Generic;

namespace DergiSatisTakip.AboneUI
{
    partial class AboneDergiForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdAboneDergi = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dergiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dergiNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısDeliveredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aboneDergiViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsDelivered = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.numAboneId = new DergiSatisTakip.NumericTextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAboneSec = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDergi = new System.Windows.Forms.ComboBox();
            this.dergiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.tool = new DergiSatisTakip.Generic.MasterTool();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAboneDergi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneDergiViewModelBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 475);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdAboneDergi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abone Dergi Listesi";
            // 
            // grdAboneDergi
            // 
            this.grdAboneDergi.AutoGenerateColumns = false;
            this.grdAboneDergi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAboneDergi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.aboneIdDataGridViewTextBoxColumn,
            this.dergiIdDataGridViewTextBoxColumn,
            this.aboneNameDataGridViewTextBoxColumn,
            this.aboneSurnameDataGridViewTextBoxColumn,
            this.dergiNameDataGridViewTextBoxColumn,
            this.ıslemDateDataGridViewTextBoxColumn,
            this.ısDeliveredDataGridViewCheckBoxColumn});
            this.grdAboneDergi.DataSource = this.aboneDergiViewModelBindingSource;
            this.grdAboneDergi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAboneDergi.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grdAboneDergi.Location = new System.Drawing.Point(3, 18);
            this.grdAboneDergi.Name = "grdAboneDergi";
            this.grdAboneDergi.RowTemplate.Height = 24;
            this.grdAboneDergi.Size = new System.Drawing.Size(927, 202);
            this.grdAboneDergi.TabIndex = 0;
            this.grdAboneDergi.Click += new System.EventHandler(this.grdAboneDergi_Click);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // aboneIdDataGridViewTextBoxColumn
            // 
            this.aboneIdDataGridViewTextBoxColumn.DataPropertyName = "AboneId";
            this.aboneIdDataGridViewTextBoxColumn.HeaderText = "AboneId";
            this.aboneIdDataGridViewTextBoxColumn.Name = "aboneIdDataGridViewTextBoxColumn";
            this.aboneIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dergiIdDataGridViewTextBoxColumn
            // 
            this.dergiIdDataGridViewTextBoxColumn.DataPropertyName = "DergiId";
            this.dergiIdDataGridViewTextBoxColumn.HeaderText = "DergiId";
            this.dergiIdDataGridViewTextBoxColumn.Name = "dergiIdDataGridViewTextBoxColumn";
            this.dergiIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // aboneNameDataGridViewTextBoxColumn
            // 
            this.aboneNameDataGridViewTextBoxColumn.DataPropertyName = "AboneName";
            this.aboneNameDataGridViewTextBoxColumn.HeaderText = "Abone Adı";
            this.aboneNameDataGridViewTextBoxColumn.Name = "aboneNameDataGridViewTextBoxColumn";
            // 
            // aboneSurnameDataGridViewTextBoxColumn
            // 
            this.aboneSurnameDataGridViewTextBoxColumn.DataPropertyName = "AboneSurname";
            this.aboneSurnameDataGridViewTextBoxColumn.HeaderText = "Abone Soyadı";
            this.aboneSurnameDataGridViewTextBoxColumn.Name = "aboneSurnameDataGridViewTextBoxColumn";
            this.aboneSurnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dergiNameDataGridViewTextBoxColumn
            // 
            this.dergiNameDataGridViewTextBoxColumn.DataPropertyName = "DergiName";
            this.dergiNameDataGridViewTextBoxColumn.HeaderText = "Dergi Adı";
            this.dergiNameDataGridViewTextBoxColumn.Name = "dergiNameDataGridViewTextBoxColumn";
            // 
            // ıslemDateDataGridViewTextBoxColumn
            // 
            this.ıslemDateDataGridViewTextBoxColumn.DataPropertyName = "IslemDate";
            this.ıslemDateDataGridViewTextBoxColumn.HeaderText = "İşlem Tarihi";
            this.ıslemDateDataGridViewTextBoxColumn.Name = "ıslemDateDataGridViewTextBoxColumn";
            this.ıslemDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // ısDeliveredDataGridViewCheckBoxColumn
            // 
            this.ısDeliveredDataGridViewCheckBoxColumn.DataPropertyName = "IsDelivered";
            this.ısDeliveredDataGridViewCheckBoxColumn.HeaderText = "Teslim Edildi Mi?";
            this.ısDeliveredDataGridViewCheckBoxColumn.Name = "ısDeliveredDataGridViewCheckBoxColumn";
            this.ısDeliveredDataGridViewCheckBoxColumn.Width = 150;
            // 
            // aboneDergiViewModelBindingSource
            // 
            this.aboneDergiViewModelBindingSource.DataSource = typeof(Dergi.Business.ViewModel.AboneDergiViewModel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsDelivered);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.numAboneId);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAboneSec);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbDergi);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Dergi Bilgileri";
            // 
            // chkIsDelivered
            // 
            this.chkIsDelivered.AccessibleName = "IsDelivered";
            this.chkIsDelivered.AutoSize = true;
            this.chkIsDelivered.Location = new System.Drawing.Point(139, 166);
            this.chkIsDelivered.Name = "chkIsDelivered";
            this.chkIsDelivered.Size = new System.Drawing.Size(135, 21);
            this.chkIsDelivered.TabIndex = 51;
            this.chkIsDelivered.Text = "Teslim Edildi Mi?";
            this.chkIsDelivered.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkIsDelivered.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "İşlem Tarihi";
            // 
            // dtEndDate
            // 
            this.dtEndDate.AccessibleName = "IslemDate";
            this.dtEndDate.Location = new System.Drawing.Point(139, 123);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(191, 22);
            this.dtEndDate.TabIndex = 49;
            // 
            // numAboneId
            // 
            this.numAboneId.AccessibleName = "AboneId";
            this.numAboneId.AllowSpace = false;
            this.numAboneId.Location = new System.Drawing.Point(885, 36);
            this.numAboneId.Name = "numAboneId";
            this.numAboneId.Size = new System.Drawing.Size(16, 22);
            this.numAboneId.TabIndex = 48;
            this.numAboneId.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.AccessibleName = "AboneSurname";
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(139, 94);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 22);
            this.txtSurname.TabIndex = 45;
            this.txtSurname.Tag = "Required";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Abone Soyadı";
            // 
            // btnAboneSec
            // 
            this.btnAboneSec.Location = new System.Drawing.Point(336, 66);
            this.btnAboneSec.Name = "btnAboneSec";
            this.btnAboneSec.Size = new System.Drawing.Size(55, 50);
            this.btnAboneSec.TabIndex = 46;
            this.btnAboneSec.Text = "Getir";
            this.btnAboneSec.UseVisualStyleBackColor = true;
            this.btnAboneSec.Click += new System.EventHandler(this.btnAboneSec_Click);
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "AboneName";
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(139, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 44;
            this.txtName.Tag = "Required";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Abone Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Dergi Seç";
            // 
            // cmbDergi
            // 
            this.cmbDergi.AccessibleName = "DergiId";
            this.cmbDergi.DataSource = this.dergiBindingSource;
            this.cmbDergi.DisplayMember = "Name";
            this.cmbDergi.FormattingEnabled = true;
            this.cmbDergi.Location = new System.Drawing.Point(139, 36);
            this.cmbDergi.Name = "cmbDergi";
            this.cmbDergi.Size = new System.Drawing.Size(191, 24);
            this.cmbDergi.TabIndex = 41;
            this.cmbDergi.Tag = "Required";
            this.cmbDergi.ValueMember = "Id";
            // 
            // dergiBindingSource
            // 
            this.dergiBindingSource.DataSource = typeof(Dergi.Model.Dergi);
            // 
            // txtId
            // 
            this.txtId.AccessibleName = "Id";
            this.txtId.Location = new System.Drawing.Point(879, 49);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 22);
            this.txtId.TabIndex = 20;
            this.txtId.Text = "0";
            // 
            // txtStatus
            // 
            this.txtStatus.AccessibleName = "Status";
            this.txtStatus.Location = new System.Drawing.Point(879, 21);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 22);
            this.txtStatus.TabIndex = 19;
            this.txtStatus.Text = "1";
            // 
            // tool
            // 
            this.tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(933, 32);
            this.tool.TabIndex = 1;
            this.tool.SwGetButtonClicked += new System.EventHandler(this.tool_SwGetButtonClicked);
            this.tool.SwUpdateButtonClicked += new System.EventHandler(this.tool_SwUpdateButtonClicked);
            this.tool.SwDeleteButtonClicked += new System.EventHandler(this.tool_SwDeleteButtonClicked);
            this.tool.SwSaveButtonClicked += new System.EventHandler(this.tool_SwSaveButtonClicked);
            this.tool.SwClearButtonClicked += new System.EventHandler(this.tool_SwClearButtonClicked);
            // 
            // AboneDergiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool);
            this.Name = "AboneDergiForm";
            this.Text = "Abone Dergi";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAboneDergi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneDergiViewModelBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MasterTool tool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdAboneDergi;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDergiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDergiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.BindingSource dergiBindingSource;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAboneSec;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDergi;
        private NumericTextBox numAboneId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.CheckBox chkIsDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dergiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dergiNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısDeliveredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource aboneDergiViewModelBindingSource;
    }
}