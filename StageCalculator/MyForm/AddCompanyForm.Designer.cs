namespace StageCalculator.MyForm
{
    partial class AddCompanyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCompanyForm));
            this.CompanyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grBxEnterCompanyName = new System.Windows.Forms.GroupBox();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.txtBxCompanyName = new System.Windows.Forms.TextBox();
            this.dataGridViewOnAddCompanyForm = new System.Windows.Forms.DataGridView();
            this.contextMenuONAddForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyLayout.SuspendLayout();
            this.grBxEnterCompanyName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnAddCompanyForm)).BeginInit();
            this.contextMenuONAddForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompanyLayout
            // 
            this.CompanyLayout.ColumnCount = 1;
            this.CompanyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CompanyLayout.Controls.Add(this.grBxEnterCompanyName, 0, 1);
            this.CompanyLayout.Controls.Add(this.dataGridViewOnAddCompanyForm, 0, 0);
            this.CompanyLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyLayout.Location = new System.Drawing.Point(0, 0);
            this.CompanyLayout.Name = "CompanyLayout";
            this.CompanyLayout.RowCount = 2;
            this.CompanyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CompanyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.CompanyLayout.Size = new System.Drawing.Size(408, 261);
            this.CompanyLayout.TabIndex = 0;
            // 
            // grBxEnterCompanyName
            // 
            this.grBxEnterCompanyName.Controls.Add(this.btnSaveCompany);
            this.grBxEnterCompanyName.Controls.Add(this.txtBxCompanyName);
            this.grBxEnterCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxEnterCompanyName.Location = new System.Drawing.Point(3, 214);
            this.grBxEnterCompanyName.Name = "grBxEnterCompanyName";
            this.grBxEnterCompanyName.Size = new System.Drawing.Size(402, 44);
            this.grBxEnterCompanyName.TabIndex = 0;
            this.grBxEnterCompanyName.TabStop = false;
            this.grBxEnterCompanyName.Text = "Enter Company Name:";
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.Location = new System.Drawing.Point(320, 15);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(76, 23);
            this.btnSaveCompany.TabIndex = 1;
            this.btnSaveCompany.Text = "Save";
            this.btnSaveCompany.UseVisualStyleBackColor = true;
            this.btnSaveCompany.Click += new System.EventHandler(this.BtnSaveCompanyToDB_Click);
            // 
            // txtBxCompanyName
            // 
            this.txtBxCompanyName.Location = new System.Drawing.Point(13, 16);
            this.txtBxCompanyName.Name = "txtBxCompanyName";
            this.txtBxCompanyName.Size = new System.Drawing.Size(302, 20);
            this.txtBxCompanyName.TabIndex = 0;
            this.txtBxCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBxEnterCompanyName_KeyDown);
            // 
            // dataGridViewOnAddCompanyForm
            // 
            this.dataGridViewOnAddCompanyForm.AllowUserToAddRows = false;
            this.dataGridViewOnAddCompanyForm.AllowUserToDeleteRows = false;
            this.dataGridViewOnAddCompanyForm.AllowUserToResizeColumns = false;
            this.dataGridViewOnAddCompanyForm.AllowUserToResizeRows = false;
            this.dataGridViewOnAddCompanyForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOnAddCompanyForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnAddCompanyForm.ContextMenuStrip = this.contextMenuONAddForm;
            this.dataGridViewOnAddCompanyForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOnAddCompanyForm.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOnAddCompanyForm.Name = "dataGridViewOnAddCompanyForm";
            this.dataGridViewOnAddCompanyForm.ReadOnly = true;
            this.dataGridViewOnAddCompanyForm.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewOnAddCompanyForm.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOnAddCompanyForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOnAddCompanyForm.Size = new System.Drawing.Size(402, 205);
            this.dataGridViewOnAddCompanyForm.TabIndex = 1;
            // 
            // contextMenuONAddForm
            // 
            this.contextMenuONAddForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.contextMenuONAddForm.Name = "contextMenuONAddForm";
            this.contextMenuONAddForm.Size = new System.Drawing.Size(118, 70);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.BtnSelectONAddCompanyForm_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.BtnRemoveONAddCompanyForm_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.BtnUpdateONAddCompanyForm_Click);
            // 
            // AddCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.CompanyLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Company";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCompanyForm_Closing);
            this.Load += new System.EventHandler(this.AddCompanyForm_Load);
            this.CompanyLayout.ResumeLayout(false);
            this.grBxEnterCompanyName.ResumeLayout(false);
            this.grBxEnterCompanyName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnAddCompanyForm)).EndInit();
            this.contextMenuONAddForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CompanyLayout;
        private System.Windows.Forms.GroupBox grBxEnterCompanyName;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.TextBox txtBxCompanyName;
        private System.Windows.Forms.DataGridView dataGridViewOnAddCompanyForm;
        private System.Windows.Forms.ContextMenuStrip contextMenuONAddForm;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
    }
}