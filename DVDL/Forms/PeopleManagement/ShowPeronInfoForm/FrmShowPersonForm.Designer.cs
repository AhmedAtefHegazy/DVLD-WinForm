namespace DVDL.Forms.PeopleManagement
{
    partial class FrmShowPersonForm
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
            this.lblPersonDetails = new System.Windows.Forms.Label();
            this.cardPersonInformation1 = new DVDL.CardPersonInformation();
            this.btnCloseShowPersonForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonDetails
            // 
            this.lblPersonDetails.AutoSize = true;
            this.lblPersonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.lblPersonDetails.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPersonDetails.Location = new System.Drawing.Point(435, 70);
            this.lblPersonDetails.Name = "lblPersonDetails";
            this.lblPersonDetails.Size = new System.Drawing.Size(253, 39);
            this.lblPersonDetails.TabIndex = 2;
            this.lblPersonDetails.Text = "Person Details";
            // 
            // cardPersonInformation1
            // 
            this.cardPersonInformation1.Location = new System.Drawing.Point(32, 128);
            this.cardPersonInformation1.Name = "cardPersonInformation1";
            this.cardPersonInformation1.Size = new System.Drawing.Size(1128, 379);
            this.cardPersonInformation1.TabIndex = 0;
            // 
            // btnCloseShowPersonForm
            // 
            this.btnCloseShowPersonForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseShowPersonForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseShowPersonForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCloseShowPersonForm.Image = global::DVDL.Properties.Resources.Close_32;
            this.btnCloseShowPersonForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseShowPersonForm.Location = new System.Drawing.Point(985, 526);
            this.btnCloseShowPersonForm.Name = "btnCloseShowPersonForm";
            this.btnCloseShowPersonForm.Size = new System.Drawing.Size(175, 52);
            this.btnCloseShowPersonForm.TabIndex = 4;
            this.btnCloseShowPersonForm.Text = "Close";
            this.btnCloseShowPersonForm.UseVisualStyleBackColor = true;
            this.btnCloseShowPersonForm.Click += new System.EventHandler(this.btnCloseShowPersonForm_Click);
            // 
            // FrmShowPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseShowPersonForm;
            this.ClientSize = new System.Drawing.Size(1186, 590);
            this.Controls.Add(this.btnCloseShowPersonForm);
            this.Controls.Add(this.lblPersonDetails);
            this.Controls.Add(this.cardPersonInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CardPersonInformation cardPersonInformation1;
        private System.Windows.Forms.Label lblPersonDetails;
        private System.Windows.Forms.Button btnCloseShowPersonForm;
    }
}