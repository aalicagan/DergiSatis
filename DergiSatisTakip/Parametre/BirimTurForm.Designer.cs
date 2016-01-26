using DergiSatisTakip.Generic;

namespace DergiSatisTakip.Parametre
{
    partial class BirimTurForm
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
            this.birimTurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dergiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdBirimTur = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numId = new DergiSatisTakip.NumericTextBox();
            this.tool = new DergiSatisTakip.Generic.MasterTool();
            ((System.ComponentModel.ISupportInitialize)(this.birimTurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBirimTur)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // birimTurBindingSource
            // 
            this.birimTurBindingSource.DataSource = typeof(Dergi.Model.BirimTur);
            // 
            // statusTypeBindingSource
            // 
            this.statusTypeBindingSource.DataSource = typeof(Dergi.Model.Util.StatusType);
            // 
            // dergiBindingSource
            // 
            this.dergiBindingSource.DataSource = typeof(Dergi.Model.Dergi);
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
            this.groupBox2.Controls.Add(this.grdBirimTur);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Birim Tür Listesi";
            // 
            // grdBirimTur
            // 
            this.grdBirimTur.AutoGenerateColumns = false;
            this.grdBirimTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBirimTur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn});
            this.grdBirimTur.DataSource = this.birimTurBindingSource;
            this.grdBirimTur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBirimTur.Location = new System.Drawing.Point(3, 18);
            this.grdBirimTur.Name = "grdBirimTur";
            this.grdBirimTur.RowTemplate.Height = 24;
            this.grdBirimTur.Size = new System.Drawing.Size(409, 251);
            this.grdBirimTur.TabIndex = 0;
            this.grdBirimTur.Click += new System.EventHandler(this.grdBirimTur_Click);
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Birim Tür";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.numId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birim Tür";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Durum";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AccessibleName = "Status";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(159, 65);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(141, 24);
            this.cmbStatus.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "Name";
            this.txtName.Location = new System.Drawing.Point(159, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birim Tür";
            // 
            // numId
            // 
            this.numId.AccessibleName = "Id";
            this.numId.AllowSpace = false;
            this.numId.Location = new System.Drawing.Point(376, 37);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(21, 22);
            this.numId.TabIndex = 16;
            this.numId.Visible = false;
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
            // BirimTurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool);
            this.Name = "BirimTurForm";
            this.Text = "Birim Tür Tanım";
            ((System.ComponentModel.ISupportInitialize)(this.birimTurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dergiBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBirimTur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MasterTool tool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdBirimTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dergiBindingSource;
        private NumericTextBox numId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.BindingSource statusTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource birimTurBindingSource;
    }
}