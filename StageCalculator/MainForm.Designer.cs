namespace StageCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grBxMain = new System.Windows.Forms.GroupBox();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.cmBxCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.cmBxPerson = new System.Windows.Forms.ComboBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.dateGridViewMain = new System.Windows.Forms.DataGridView();
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTableLayout.SuspendLayout();
            this.MenuMain.SuspendLayout();
            this.grBxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGridViewMain)).BeginInit();
            this.contextMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.MenuMain, 0, 0);
            this.MainTableLayout.Controls.Add(this.grBxMain, 0, 1);
            this.MainTableLayout.Controls.Add(this.dateGridViewMain, 0, 2);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 3;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Size = new System.Drawing.Size(484, 428);
            this.MainTableLayout.TabIndex = 0;
            // 
            // MenuMain
            // 
            this.MenuMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raportToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(484, 25);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "MenuTitle";
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(54, 21);
            this.raportToolStripMenuItem.Text = "Raport";
            this.raportToolStripMenuItem.Click += new System.EventHandler(this.raportToolStripMenuItem_Click);
            // 
            // grBxMain
            // 
            this.grBxMain.Controls.Add(this.btnSaveToDB);
            this.grBxMain.Controls.Add(this.lblEnd);
            this.grBxMain.Controls.Add(this.lblBegin);
            this.grBxMain.Controls.Add(this.dateTimePickerEnd);
            this.grBxMain.Controls.Add(this.dateTimePickerBegin);
            this.grBxMain.Controls.Add(this.btnAddCompany);
            this.grBxMain.Controls.Add(this.cmBxCompany);
            this.grBxMain.Controls.Add(this.lblCompany);
            this.grBxMain.Controls.Add(this.btnAddPerson);
            this.grBxMain.Controls.Add(this.cmBxPerson);
            this.grBxMain.Controls.Add(this.lblPerson);
            this.grBxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBxMain.Location = new System.Drawing.Point(3, 28);
            this.grBxMain.Name = "grBxMain";
            this.grBxMain.Size = new System.Drawing.Size(478, 114);
            this.grBxMain.TabIndex = 1;
            this.grBxMain.TabStop = false;
            this.grBxMain.Text = "Service";
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Location = new System.Drawing.Point(16, 85);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(453, 23);
            this.btnSaveToDB.TabIndex = 10;
            this.btnSaveToDB.Text = "Save";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveOnMainForm_click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(274, 62);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(29, 13);
            this.lblEnd.TabIndex = 9;
            this.lblEnd.Text = "End:";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(7, 61);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(37, 13);
            this.lblBegin.TabIndex = 8;
            this.lblBegin.Text = "Begin:";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(305, 58);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(60, 58);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerBegin.TabIndex = 6;
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(433, 20);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(40, 23);
            this.btnAddCompany.TabIndex = 5;
            this.btnAddCompany.Text = "Add";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_btnClick);
            // 
            // cmBxCompany
            // 
            this.cmBxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmBxCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmBxCompany.FormattingEnabled = true;
            this.cmBxCompany.Location = new System.Drawing.Point(311, 21);
            this.cmBxCompany.Name = "cmBxCompany";
            this.cmBxCompany.Size = new System.Drawing.Size(121, 21);
            this.cmBxCompany.TabIndex = 4;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(254, 25);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(54, 13);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company:";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(213, 19);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(40, 23);
            this.btnAddPerson.TabIndex = 2;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPersonForm_Click);
            // 
            // cmBxPerson
            // 
            this.cmBxPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmBxPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmBxPerson.FormattingEnabled = true;
            this.cmBxPerson.Location = new System.Drawing.Point(48, 20);
            this.cmBxPerson.Name = "cmBxPerson";
            this.cmBxPerson.Size = new System.Drawing.Size(159, 21);
            this.cmBxPerson.TabIndex = 1;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(7, 24);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(43, 13);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "Person:";
            // 
            // dateGridViewMain
            // 
            this.dateGridViewMain.AllowUserToAddRows = false;
            this.dateGridViewMain.AllowUserToDeleteRows = false;
            this.dateGridViewMain.AllowUserToResizeColumns = false;
            this.dateGridViewMain.AllowUserToResizeRows = false;
            this.dateGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dateGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateGridViewMain.ContextMenuStrip = this.contextMenuMain;
            this.dateGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateGridViewMain.Location = new System.Drawing.Point(3, 148);
            this.dateGridViewMain.Name = "dateGridViewMain";
            this.dateGridViewMain.ReadOnly = true;
            this.dateGridViewMain.RowHeadersVisible = false;
            this.dateGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dateGridViewMain.Size = new System.Drawing.Size(478, 277);
            this.dateGridViewMain.TabIndex = 2;
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuMain.Name = "contextMenuStrip1";
            this.contextMenuMain.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteOnMainForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 428);
            this.Controls.Add(this.MainTableLayout);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stage - Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.grBxMain.ResumeLayout(false);
            this.grBxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGridViewMain)).EndInit();
            this.contextMenuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.GroupBox grBxMain;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.DataGridView dateGridViewMain;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button btnSaveToDB;
        public System.Windows.Forms.ComboBox cmBxCompany;
        public System.Windows.Forms.ComboBox cmBxPerson;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

