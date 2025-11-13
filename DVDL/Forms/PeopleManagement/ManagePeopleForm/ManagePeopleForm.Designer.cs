namespace DVDL
{
    partial class FrmManagePeople
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVManagePeople = new System.Windows.Forms.DataGridView();
            this.CMSManagePeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblFilterPeopleBy = new System.Windows.Forms.Label();
            this.CBFilterBy = new System.Windows.Forms.ComboBox();
            this.btnCloseManagePeopleForm = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RTBFilterBy = new System.Windows.Forms.RichTextBox();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThirdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalityCountryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagePeople)).BeginInit();
            this.CMSManagePeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(568, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // DGVManagePeople
            // 
            this.DGVManagePeople.AllowUserToAddRows = false;
            this.DGVManagePeople.AllowUserToDeleteRows = false;
            this.DGVManagePeople.AutoGenerateColumns = false;
            this.DGVManagePeople.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVManagePeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVManagePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManagePeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonID,
            this.FirstName,
            this.SecondName,
            this.ThirdName,
            this.LastName,
            this.Address,
            this.DateOfBirth,
            this.NationalNo,
            this.Phone,
            this.Email,
            this.Gender,
            this.ImagePath,
            this.NationalityCountryID});
            this.DGVManagePeople.ContextMenuStrip = this.CMSManagePeople;
            this.DGVManagePeople.DataSource = this.peopleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVManagePeople.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVManagePeople.Location = new System.Drawing.Point(12, 303);
            this.DGVManagePeople.Name = "DGVManagePeople";
            this.DGVManagePeople.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVManagePeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVManagePeople.RowHeadersWidth = 65;
            this.DGVManagePeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVManagePeople.Size = new System.Drawing.Size(1347, 359);
            this.DGVManagePeople.TabIndex = 2;
            this.DGVManagePeople.DoubleClick += new System.EventHandler(this.DGVManagePeople_DoubleClick);
            // 
            // CMSManagePeople
            // 
            this.CMSManagePeople.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.CMSManagePeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.CMSManagePeople.Name = "contextMenuStrip1";
            this.CMSManagePeople.Size = new System.Drawing.Size(187, 292);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::DVDL.Properties.Resources.PersonDetails_32;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(186, 46);
            this.showToolStripMenuItem.Text = "Show Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = global::DVDL.Properties.Resources.Add_Person_72;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(186, 46);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVDL.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(186, 46);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVDL.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(186, 46);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVDL.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(186, 46);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVDL.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(186, 46);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblRecordCount.Location = new System.Drawing.Point(12, 671);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(101, 25);
            this.lblRecordCount.TabIndex = 4;
            this.lblRecordCount.Text = "# Record: ";
            // 
            // lblFilterPeopleBy
            // 
            this.lblFilterPeopleBy.AutoSize = true;
            this.lblFilterPeopleBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFilterPeopleBy.Location = new System.Drawing.Point(12, 260);
            this.lblFilterPeopleBy.Name = "lblFilterPeopleBy";
            this.lblFilterPeopleBy.Size = new System.Drawing.Size(104, 26);
            this.lblFilterPeopleBy.TabIndex = 6;
            this.lblFilterPeopleBy.Text = "Filter By :";
            // 
            // CBFilterBy
            // 
            this.CBFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBFilterBy.FormattingEnabled = true;
            this.CBFilterBy.Location = new System.Drawing.Point(122, 264);
            this.CBFilterBy.Name = "CBFilterBy";
            this.CBFilterBy.Size = new System.Drawing.Size(177, 24);
            this.CBFilterBy.TabIndex = 7;
            this.CBFilterBy.SelectedIndexChanged += new System.EventHandler(this.CBFilterBy_SelectedIndexChanged);
            // 
            // btnCloseManagePeopleForm
            // 
            this.btnCloseManagePeopleForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseManagePeopleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCloseManagePeopleForm.Image = global::DVDL.Properties.Resources.Close_32;
            this.btnCloseManagePeopleForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseManagePeopleForm.Location = new System.Drawing.Point(1184, 668);
            this.btnCloseManagePeopleForm.Name = "btnCloseManagePeopleForm";
            this.btnCloseManagePeopleForm.Size = new System.Drawing.Size(175, 52);
            this.btnCloseManagePeopleForm.TabIndex = 3;
            this.btnCloseManagePeopleForm.Text = "Close";
            this.btnCloseManagePeopleForm.UseVisualStyleBackColor = true;
            this.btnCloseManagePeopleForm.Click += new System.EventHandler(this.btnCloseManagePeopleForm_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVDL.Properties.Resources.Add_Person_72;
            this.btnAddPerson.Location = new System.Drawing.Point(1230, 219);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(129, 78);
            this.btnAddPerson.TabIndex = 5;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVDL.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(598, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RTBFilterBy
            // 
            this.RTBFilterBy.Location = new System.Drawing.Point(305, 264);
            this.RTBFilterBy.Multiline = false;
            this.RTBFilterBy.Name = "RTBFilterBy";
            this.RTBFilterBy.Size = new System.Drawing.Size(238, 24);
            this.RTBFilterBy.TabIndex = 8;
            this.RTBFilterBy.Text = "";
            this.RTBFilterBy.TextChanged += new System.EventHandler(this.RTBFilterBy_TextChanged);
            this.RTBFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTBFilterBy_KeyPress);
            // 
            // PersonID
            // 
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.Frozen = true;
            this.PersonID.HeaderText = "PersonID";
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.Frozen = true;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // SecondName
            // 
            this.SecondName.DataPropertyName = "SecondName";
            this.SecondName.Frozen = true;
            this.SecondName.HeaderText = "SecondName";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            // 
            // ThirdName
            // 
            this.ThirdName.DataPropertyName = "ThirdName";
            this.ThirdName.Frozen = true;
            this.ThirdName.HeaderText = "ThirdName";
            this.ThirdName.Name = "ThirdName";
            this.ThirdName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.Frozen = true;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.Frozen = true;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.Frozen = true;
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // NationalNo
            // 
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "NationalNo";
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // ImagePath
            // 
            this.ImagePath.DataPropertyName = "ImagePath";
            this.ImagePath.HeaderText = "ImagePath";
            this.ImagePath.Name = "ImagePath";
            this.ImagePath.ReadOnly = true;
            this.ImagePath.Visible = false;
            // 
            // NationalityCountryID
            // 
            this.NationalityCountryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NationalityCountryID.DataPropertyName = "NationalityCountryID";
            this.NationalityCountryID.HeaderText = "NationalityCountryID";
            this.NationalityCountryID.Name = "NationalityCountryID";
            this.NationalityCountryID.ReadOnly = true;
            this.NationalityCountryID.Width = 179;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataSource = typeof(PeopleBusinessLayer.People);
            // 
            // FrmManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseManagePeopleForm;
            this.ClientSize = new System.Drawing.Size(1370, 771);
            this.Controls.Add(this.RTBFilterBy);
            this.Controls.Add(this.CBFilterBy);
            this.Controls.Add(this.lblFilterPeopleBy);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.btnCloseManagePeopleForm);
            this.Controls.Add(this.DGVManagePeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagePeople)).EndInit();
            this.CMSManagePeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVManagePeople;
        private System.Windows.Forms.Button btnCloseManagePeopleForm;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lblFilterPeopleBy;
        private System.Windows.Forms.ComboBox CBFilterBy;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.ContextMenuStrip CMSManagePeople;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.RichTextBox RTBFilterBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThirdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalityCountryID;
    }
}