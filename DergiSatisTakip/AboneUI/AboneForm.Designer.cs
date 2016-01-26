using DergiSatisTakip.Generic;

namespace DergiSatisTakip.AboneUI
{
    partial class AboneForm
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
            this.grdAbone = new System.Windows.Forms.DataGridView();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridAboneTypeCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aboneTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridBirimCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.birimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstDergiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDergiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAboneType = new System.Windows.Forms.ComboBox();
            this.numId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToplamDergi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLastDergi = new System.Windows.Forms.ComboBox();
            this.dergiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFirstDergi = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tool = new DergiSatisTakip.Generic.MasterTool();
            this.ıslemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAbone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemTypeBindingSource)).BeginInit();
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
            this.groupBox2.Controls.Add(this.grdAbone);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abone Listesi";
            // 
            // grdAbone
            // 
            this.grdAbone.AutoGenerateColumns = false;
            this.grdAbone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAbone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.GridAboneTypeCombo,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.GridBirimCombo,
            this.birimDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.firstDergiIdDataGridViewTextBoxColumn,
            this.lastDergiIdDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn,
            this.aboneTypeIdDataGridViewTextBoxColumn});
            this.grdAbone.DataSource = this.aboneBindingSource;
            this.grdAbone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAbone.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.grdAbone.Location = new System.Drawing.Point(3, 18);
            this.grdAbone.Name = "grdAbone";
            this.grdAbone.RowTemplate.Height = 24;
            this.grdAbone.Size = new System.Drawing.Size(927, 202);
            this.grdAbone.TabIndex = 0;
            this.grdAbone.Click += new System.EventHandler(this.grdAbone_Click);
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Abone Durumu";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // GridAboneTypeCombo
            // 
            this.GridAboneTypeCombo.DataPropertyName = "AboneTypeId";
            this.GridAboneTypeCombo.DataSource = this.aboneTypeBindingSource;
            this.GridAboneTypeCombo.DisplayMember = "Name";
            this.GridAboneTypeCombo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.GridAboneTypeCombo.HeaderText = "Abone Tipi";
            this.GridAboneTypeCombo.MaxDropDownItems = 99;
            this.GridAboneTypeCombo.Name = "GridAboneTypeCombo";
            this.GridAboneTypeCombo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAboneTypeCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GridAboneTypeCombo.ValueMember = "Id";
            this.GridAboneTypeCombo.Width = 150;
            // 
            // aboneTypeBindingSource
            // 
            this.aboneTypeBindingSource.DataSource = typeof(Dergi.Model.AboneType);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "A.Başlangıç Tarihi";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "A. Bitiş Tarihi";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // GridBirimCombo
            // 
            this.GridBirimCombo.DataPropertyName = "BirimId";
            this.GridBirimCombo.DataSource = this.birimBindingSource;
            this.GridBirimCombo.DisplayMember = "Name";
            this.GridBirimCombo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.GridBirimCombo.HeaderText = "Birim";
            this.GridBirimCombo.Name = "GridBirimCombo";
            this.GridBirimCombo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBirimCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GridBirimCombo.ValueMember = "Id";
            // 
            // birimBindingSource
            // 
            this.birimBindingSource.DataSource = typeof(Dergi.Model.Birim);
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "Birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "Birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            this.birimDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Dergi Sayısı";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstDergiIdDataGridViewTextBoxColumn
            // 
            this.firstDergiIdDataGridViewTextBoxColumn.DataPropertyName = "FirstDergiId";
            this.firstDergiIdDataGridViewTextBoxColumn.HeaderText = "FirstDergiId";
            this.firstDergiIdDataGridViewTextBoxColumn.Name = "firstDergiIdDataGridViewTextBoxColumn";
            this.firstDergiIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastDergiIdDataGridViewTextBoxColumn
            // 
            this.lastDergiIdDataGridViewTextBoxColumn.DataPropertyName = "LastDergiId";
            this.lastDergiIdDataGridViewTextBoxColumn.HeaderText = "LastDergiId";
            this.lastDergiIdDataGridViewTextBoxColumn.Name = "lastDergiIdDataGridViewTextBoxColumn";
            this.lastDergiIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // aboneTypeIdDataGridViewTextBoxColumn
            // 
            this.aboneTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AboneType";
            this.aboneTypeIdDataGridViewTextBoxColumn.HeaderText = "Abone Tipi";
            this.aboneTypeIdDataGridViewTextBoxColumn.Name = "aboneTypeIdDataGridViewTextBoxColumn";
            this.aboneTypeIdDataGridViewTextBoxColumn.Visible = false;
            this.aboneTypeIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // aboneBindingSource
            // 
            this.aboneBindingSource.DataSource = typeof(Dergi.Model.Abone);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbAboneType);
            this.groupBox1.Controls.Add(this.numId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtToplamDergi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbLastDergi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbFirstDergi);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtEndDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.cmbBirim);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Abone Durumu";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AccessibleName = "Status";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(542, 35);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 24);
            this.cmbStatus.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Abone Tipi";
            // 
            // cmbAboneType
            // 
            this.cmbAboneType.AccessibleName = "AboneTypeId";
            this.cmbAboneType.DataSource = this.aboneTypeBindingSource;
            this.cmbAboneType.DisplayMember = "Name";
            this.cmbAboneType.FormattingEnabled = true;
            this.cmbAboneType.Location = new System.Drawing.Point(542, 65);
            this.cmbAboneType.Name = "cmbAboneType";
            this.cmbAboneType.Size = new System.Drawing.Size(191, 24);
            this.cmbAboneType.TabIndex = 7;
            this.cmbAboneType.ValueMember = "Id";
            // 
            // numId
            // 
            this.numId.AccessibleName = "Id";
            this.numId.Location = new System.Drawing.Point(879, 49);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(0, 22);
            this.numId.TabIndex = 20;
            this.numId.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Toplam Dergi";
            // 
            // txtToplamDergi
            // 
            this.txtToplamDergi.AccessibleName = "Count";
            this.txtToplamDergi.Location = new System.Drawing.Point(542, 185);
            this.txtToplamDergi.Name = "txtToplamDergi";
            this.txtToplamDergi.Size = new System.Drawing.Size(191, 22);
            this.txtToplamDergi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(401, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Son Dergi";
            // 
            // cmbLastDergi
            // 
            this.cmbLastDergi.AccessibleName = "LastDergiId";
            this.cmbLastDergi.DataSource = this.dergiBindingSource;
            this.cmbLastDergi.DisplayMember = "Name";
            this.cmbLastDergi.FormattingEnabled = true;
            this.cmbLastDergi.Location = new System.Drawing.Point(542, 155);
            this.cmbLastDergi.Name = "cmbLastDergi";
            this.cmbLastDergi.Size = new System.Drawing.Size(191, 24);
            this.cmbLastDergi.TabIndex = 10;
            this.cmbLastDergi.ValueMember = "Id";
            // 
            // dergiBindingSource
            // 
            this.dergiBindingSource.DataSource = typeof(Dergi.Model.Dergi);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "İlk Dergi";
            // 
            // cmbFirstDergi
            // 
            this.cmbFirstDergi.AccessibleName = "FirstDergiId";
            this.cmbFirstDergi.DataSource = this.dergiBindingSource;
            this.cmbFirstDergi.DisplayMember = "Name";
            this.cmbFirstDergi.FormattingEnabled = true;
            this.cmbFirstDergi.Location = new System.Drawing.Point(542, 125);
            this.cmbFirstDergi.Name = "cmbFirstDergi";
            this.cmbFirstDergi.Size = new System.Drawing.Size(191, 24);
            this.cmbFirstDergi.TabIndex = 9;
            this.cmbFirstDergi.ValueMember = "Id";
            // 
            // txtDescription
            // 
            this.txtDescription.AccessibleName = "Description";
            this.txtDescription.Location = new System.Drawing.Point(158, 149);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 50);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Birim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "A. Bitiş Tarihi";
            // 
            // dtEndDate
            // 
            this.dtEndDate.AccessibleName = "EndDate";
            this.dtEndDate.Location = new System.Drawing.Point(158, 121);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(191, 22);
            this.dtEndDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "A. Başlangıç Tarihi";
            // 
            // txtSurname
            // 
            this.txtSurname.AccessibleName = "Surname";
            this.txtSurname.Location = new System.Drawing.Point(158, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SoyAdı";
            // 
            // dtStartDate
            // 
            this.dtStartDate.AccessibleName = "StartDate";
            this.dtStartDate.Location = new System.Drawing.Point(158, 93);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(191, 22);
            this.dtStartDate.TabIndex = 3;
            // 
            // cmbBirim
            // 
            this.cmbBirim.AccessibleName = "BirimId";
            this.cmbBirim.DataSource = this.birimBindingSource;
            this.cmbBirim.DisplayMember = "Name";
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(542, 95);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(191, 24);
            this.cmbBirim.TabIndex = 8;
            this.cmbBirim.ValueMember = "Id";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "Name";
            this.txtName.Location = new System.Drawing.Point(158, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // statusTypeBindingSource
            // 
            this.statusTypeBindingSource.DataSource = typeof(Dergi.Model.Util.StatusType);
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
            // ıslemTypeBindingSource
            // 
            this.ıslemTypeBindingSource.DataSource = typeof(Dergi.Model.Util.IslemType);
            // 
            // AboneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool);
            this.Name = "AboneForm";
            this.Text = "Abone İşlem";
            this.Load += new System.EventHandler(this.AboneForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAbone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboneBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MasterTool tool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.DataGridView grdAbone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLastDergi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFirstDergi;
        private System.Windows.Forms.TextBox txtToplamDergi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource birimBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDergiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDergiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox numId;
        private System.Windows.Forms.BindingSource ıslemTypeBindingSource;
        private System.Windows.Forms.BindingSource aboneBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAboneType;
        private System.Windows.Forms.BindingSource dergiBindingSource;
        private System.Windows.Forms.BindingSource statusTypeBindingSource;
        private System.Windows.Forms.BindingSource aboneTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GridAboneTypeCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GridBirimCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDergiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDergiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneTypeIdDataGridViewTextBoxColumn;
    }
}