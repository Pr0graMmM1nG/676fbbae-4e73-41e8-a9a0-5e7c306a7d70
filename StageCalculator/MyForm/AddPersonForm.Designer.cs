namespace StageCalculator.Repositories
{
    partial class AddPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonForm));
            this.tableLayoutAddPersonForm = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MainTabOnAddPersonForm = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveOnAddPersonForm = new System.Windows.Forms.Button();
            this.txtBxPersonLastName = new System.Windows.Forms.TextBox();
            this.txtBxPersonFamily = new System.Windows.Forms.TextBox();
            this.txtBxPersonName = new System.Windows.Forms.TextBox();
            this.lblPersonFamily = new System.Windows.Forms.Label();
            this.lblPersonLastName = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExpireDateBuletin = new System.Windows.Forms.Label();
            this.dateTimePickerExpireBuletin = new System.Windows.Forms.DateTimePicker();
            this.lblCreationDateBuletin = new System.Windows.Forms.Label();
            this.dateTimePickerCreationDateBuletin = new System.Windows.Forms.DateTimePicker();
            this.txtBxBuletinIDNO = new System.Windows.Forms.TextBox();
            this.lblBuletinIDNO = new System.Windows.Forms.Label();
            this.txtBxBuletinSeria = new System.Windows.Forms.TextBox();
            this.lblBuletinSeria = new System.Windows.Forms.Label();
            this.txtBxEyesColor = new System.Windows.Forms.TextBox();
            this.lblEyesColor = new System.Windows.Forms.Label();
            this.txtBxHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.cmBxSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cmBxBloodGroup = new System.Windows.Forms.ComboBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.txtBxBirthPlace = new System.Windows.Forms.TextBox();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewOnAddPersonForm = new System.Windows.Forms.DataGridView();
            this.contextMenuAddPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectToolStripOnAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuOnAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuOnAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutAddPersonForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MainTabOnAddPersonForm.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnAddPersonForm)).BeginInit();
            this.contextMenuAddPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutAddPersonForm
            // 
            this.tableLayoutAddPersonForm.ColumnCount = 1;
            this.tableLayoutAddPersonForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAddPersonForm.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutAddPersonForm.Controls.Add(this.dataGridViewOnAddPersonForm, 0, 0);
            this.tableLayoutAddPersonForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAddPersonForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutAddPersonForm.Name = "tableLayoutAddPersonForm";
            this.tableLayoutAddPersonForm.RowCount = 2;
            this.tableLayoutAddPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAddPersonForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutAddPersonForm.Size = new System.Drawing.Size(516, 494);
            this.tableLayoutAddPersonForm.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MainTabOnAddPersonForm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Person Data:";
            // 
            // MainTabOnAddPersonForm
            // 
            this.MainTabOnAddPersonForm.Controls.Add(this.tabPage1);
            this.MainTabOnAddPersonForm.Controls.Add(this.tabPage2);
            this.MainTabOnAddPersonForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabOnAddPersonForm.Location = new System.Drawing.Point(3, 16);
            this.MainTabOnAddPersonForm.Name = "MainTabOnAddPersonForm";
            this.MainTabOnAddPersonForm.SelectedIndex = 0;
            this.MainTabOnAddPersonForm.Size = new System.Drawing.Size(504, 175);
            this.MainTabOnAddPersonForm.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveOnAddPersonForm);
            this.tabPage1.Controls.Add(this.txtBxPersonLastName);
            this.tabPage1.Controls.Add(this.txtBxPersonFamily);
            this.tabPage1.Controls.Add(this.txtBxPersonName);
            this.tabPage1.Controls.Add(this.lblPersonFamily);
            this.tabPage1.Controls.Add(this.lblPersonLastName);
            this.tabPage1.Controls.Add(this.lblPersonName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveOnAddPersonForm
            // 
            this.btnSaveOnAddPersonForm.Location = new System.Drawing.Point(191, 110);
            this.btnSaveOnAddPersonForm.Name = "btnSaveOnAddPersonForm";
            this.btnSaveOnAddPersonForm.Size = new System.Drawing.Size(152, 23);
            this.btnSaveOnAddPersonForm.TabIndex = 6;
            this.btnSaveOnAddPersonForm.Text = "Save";
            this.btnSaveOnAddPersonForm.UseVisualStyleBackColor = true;
            this.btnSaveOnAddPersonForm.Click += new System.EventHandler(this.btnSaveONAddPersonForm_click);
            // 
            // txtBxPersonLastName
            // 
            this.txtBxPersonLastName.Location = new System.Drawing.Point(191, 74);
            this.txtBxPersonLastName.Name = "txtBxPersonLastName";
            this.txtBxPersonLastName.Size = new System.Drawing.Size(152, 20);
            this.txtBxPersonLastName.TabIndex = 5;
            // 
            // txtBxPersonFamily
            // 
            this.txtBxPersonFamily.Location = new System.Drawing.Point(191, 45);
            this.txtBxPersonFamily.Name = "txtBxPersonFamily";
            this.txtBxPersonFamily.Size = new System.Drawing.Size(152, 20);
            this.txtBxPersonFamily.TabIndex = 4;
            // 
            // txtBxPersonName
            // 
            this.txtBxPersonName.Location = new System.Drawing.Point(191, 16);
            this.txtBxPersonName.Name = "txtBxPersonName";
            this.txtBxPersonName.Size = new System.Drawing.Size(152, 20);
            this.txtBxPersonName.TabIndex = 3;
            // 
            // lblPersonFamily
            // 
            this.lblPersonFamily.AutoSize = true;
            this.lblPersonFamily.Location = new System.Drawing.Point(133, 49);
            this.lblPersonFamily.Name = "lblPersonFamily";
            this.lblPersonFamily.Size = new System.Drawing.Size(52, 13);
            this.lblPersonFamily.TabIndex = 2;
            this.lblPersonFamily.Text = "Prenume:";
            // 
            // lblPersonLastName
            // 
            this.lblPersonLastName.AutoSize = true;
            this.lblPersonLastName.Location = new System.Drawing.Point(126, 78);
            this.lblPersonLastName.Name = "lblPersonLastName";
            this.lblPersonLastName.Size = new System.Drawing.Size(59, 13);
            this.lblPersonLastName.TabIndex = 1;
            this.lblPersonLastName.Text = "Patronimic:";
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Location = new System.Drawing.Point(147, 20);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(38, 13);
            this.lblPersonName.TabIndex = 0;
            this.lblPersonName.Text = "Nume:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.txtBxEyesColor);
            this.tabPage2.Controls.Add(this.lblEyesColor);
            this.tabPage2.Controls.Add(this.txtBxHeight);
            this.tabPage2.Controls.Add(this.lblHeight);
            this.tabPage2.Controls.Add(this.cmBxSex);
            this.tabPage2.Controls.Add(this.lblSex);
            this.tabPage2.Controls.Add(this.cmBxBloodGroup);
            this.tabPage2.Controls.Add(this.lblBloodGroup);
            this.tabPage2.Controls.Add(this.txtBxBirthPlace);
            this.tabPage2.Controls.Add(this.lblBirthPlace);
            this.tabPage2.Controls.Add(this.lblBirthDate);
            this.tabPage2.Controls.Add(this.dateTimePickerBirthDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buletin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExpireDateBuletin);
            this.groupBox2.Controls.Add(this.dateTimePickerExpireBuletin);
            this.groupBox2.Controls.Add(this.lblCreationDateBuletin);
            this.groupBox2.Controls.Add(this.dateTimePickerCreationDateBuletin);
            this.groupBox2.Controls.Add(this.txtBxBuletinIDNO);
            this.groupBox2.Controls.Add(this.lblBuletinIDNO);
            this.groupBox2.Controls.Add(this.txtBxBuletinSeria);
            this.groupBox2.Controls.Add(this.lblBuletinSeria);
            this.groupBox2.Location = new System.Drawing.Point(218, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 103);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buletin:";
            // 
            // lblExpireDateBuletin
            // 
            this.lblExpireDateBuletin.AutoSize = true;
            this.lblExpireDateBuletin.Location = new System.Drawing.Point(104, 83);
            this.lblExpireDateBuletin.Name = "lblExpireDateBuletin";
            this.lblExpireDateBuletin.Size = new System.Drawing.Size(41, 13);
            this.lblExpireDateBuletin.TabIndex = 19;
            this.lblExpireDateBuletin.Text = "Valabil:";
            // 
            // dateTimePickerExpireBuletin
            // 
            this.dateTimePickerExpireBuletin.Location = new System.Drawing.Point(151, 80);
            this.dateTimePickerExpireBuletin.Name = "dateTimePickerExpireBuletin";
            this.dateTimePickerExpireBuletin.Size = new System.Drawing.Size(115, 20);
            this.dateTimePickerExpireBuletin.TabIndex = 18;
            // 
            // lblCreationDateBuletin
            // 
            this.lblCreationDateBuletin.AutoSize = true;
            this.lblCreationDateBuletin.Location = new System.Drawing.Point(104, 63);
            this.lblCreationDateBuletin.Name = "lblCreationDateBuletin";
            this.lblCreationDateBuletin.Size = new System.Drawing.Size(45, 13);
            this.lblCreationDateBuletin.TabIndex = 17;
            this.lblCreationDateBuletin.Text = "Eliberat:";
            // 
            // dateTimePickerCreationDateBuletin
            // 
            this.dateTimePickerCreationDateBuletin.Location = new System.Drawing.Point(151, 60);
            this.dateTimePickerCreationDateBuletin.Name = "dateTimePickerCreationDateBuletin";
            this.dateTimePickerCreationDateBuletin.Size = new System.Drawing.Size(115, 20);
            this.dateTimePickerCreationDateBuletin.TabIndex = 13;
            // 
            // txtBxBuletinIDNO
            // 
            this.txtBxBuletinIDNO.Location = new System.Drawing.Point(63, 34);
            this.txtBxBuletinIDNO.Name = "txtBxBuletinIDNO";
            this.txtBxBuletinIDNO.Size = new System.Drawing.Size(203, 20);
            this.txtBxBuletinIDNO.TabIndex = 16;
            // 
            // lblBuletinIDNO
            // 
            this.lblBuletinIDNO.AutoSize = true;
            this.lblBuletinIDNO.Location = new System.Drawing.Point(23, 37);
            this.lblBuletinIDNO.Name = "lblBuletinIDNO";
            this.lblBuletinIDNO.Size = new System.Drawing.Size(37, 13);
            this.lblBuletinIDNO.TabIndex = 15;
            this.lblBuletinIDNO.Text = "IDNO:";
            // 
            // txtBxBuletinSeria
            // 
            this.txtBxBuletinSeria.Location = new System.Drawing.Point(63, 11);
            this.txtBxBuletinSeria.Name = "txtBxBuletinSeria";
            this.txtBxBuletinSeria.Size = new System.Drawing.Size(113, 20);
            this.txtBxBuletinSeria.TabIndex = 14;
            // 
            // lblBuletinSeria
            // 
            this.lblBuletinSeria.AutoSize = true;
            this.lblBuletinSeria.Location = new System.Drawing.Point(26, 14);
            this.lblBuletinSeria.Name = "lblBuletinSeria";
            this.lblBuletinSeria.Size = new System.Drawing.Size(34, 13);
            this.lblBuletinSeria.TabIndex = 13;
            this.lblBuletinSeria.Text = "Seria:";
            // 
            // txtBxEyesColor
            // 
            this.txtBxEyesColor.Location = new System.Drawing.Point(391, 16);
            this.txtBxEyesColor.Name = "txtBxEyesColor";
            this.txtBxEyesColor.Size = new System.Drawing.Size(100, 20);
            this.txtBxEyesColor.TabIndex = 11;
            // 
            // lblEyesColor
            // 
            this.lblEyesColor.AutoSize = true;
            this.lblEyesColor.Location = new System.Drawing.Point(331, 20);
            this.lblEyesColor.Name = "lblEyesColor";
            this.lblEyesColor.Size = new System.Drawing.Size(59, 13);
            this.lblEyesColor.TabIndex = 10;
            this.lblEyesColor.Text = "Eyes color:";
            // 
            // txtBxHeight
            // 
            this.txtBxHeight.Location = new System.Drawing.Point(275, 17);
            this.txtBxHeight.Name = "txtBxHeight";
            this.txtBxHeight.Size = new System.Drawing.Size(50, 20);
            this.txtBxHeight.TabIndex = 9;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(215, 21);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(58, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height [m]:";
            // 
            // cmBxSex
            // 
            this.cmBxSex.FormattingEnabled = true;
            this.cmBxSex.Items.AddRange(new object[] {
            "Masculin",
            "Feminin",
            "Greu de spus :)"});
            this.cmBxSex.Location = new System.Drawing.Point(79, 112);
            this.cmBxSex.Name = "cmBxSex";
            this.cmBxSex.Size = new System.Drawing.Size(126, 21);
            this.cmBxSex.TabIndex = 7;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(44, 115);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Sex:";
            // 
            // cmBxBloodGroup
            // 
            this.cmBxBloodGroup.FormattingEnabled = true;
            this.cmBxBloodGroup.Items.AddRange(new object[] {
            "0(I) RH+",
            "0(I) RH-",
            "A(II) RH+",
            "A(II) RH-",
            "B(III) RH+",
            "B(III) RH-",
            "AB(IV) RH+",
            "AB(IV) RH-"});
            this.cmBxBloodGroup.Location = new System.Drawing.Point(79, 80);
            this.cmBxBloodGroup.Name = "cmBxBloodGroup";
            this.cmBxBloodGroup.Size = new System.Drawing.Size(126, 21);
            this.cmBxBloodGroup.TabIndex = 5;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(6, 84);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(66, 13);
            this.lblBloodGroup.TabIndex = 4;
            this.lblBloodGroup.Text = "BloodGroup:";
            // 
            // txtBxBirthPlace
            // 
            this.txtBxBirthPlace.Location = new System.Drawing.Point(79, 49);
            this.txtBxBirthPlace.Name = "txtBxBirthPlace";
            this.txtBxBirthPlace.Size = new System.Drawing.Size(126, 20);
            this.txtBxBirthPlace.TabIndex = 3;
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Location = new System.Drawing.Point(14, 52);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(58, 13);
            this.lblBirthPlace.TabIndex = 2;
            this.lblBirthPlace.Text = "BirthPlace:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(18, 21);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 1;
            this.lblBirthDate.Text = "BirthDate:";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(79, 17);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(126, 20);
            this.dateTimePickerBirthDate.TabIndex = 0;
            // 
            // dataGridViewOnAddPersonForm
            // 
            this.dataGridViewOnAddPersonForm.AllowUserToAddRows = false;
            this.dataGridViewOnAddPersonForm.AllowUserToDeleteRows = false;
            this.dataGridViewOnAddPersonForm.AllowUserToResizeColumns = false;
            this.dataGridViewOnAddPersonForm.AllowUserToResizeRows = false;
            this.dataGridViewOnAddPersonForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOnAddPersonForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnAddPersonForm.ContextMenuStrip = this.contextMenuAddPerson;
            this.dataGridViewOnAddPersonForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOnAddPersonForm.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOnAddPersonForm.Name = "dataGridViewOnAddPersonForm";
            this.dataGridViewOnAddPersonForm.ReadOnly = true;
            this.dataGridViewOnAddPersonForm.RowHeadersVisible = false;
            this.dataGridViewOnAddPersonForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOnAddPersonForm.Size = new System.Drawing.Size(510, 288);
            this.dataGridViewOnAddPersonForm.TabIndex = 1;
            // 
            // contextMenuAddPerson
            // 
            this.contextMenuAddPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripOnAddPerson,
            this.deleteToolStripMenuOnAddPerson,
            this.updateToolStripMenuOnAddPerson});
            this.contextMenuAddPerson.Name = "contextMenuAddPerson";
            this.contextMenuAddPerson.Size = new System.Drawing.Size(118, 70);
            // 
            // selectToolStripOnAddPerson
            // 
            this.selectToolStripOnAddPerson.Name = "selectToolStripOnAddPerson";
            this.selectToolStripOnAddPerson.Size = new System.Drawing.Size(117, 22);
            this.selectToolStripOnAddPerson.Text = "Select";
            this.selectToolStripOnAddPerson.Click += new System.EventHandler(this.BtnSelectOnAddPersonForm_click);
            // 
            // deleteToolStripMenuOnAddPerson
            // 
            this.deleteToolStripMenuOnAddPerson.Name = "deleteToolStripMenuOnAddPerson";
            this.deleteToolStripMenuOnAddPerson.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuOnAddPerson.Text = "Remove";
            this.deleteToolStripMenuOnAddPerson.Click += new System.EventHandler(this.BtnRemoveOnAddPersonForm_click);
            // 
            // updateToolStripMenuOnAddPerson
            // 
            this.updateToolStripMenuOnAddPerson.Name = "updateToolStripMenuOnAddPerson";
            this.updateToolStripMenuOnAddPerson.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuOnAddPerson.Text = "Update";
            this.updateToolStripMenuOnAddPerson.Click += new System.EventHandler(this.BtnUpdateOnAddPersonForm_click);
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 494);
            this.Controls.Add(this.tableLayoutAddPersonForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Person";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPersonForm_cClosing);
            this.Load += new System.EventHandler(this.AddPersonForm_Load);
            this.tableLayoutAddPersonForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.MainTabOnAddPersonForm.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnAddPersonForm)).EndInit();
            this.contextMenuAddPerson.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutAddPersonForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewOnAddPersonForm;
        private System.Windows.Forms.TabControl MainTabOnAddPersonForm;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSaveOnAddPersonForm;
        private System.Windows.Forms.Label lblPersonFamily;
        private System.Windows.Forms.Label lblPersonLastName;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.TextBox txtBxBirthPlace;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.ComboBox cmBxSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmBxBloodGroup;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.TextBox txtBxEyesColor;
        private System.Windows.Forms.Label lblEyesColor;
        private System.Windows.Forms.TextBox txtBxHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBuletinIDNO;
        private System.Windows.Forms.TextBox txtBxBuletinSeria;
        private System.Windows.Forms.Label lblBuletinSeria;
        private System.Windows.Forms.Label lblExpireDateBuletin;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpireBuletin;
        private System.Windows.Forms.Label lblCreationDateBuletin;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreationDateBuletin;
        private System.Windows.Forms.ContextMenuStrip contextMenuAddPerson;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripOnAddPerson;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuOnAddPerson;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuOnAddPerson;
        private System.Windows.Forms.TextBox txtBxPersonLastName;
        private System.Windows.Forms.TextBox txtBxPersonFamily;
        private System.Windows.Forms.TextBox txtBxPersonName;
        private System.Windows.Forms.TextBox txtBxBuletinIDNO;
    }
}