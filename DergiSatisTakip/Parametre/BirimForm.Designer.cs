using DergiSatisTakip.Generic;

namespace DergiSatisTakip.Parametre
{
    partial class BirimForm
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
            this.tool = new DergiSatisTakip.Generic.MasterTool();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdBirim = new System.Windows.Forms.DataGridView();
            this.bolgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimTurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBolge = new System.Windows.Forms.ComboBox();
            this.cmbBirimTur = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.numId = new DergiSatisTakip.NumericTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridBolgeCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bolgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridBirimTurCombo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.birimTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimTurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tool
            // 
            this.tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(415, 32);
            this.tool.TabIndex = 0;
            this.tool.SwGetButtonClicked += new System.EventHandler(this.tool_SwGetButtonClicked);
            this.tool.SwUpdateButtonClicked += new System.EventHandler(this.tool_SwUpdateButtonClicked);
            this.tool.SwDeleteButtonClicked += new System.EventHandler(this.tool_SwDeleteButtonClicked);
            this.tool.SwSaveButtonClicked += new System.EventHandler(this.tool_SwSaveButtonClicked);
            this.tool.SwClearButtonClicked += new System.EventHandler(this.tool_SwClearButtonClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 386);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdBirim);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Birim Listesi";
            // 
            // grdBirim
            // 
            this.grdBirim.AutoGenerateColumns = false;
            this.grdBirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBirim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.GridBolgeCombo,
            this.bolgeDataGridViewTextBoxColumn,
            this.GridBirimTurCombo,
            this.birimTurDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn});
            this.grdBirim.DataSource = this.birimBindingSource;
            this.grdBirim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBirim.Location = new System.Drawing.Point(3, 18);
            this.grdBirim.Name = "grdBirim";
            this.grdBirim.RowTemplate.Height = 24;
            this.grdBirim.Size = new System.Drawing.Size(409, 168);
            this.grdBirim.TabIndex = 0;
            this.grdBirim.Click += new System.EventHandler(this.grdBirim_Click);
            // 
            // bolgeBindingSource
            // 
            this.bolgeBindingSource.DataSource = typeof(Dergi.Model.Bolge);
            // 
            // birimTurBindingSource
            // 
            this.birimTurBindingSource.DataSource = typeof(Dergi.Model.BirimTur);
            // 
            // birimBindingSource
            // 
            this.birimBindingSource.DataSource = typeof(Dergi.Model.Birim);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBolge);
            this.groupBox1.Controls.Add(this.cmbBirimTur);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.numId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Birim Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Bölge";
            // 
            // cmbBolge
            // 
            this.cmbBolge.AccessibleName = "BolgeId";
            this.cmbBolge.DataSource = this.bolgeBindingSource;
            this.cmbBolge.DisplayMember = "Name";
            this.cmbBolge.FormattingEnabled = true;
            this.cmbBolge.Location = new System.Drawing.Point(150, 116);
            this.cmbBolge.Name = "cmbBolge";
            this.cmbBolge.Size = new System.Drawing.Size(141, 24);
            this.cmbBolge.TabIndex = 33;
            this.cmbBolge.ValueMember = "Id";
            // 
            // cmbBirimTur
            // 
            this.cmbBirimTur.AccessibleName = "BirimTurId";
            this.cmbBirimTur.DataSource = this.birimTurBindingSource;
            this.cmbBirimTur.DisplayMember = "Name";
            this.cmbBirimTur.FormattingEnabled = true;
            this.cmbBirimTur.Location = new System.Drawing.Point(150, 86);
            this.cmbBirimTur.Name = "cmbBirimTur";
            this.cmbBirimTur.Size = new System.Drawing.Size(141, 24);
            this.cmbBirimTur.TabIndex = 32;
            this.cmbBirimTur.ValueMember = "Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Durum";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AccessibleName = "Status";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(150, 56);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(141, 24);
            this.cmbStatus.TabIndex = 30;
            // 
            // numId
            // 
            this.numId.AccessibleName = "Id";
            this.numId.AllowSpace = false;
            this.numId.Location = new System.Drawing.Point(367, 28);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(21, 22);
            this.numId.TabIndex = 29;
            this.numId.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "Name";
            this.txtName.Location = new System.Drawing.Point(150, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 22);
            this.txtName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Birim Tür";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Durum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Birim";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // GridBolgeCombo
            // 
            this.GridBolgeCombo.DataPropertyName = "BolgeId";
            this.GridBolgeCombo.DataSource = this.bolgeBindingSource;
            this.GridBolgeCombo.DisplayMember = "Name";
            this.GridBolgeCombo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.GridBolgeCombo.HeaderText = "Bölge";
            this.GridBolgeCombo.Name = "GridBolgeCombo";
            this.GridBolgeCombo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBolgeCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GridBolgeCombo.ValueMember = "Id";
            // 
            // bolgeDataGridViewTextBoxColumn
            // 
            this.bolgeDataGridViewTextBoxColumn.DataPropertyName = "Bolge";
            this.bolgeDataGridViewTextBoxColumn.HeaderText = "Bolge";
            this.bolgeDataGridViewTextBoxColumn.Name = "bolgeDataGridViewTextBoxColumn";
            this.bolgeDataGridViewTextBoxColumn.Visible = false;
            // 
            // GridBirimTurCombo
            // 
            this.GridBirimTurCombo.DataPropertyName = "BirimTurId";
            this.GridBirimTurCombo.DataSource = this.birimTurBindingSource;
            this.GridBirimTurCombo.DisplayMember = "Name";
            this.GridBirimTurCombo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.GridBirimTurCombo.HeaderText = "Birim Tür";
            this.GridBirimTurCombo.MaxDropDownItems = 99;
            this.GridBirimTurCombo.Name = "GridBirimTurCombo";
            this.GridBirimTurCombo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GridBirimTurCombo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GridBirimTurCombo.ValueMember = "Id";
            // 
            // birimTurDataGridViewTextBoxColumn
            // 
            this.birimTurDataGridViewTextBoxColumn.DataPropertyName = "BirimTur";
            this.birimTurDataGridViewTextBoxColumn.HeaderText = "BirimTur";
            this.birimTurDataGridViewTextBoxColumn.Name = "birimTurDataGridViewTextBoxColumn";
            this.birimTurDataGridViewTextBoxColumn.Visible = false;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // BirimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool);
            this.Name = "BirimForm";
            this.Text = "Birim Tanım";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimTurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MasterTool tool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdBirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBolge;
        private System.Windows.Forms.ComboBox cmbBirimTur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private NumericTextBox numId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource birimBindingSource;
        private System.Windows.Forms.BindingSource bolgeBindingSource;
        private System.Windows.Forms.BindingSource birimTurBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GridBolgeCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GridBirimTurCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
    }
}