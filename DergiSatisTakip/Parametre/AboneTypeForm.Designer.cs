using DergiSatisTakip.Generic;

namespace DergiSatisTakip.Parametre
{
    partial class AboneTypeForm
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
            this.aboneTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdAboneTipi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIsFree = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numStatus = new DergiSatisTakip.NumericTextBox();
            this.numId = new DergiSatisTakip.NumericTextBox();
            this.numDergiCount = new DergiSatisTakip.NumericTextBox();
            this.numAmount = new DergiSatisTakip.NumericTextBox();
            this.tool = new DergiSatisTakip.Generic.MasterTool();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dergiCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısFreeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aboneTypeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAboneTipi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboneTypeBindingSource
            // 
            this.aboneTypeBindingSource.DataSource = typeof(Dergi.Model.AboneType);
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
            this.groupBox2.Controls.Add(this.grdAboneTipi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abone Tipi Listesi";
            // 
            // grdAboneTipi
            // 
            this.grdAboneTipi.AutoGenerateColumns = false;
            this.grdAboneTipi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAboneTipi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dergiCountDataGridViewTextBoxColumn,
            this.ısFreeDataGridViewCheckBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn});
            this.grdAboneTipi.DataSource = this.aboneTypeBindingSource;
            this.grdAboneTipi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAboneTipi.Location = new System.Drawing.Point(3, 18);
            this.grdAboneTipi.Name = "grdAboneTipi";
            this.grdAboneTipi.RowTemplate.Height = 24;
            this.grdAboneTipi.Size = new System.Drawing.Size(409, 156);
            this.grdAboneTipi.TabIndex = 0;
            this.grdAboneTipi.Click += new System.EventHandler(this.grdAboneType_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numStatus);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkIsFree);
            this.groupBox1.Controls.Add(this.numId);
            this.groupBox1.Controls.Add(this.numDergiCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numAmount);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "Abone Tipi";
            // 
            // txtDescription
            // 
            this.txtDescription.AccessibleDescription = "";
            this.txtDescription.AccessibleName = "Description";
            this.txtDescription.Location = new System.Drawing.Point(119, 142);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(191, 22);
            this.txtDescription.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Açıklama";
            // 
            // chkIsFree
            // 
            this.chkIsFree.AccessibleName = "IsFree";
            this.chkIsFree.AutoSize = true;
            this.chkIsFree.Location = new System.Drawing.Point(119, 176);
            this.chkIsFree.Name = "chkIsFree";
            this.chkIsFree.Size = new System.Drawing.Size(107, 21);
            this.chkIsFree.TabIndex = 17;
            this.chkIsFree.Text = "Ücretsiz Mi?";
            this.chkIsFree.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkIsFree.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dergi Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fiyat";
            // 
            // txtName
            // 
            this.txtName.AccessibleName = "Name";
            this.txtName.Location = new System.Drawing.Point(119, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Abone Tip Adı";
            // 
            // numStatus
            // 
            this.numStatus.AccessibleName = "Status";
            this.numStatus.AllowSpace = false;
            this.numStatus.Location = new System.Drawing.Point(376, 74);
            this.numStatus.Name = "numStatus";
            this.numStatus.Size = new System.Drawing.Size(21, 22);
            this.numStatus.TabIndex = 20;
            this.numStatus.Visible = false;
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
            // numDergiCount
            // 
            this.numDergiCount.AccessibleName = "DergiCount";
            this.numDergiCount.AllowSpace = false;
            this.numDergiCount.Location = new System.Drawing.Point(119, 105);
            this.numDergiCount.Name = "numDergiCount";
            this.numDergiCount.Size = new System.Drawing.Size(86, 22);
            this.numDergiCount.TabIndex = 3;
            // 
            // numAmount
            // 
            this.numAmount.AccessibleName = "Amount";
            this.numAmount.AllowSpace = false;
            this.numAmount.Location = new System.Drawing.Point(119, 69);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(86, 22);
            this.numAmount.TabIndex = 2;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Abone Tipi";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // dergiCountDataGridViewTextBoxColumn
            // 
            this.dergiCountDataGridViewTextBoxColumn.DataPropertyName = "DergiCount";
            this.dergiCountDataGridViewTextBoxColumn.HeaderText = "Dergi Sayısı";
            this.dergiCountDataGridViewTextBoxColumn.Name = "dergiCountDataGridViewTextBoxColumn";
            this.dergiCountDataGridViewTextBoxColumn.Width = 108;
            // 
            // ısFreeDataGridViewCheckBoxColumn
            // 
            this.ısFreeDataGridViewCheckBoxColumn.DataPropertyName = "IsFree";
            this.ısFreeDataGridViewCheckBoxColumn.HeaderText = "Ücretsiz Mi?";
            this.ısFreeDataGridViewCheckBoxColumn.Name = "ısFreeDataGridViewCheckBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.Visible = false;
            // 
            // AboneTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tool);
            this.Name = "AboneTypeForm";
            this.Tag = "";
            this.Text = "Abone Tipi";
            ((System.ComponentModel.ISupportInitialize)(this.aboneTypeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAboneTipi)).EndInit();
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
        private NumericTextBox numAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdAboneTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private NumericTextBox numDergiCount;
        private NumericTextBox numId;
        private System.Windows.Forms.CheckBox chkIsFree;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource aboneTypeBindingSource;
        private NumericTextBox numStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dergiCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısFreeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
    }
}