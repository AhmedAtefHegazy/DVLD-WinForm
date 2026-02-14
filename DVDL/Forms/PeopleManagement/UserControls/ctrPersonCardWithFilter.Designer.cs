namespace DVDL.Forms.PeopleManagement.UserControls
{
    partial class ctrPersonCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GBFilters = new System.Windows.Forms.GroupBox();
            this.BtnAddNewPerson = new System.Windows.Forms.Button();
            this.BtnSearchForPerson = new System.Windows.Forms.Button();
            this.TbFindBy = new System.Windows.Forms.RichTextBox();
            this.CbFindBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrPersonCardInformation1 = new DVDL.ctrPersonCardInformation();
            this.GBFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBFilters
            // 
            this.GBFilters.Controls.Add(this.BtnAddNewPerson);
            this.GBFilters.Controls.Add(this.BtnSearchForPerson);
            this.GBFilters.Controls.Add(this.TbFindBy);
            this.GBFilters.Controls.Add(this.CbFindBy);
            this.GBFilters.Controls.Add(this.label1);
            this.GBFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBFilters.Location = new System.Drawing.Point(3, 3);
            this.GBFilters.Name = "GBFilters";
            this.GBFilters.Size = new System.Drawing.Size(1131, 89);
            this.GBFilters.TabIndex = 1;
            this.GBFilters.TabStop = false;
            this.GBFilters.Text = "Filter";
            // 
            // BtnAddNewPerson
            // 
            this.BtnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewPerson.Image = global::DVDL.Properties.Resources.AddPerson_32;
            this.BtnAddNewPerson.Location = new System.Drawing.Point(836, 29);
            this.BtnAddNewPerson.Name = "BtnAddNewPerson";
            this.BtnAddNewPerson.Size = new System.Drawing.Size(60, 41);
            this.BtnAddNewPerson.TabIndex = 4;
            this.BtnAddNewPerson.UseVisualStyleBackColor = true;
            this.BtnAddNewPerson.Click += new System.EventHandler(this.BtnAddNewPerson_Click);
            // 
            // BtnSearchForPerson
            // 
            this.BtnSearchForPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchForPerson.Image = global::DVDL.Properties.Resources.SearchPerson;
            this.BtnSearchForPerson.Location = new System.Drawing.Point(770, 29);
            this.BtnSearchForPerson.Name = "BtnSearchForPerson";
            this.BtnSearchForPerson.Size = new System.Drawing.Size(60, 41);
            this.BtnSearchForPerson.TabIndex = 3;
            this.BtnSearchForPerson.UseVisualStyleBackColor = true;
            this.BtnSearchForPerson.Click += new System.EventHandler(this.BtnSearchForPerson_Click);
            // 
            // TbFindBy
            // 
            this.TbFindBy.Location = new System.Drawing.Point(433, 34);
            this.TbFindBy.Multiline = false;
            this.TbFindBy.Name = "TbFindBy";
            this.TbFindBy.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TbFindBy.Size = new System.Drawing.Size(309, 33);
            this.TbFindBy.TabIndex = 2;
            this.TbFindBy.Text = "";
            this.TbFindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFindBy_KeyPress);
            this.TbFindBy.Validating += new System.ComponentModel.CancelEventHandler(this.TbFindBy_Validating);
            // 
            // CbFindBy
            // 
            this.CbFindBy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFindBy.FormattingEnabled = true;
            this.CbFindBy.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.CbFindBy.Location = new System.Drawing.Point(128, 34);
            this.CbFindBy.Name = "CbFindBy";
            this.CbFindBy.Size = new System.Drawing.Size(299, 33);
            this.CbFindBy.TabIndex = 1;
            this.CbFindBy.SelectedIndexChanged += new System.EventHandler(this.CbFindBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrPersonCardInformation1
            // 
            this.ctrPersonCardInformation1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrPersonCardInformation1.Location = new System.Drawing.Point(0, 97);
            this.ctrPersonCardInformation1.Name = "ctrPersonCardInformation1";
            this.ctrPersonCardInformation1.Size = new System.Drawing.Size(1137, 379);
            this.ctrPersonCardInformation1.TabIndex = 0;
            // 
            // ctrPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBFilters);
            this.Controls.Add(this.ctrPersonCardInformation1);
            this.Name = "ctrPersonCardWithFilter";
            this.Size = new System.Drawing.Size(1137, 476);
            this.GBFilters.ResumeLayout(false);
            this.GBFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPersonCardInformation ctrPersonCardInformation1;
        private System.Windows.Forms.GroupBox GBFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbFindBy;
        private System.Windows.Forms.RichTextBox TbFindBy;
        private System.Windows.Forms.Button BtnSearchForPerson;
        private System.Windows.Forms.Button BtnAddNewPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
