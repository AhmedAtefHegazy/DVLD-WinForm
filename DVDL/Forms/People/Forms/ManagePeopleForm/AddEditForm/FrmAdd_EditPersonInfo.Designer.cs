using System;
using System.Data;
using System.Windows.Forms;
using CountriesBusinessLayer;
using DVDL.Properties;

namespace DVDL.Forms.PeopleManagement
{
    partial class FrmAdd_EditPersonInfo
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
        private void InitializeComponent(int PersonID)
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CardPersonInfo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.DTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.RTBAddress = new System.Windows.Forms.RichTextBox();
            this.RTBPhone = new System.Windows.Forms.RichTextBox();
            this.RTBEmail = new System.Windows.Forms.RichTextBox();
            this.RTBNationalNo = new System.Windows.Forms.RichTextBox();
            this.RTBNameFirst = new System.Windows.Forms.RichTextBox();
            this.RTBNameSecond = new System.Windows.Forms.RichTextBox();
            this.RTBNameThird = new System.Windows.Forms.RichTextBox();
            this.RTBNameLast = new System.Windows.Forms.RichTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBPersonImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.LBLFormStatus = new System.Windows.Forms.Label();
            this.llblSetImage = new System.Windows.Forms.LinkLabel();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.LlblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.CardPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Country :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(592, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date Of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "National No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // CardPersonInfo
            // 
            this.CardPersonInfo.Controls.Add(this.LlblRemoveImage);
            this.CardPersonInfo.Controls.Add(this.llblSetImage);
            this.CardPersonInfo.Controls.Add(this.label13);
            this.CardPersonInfo.Controls.Add(this.label12);
            this.CardPersonInfo.Controls.Add(this.LlblRemoveImage);
            this.CardPersonInfo.Controls.Add(this.label11);
            this.CardPersonInfo.Controls.Add(this.Label10);
            this.CardPersonInfo.Controls.Add(this.pictureBox10);
            this.CardPersonInfo.Controls.Add(this.RBFemale);
            this.CardPersonInfo.Controls.Add(this.RBMale);
            this.CardPersonInfo.Controls.Add(this.BtnSave);
            this.CardPersonInfo.Controls.Add(this.btnClose);
            this.CardPersonInfo.Controls.Add(this.CBCountry);
            this.CardPersonInfo.Controls.Add(this.DTPDateOfBirth);
            this.CardPersonInfo.Controls.Add(this.RTBAddress);
            this.CardPersonInfo.Controls.Add(this.RTBPhone);
            this.CardPersonInfo.Controls.Add(this.RTBEmail);
            this.CardPersonInfo.Controls.Add(this.RTBNationalNo);
            this.CardPersonInfo.Controls.Add(this.RTBNameFirst);
            this.CardPersonInfo.Controls.Add(this.RTBNameSecond);
            this.CardPersonInfo.Controls.Add(this.RTBNameThird);
            this.CardPersonInfo.Controls.Add(this.RTBNameLast);
            this.CardPersonInfo.Controls.Add(this.pictureBox8);
            this.CardPersonInfo.Controls.Add(this.pictureBox7);
            this.CardPersonInfo.Controls.Add(this.pictureBox6);
            this.CardPersonInfo.Controls.Add(this.pictureBox5);
            this.CardPersonInfo.Controls.Add(this.pictureBox4);
            this.CardPersonInfo.Controls.Add(this.pictureBox3);
            this.CardPersonInfo.Controls.Add(this.pictureBox2);
            this.CardPersonInfo.Controls.Add(this.pictureBox1);
            this.CardPersonInfo.Controls.Add(this.label9);
            this.CardPersonInfo.Controls.Add(this.label8);
            this.CardPersonInfo.Controls.Add(this.label7);
            this.CardPersonInfo.Controls.Add(this.label6);
            this.CardPersonInfo.Controls.Add(this.label5);
            this.CardPersonInfo.Controls.Add(this.label4);
            this.CardPersonInfo.Controls.Add(this.label3);
            this.CardPersonInfo.Controls.Add(this.label2);
            this.CardPersonInfo.Controls.Add(this.PBPersonImage);
            this.CardPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CardPersonInfo.Location = new System.Drawing.Point(29, 99);
            this.CardPersonInfo.Name = "CardPersonInfo";
            this.CardPersonInfo.Size = new System.Drawing.Size(1254, 457);
            this.CardPersonInfo.TabIndex = 1;
            this.CardPersonInfo.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1084, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Last";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(817, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Third";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Second";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(301, 26);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(54, 25);
            this.Label10.TabIndex = 25;
            this.Label10.Text = "First ";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVDL.Properties.Resources.Woman_32;
            this.pictureBox10.Location = new System.Drawing.Point(306, 160);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.Location = new System.Drawing.Point(360, 161);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(95, 29);
            this.RBFemale.TabIndex = 23;
            this.RBFemale.TabStop = true;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = true;
            this.RBFemale.CheckedChanged += new System.EventHandler(this.RBFemale_CheckedChanged);
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.Checked = true;
            this.RBMale.Location = new System.Drawing.Point(218, 161);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(73, 29);
            this.RBMale.TabIndex = 7;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = true;
            this.RBMale.CheckedChanged += new System.EventHandler(this.RBMale_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnSave.Image = global::DVDL.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(776, 388);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(175, 52);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.Image = global::DVDL.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(586, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 52);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // CBCountry
            // 
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(730, 209);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(221, 33);
            this.CBCountry.TabIndex = 10;
            // 
            // DTPDateOfBirth
            // 
            this.DTPDateOfBirth.Location = new System.Drawing.Point(730, 112);
            this.DTPDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTPDateOfBirth.Name = "DTPDateOfBirth";
            this.DTPDateOfBirth.Size = new System.Drawing.Size(221, 30);
            this.DTPDateOfBirth.TabIndex = 6;
            this.DTPDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.DTPDateOfBirth_Validating);
            // 
            // RTBAddress
            // 
            this.RTBAddress.Location = new System.Drawing.Point(218, 257);
            this.RTBAddress.Name = "RTBAddress";
            this.RTBAddress.Size = new System.Drawing.Size(733, 115);
            this.RTBAddress.TabIndex = 11;
            this.RTBAddress.Text = "";
            this.RTBAddress.Validating += new System.ComponentModel.CancelEventHandler(this.RTBAddress_Validating);
            // 
            // RTBPhone
            // 
            this.RTBPhone.Location = new System.Drawing.Point(730, 160);
            this.RTBPhone.Multiline = false;
            this.RTBPhone.Name = "RTBPhone";
            this.RTBPhone.Size = new System.Drawing.Size(221, 25);
            this.RTBPhone.TabIndex = 8;
            this.RTBPhone.Text = "";
            this.RTBPhone.MaxLength= 11;
            this.RTBPhone.Validating += new System.ComponentModel.CancelEventHandler(this.RTBPhone_Validating);
            // 
            // RTBEmail
            // 
            this.RTBEmail.Location = new System.Drawing.Point(218, 209);
            this.RTBEmail.Multiline = false;
            this.RTBEmail.Name = "RTBEmail";
            this.RTBEmail.Size = new System.Drawing.Size(221, 25);
            this.RTBEmail.TabIndex = 9;
            this.RTBEmail.Text = "";
            this.RTBEmail.Validating += new System.ComponentModel.CancelEventHandler(this.RTBEmail_Validating);
            // 
            // RTBNationalNo
            // 
            this.RTBNationalNo.Location = new System.Drawing.Point(218, 112);
            this.RTBNationalNo.Multiline = false;
            this.RTBNationalNo.Name = "RTBNationalNo";
            this.RTBNationalNo.Size = new System.Drawing.Size(221, 25);
            this.RTBNationalNo.TabIndex = 5;
            this.RTBNationalNo.Text = "";
            this.RTBNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNationalNo_Validating);
            // 
            // RTBNameFirst
            // 
            this.RTBNameFirst.Location = new System.Drawing.Point(218, 62);
            this.RTBNameFirst.Multiline = false;
            this.RTBNameFirst.Name = "RTBNameFirst";
            this.RTBNameFirst.Size = new System.Drawing.Size(221, 25);
            this.RTBNameFirst.TabIndex = 1;
            this.RTBNameFirst.Text = "";
            this.RTBNameFirst.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameFirst_Validating);
            // 
            // RTBNameSecond
            // 
            this.RTBNameSecond.Location = new System.Drawing.Point(475, 59);
            this.RTBNameSecond.Multiline = false;
            this.RTBNameSecond.Name = "RTBNameSecond";
            this.RTBNameSecond.Size = new System.Drawing.Size(221, 25);
            this.RTBNameSecond.TabIndex = 2;
            this.RTBNameSecond.Text = "";
            this.RTBNameSecond.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameSecond_Validating);
            // 
            // RTBNameThird
            // 
            this.RTBNameThird.Location = new System.Drawing.Point(730, 59);
            this.RTBNameThird.Multiline = false;
            this.RTBNameThird.Name = "RTBNameThird";
            this.RTBNameThird.Size = new System.Drawing.Size(221, 25);
            this.RTBNameThird.TabIndex = 3;
            this.RTBNameThird.Text = "";
            this.RTBNameThird.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameThird_Validating);
            // 
            // RTBNameLast
            // 
            this.RTBNameLast.Location = new System.Drawing.Point(988, 59);
            this.RTBNameLast.Multiline = false;
            this.RTBNameLast.Name = "RTBNameLast";
            this.RTBNameLast.Size = new System.Drawing.Size(221, 25);
            this.RTBNameLast.TabIndex = 4;
            this.RTBNameLast.Text = "";
            this.RTBNameLast.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameLast_Validating);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVDL.Properties.Resources.Phone_32;
            this.pictureBox8.Location = new System.Drawing.Point(688, 160);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 33);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVDL.Properties.Resources.Country_32;
            this.pictureBox7.Location = new System.Drawing.Point(688, 209);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVDL.Properties.Resources.Calendar_32;
            this.pictureBox6.Location = new System.Drawing.Point(688, 111);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVDL.Properties.Resources.Address_321;
            this.pictureBox5.Location = new System.Drawing.Point(164, 257);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVDL.Properties.Resources.Email_321;
            this.pictureBox4.Location = new System.Drawing.Point(163, 209);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVDL.Properties.Resources.Man_32;
            this.pictureBox3.Location = new System.Drawing.Point(163, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDL.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(163, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVDL.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(163, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PBPersonImage
            // 
            this.PBPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBPersonImage.Image = global::DVDL.Properties.Resources.Male_512;
            this.PBPersonImage.ImageLocation="";
            this.PBPersonImage.Location = new System.Drawing.Point(988, 111);
            this.PBPersonImage.Name = "PBPersonImage";
            this.PBPersonImage.Size = new System.Drawing.Size(221, 217);
            this.PBPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPersonImage.TabIndex = 0;
            this.PBPersonImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Person ID :";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVDL.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(193, 71);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 33);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.Location = new System.Drawing.Point(243, 75);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(59, 20);
            this.lblPersonId.TabIndex = 13;
            this.lblPersonId.Text = "[????]";
            // 
            // LBLFormStatus
            // 
            this.LBLFormStatus.AutoSize = true;
            this.LBLFormStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFormStatus.ForeColor = System.Drawing.Color.Brown;
            this.LBLFormStatus.Location = new System.Drawing.Point(540, 53);
            this.LBLFormStatus.Name = "LBLFormStatus";
            this.LBLFormStatus.Size = new System.Drawing.Size(281, 42);
            this.LBLFormStatus.TabIndex = 26;
            this.LBLFormStatus.Text = "Update Person";
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // llblSetImage
            // 
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.Location = new System.Drawing.Point(1049, 347);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(101, 25);
            this.llblSetImage.TabIndex = 26;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // LlblRemoveImage
            // 
            this.LlblRemoveImage.AutoSize = true;
            this.LlblRemoveImage.Location = new System.Drawing.Point(1035, 388);
            this.LlblRemoveImage.Name = "LlblRemoveImage";
            this.LlblRemoveImage.Size = new System.Drawing.Size(143, 25);
            this.LlblRemoveImage.TabIndex = 27;
            this.LlblRemoveImage.TabStop = true;
            this.LlblRemoveImage.Text = "Remove Image";
            this.LlblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblRemoveImage_LinkClicked);
            // 
            // FrmAdd_EditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1313, 579);
            this.Controls.Add(this.LBLFormStatus);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdd_EditPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Person Info.";
            this.CardPersonInfo.ResumeLayout(false);
            this.CardPersonInfo.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            //
            //Initiate the form accourding to the PersonID 
            //
            LBLFormStatus.Text = (PersonID != -1) ? "Update Person" : "Add New Person";
            lblPersonId.Text = (PersonID != -1) ? PersonID.ToString() : "N/A";
            if (RBFemale.Checked == true)
                PBPersonImage.Image = Resources.Female_512;
            else
                PBPersonImage.Image = Resources.Male_512;
            //
            //Min Age that user able to enter is 18 years
            //
            this.DTPDateOfBirth.MaxDate = DateTime.Now - new TimeSpan(157788, 0, 0);
        }
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CardPersonInfo = new System.Windows.Forms.GroupBox();
            this.llblSetImage = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.BtnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.DTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.RTBAddress = new System.Windows.Forms.RichTextBox();
            this.RTBPhone = new System.Windows.Forms.RichTextBox();
            this.RTBEmail = new System.Windows.Forms.RichTextBox();
            this.RTBNationalNo = new System.Windows.Forms.RichTextBox();
            this.RTBNameFirst = new System.Windows.Forms.RichTextBox();
            this.RTBNameSecond = new System.Windows.Forms.RichTextBox();
            this.RTBNameThird = new System.Windows.Forms.RichTextBox();
            this.RTBNameLast = new System.Windows.Forms.RichTextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBPersonImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.LBLFormStatus = new System.Windows.Forms.Label();
            this.EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.LlblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.CardPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(578, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Country :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(592, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Phone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date Of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "National No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // CardPersonInfo
            // 
            this.CardPersonInfo.Controls.Add(this.LlblRemoveImage);
            this.CardPersonInfo.Controls.Add(this.llblSetImage);
            this.CardPersonInfo.Controls.Add(this.label13);
            this.CardPersonInfo.Controls.Add(this.label12);
            this.CardPersonInfo.Controls.Add(this.label11);
            this.CardPersonInfo.Controls.Add(this.Label10);
            this.CardPersonInfo.Controls.Add(this.pictureBox10);
            this.CardPersonInfo.Controls.Add(this.RBFemale);
            this.CardPersonInfo.Controls.Add(this.RBMale);
            this.CardPersonInfo.Controls.Add(this.BtnSave);
            this.CardPersonInfo.Controls.Add(this.btnClose);
            this.CardPersonInfo.Controls.Add(this.CBCountry);
            this.CardPersonInfo.Controls.Add(this.DTPDateOfBirth);
            this.CardPersonInfo.Controls.Add(this.RTBAddress);
            this.CardPersonInfo.Controls.Add(this.RTBPhone);
            this.CardPersonInfo.Controls.Add(this.RTBEmail);
            this.CardPersonInfo.Controls.Add(this.RTBNationalNo);
            this.CardPersonInfo.Controls.Add(this.RTBNameFirst);
            this.CardPersonInfo.Controls.Add(this.RTBNameSecond);
            this.CardPersonInfo.Controls.Add(this.RTBNameThird);
            this.CardPersonInfo.Controls.Add(this.RTBNameLast);
            this.CardPersonInfo.Controls.Add(this.pictureBox8);
            this.CardPersonInfo.Controls.Add(this.pictureBox7);
            this.CardPersonInfo.Controls.Add(this.pictureBox6);
            this.CardPersonInfo.Controls.Add(this.pictureBox5);
            this.CardPersonInfo.Controls.Add(this.pictureBox4);
            this.CardPersonInfo.Controls.Add(this.pictureBox3);
            this.CardPersonInfo.Controls.Add(this.pictureBox2);
            this.CardPersonInfo.Controls.Add(this.pictureBox1);
            this.CardPersonInfo.Controls.Add(this.label9);
            this.CardPersonInfo.Controls.Add(this.label8);
            this.CardPersonInfo.Controls.Add(this.label7);
            this.CardPersonInfo.Controls.Add(this.label6);
            this.CardPersonInfo.Controls.Add(this.label5);
            this.CardPersonInfo.Controls.Add(this.label4);
            this.CardPersonInfo.Controls.Add(this.label3);
            this.CardPersonInfo.Controls.Add(this.label2);
            this.CardPersonInfo.Controls.Add(this.PBPersonImage);
            this.CardPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CardPersonInfo.Location = new System.Drawing.Point(29, 99);
            this.CardPersonInfo.Name = "CardPersonInfo";
            this.CardPersonInfo.Size = new System.Drawing.Size(1254, 457);
            this.CardPersonInfo.TabIndex = 1;
            this.CardPersonInfo.TabStop = false;
            // 
            // llblSetImage
            // 
            this.llblSetImage.AutoSize = true;
            this.llblSetImage.Location = new System.Drawing.Point(1049, 347);
            this.llblSetImage.Name = "llblSetImage";
            this.llblSetImage.Size = new System.Drawing.Size(101, 25);
            this.llblSetImage.TabIndex = 26;
            this.llblSetImage.TabStop = true;
            this.llblSetImage.Text = "Set Image";
            this.llblSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSetImage_LinkClicked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1084, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Last";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(817, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Third";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Second";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(301, 26);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(54, 25);
            this.Label10.TabIndex = 25;
            this.Label10.Text = "First ";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::DVDL.Properties.Resources.Woman_32;
            this.pictureBox10.Location = new System.Drawing.Point(306, 160);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 33);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.Location = new System.Drawing.Point(360, 161);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(95, 29);
            this.RBFemale.TabIndex = 23;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = true;
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.Checked = true;
            this.RBMale.Location = new System.Drawing.Point(218, 161);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(73, 29);
            this.RBMale.TabIndex = 7;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnSave.Image = global::DVDL.Properties.Resources.Save_32;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(776, 388);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(175, 52);
            this.BtnSave.TabIndex = 13;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.Image = global::DVDL.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(586, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 52);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // CBCountry
            // 
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(730, 209);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(221, 33);
            this.CBCountry.TabIndex = 10;
            // 
            // DTPDateOfBirth
            // 
            this.DTPDateOfBirth.Location = new System.Drawing.Point(730, 112);
            this.DTPDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DTPDateOfBirth.Name = "DTPDateOfBirth";
            this.DTPDateOfBirth.Size = new System.Drawing.Size(221, 30);
            this.DTPDateOfBirth.TabIndex = 6;
            this.DTPDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.DTPDateOfBirth_Validating);
            // 
            // RTBAddress
            // 
            this.RTBAddress.Location = new System.Drawing.Point(218, 257);
            this.RTBAddress.Name = "RTBAddress";
            this.RTBAddress.Size = new System.Drawing.Size(733, 115);
            this.RTBAddress.TabIndex = 11;
            this.RTBAddress.Text = "";
            this.RTBAddress.Validating += new System.ComponentModel.CancelEventHandler(this.RTBAddress_Validating);
            // 
            // RTBPhone
            // 
            this.RTBPhone.Location = new System.Drawing.Point(730, 160);
            this.RTBPhone.MaxLength = 11;
            this.RTBPhone.Multiline = false;
            this.RTBPhone.Name = "RTBPhone";
            this.RTBPhone.Size = new System.Drawing.Size(221, 25);
            this.RTBPhone.TabIndex = 8;
            this.RTBPhone.Text = "";
            this.RTBPhone.Validating += new System.ComponentModel.CancelEventHandler(this.RTBPhone_Validating);
            // 
            // RTBEmail
            // 
            this.RTBEmail.Location = new System.Drawing.Point(218, 209);
            this.RTBEmail.Multiline = false;
            this.RTBEmail.Name = "RTBEmail";
            this.RTBEmail.Size = new System.Drawing.Size(221, 25);
            this.RTBEmail.TabIndex = 9;
            this.RTBEmail.Text = "";
            this.RTBEmail.Validating += new System.ComponentModel.CancelEventHandler(this.RTBEmail_Validating);
            // 
            // RTBNationalNo
            // 
            this.RTBNationalNo.Location = new System.Drawing.Point(218, 112);
            this.RTBNationalNo.Multiline = false;
            this.RTBNationalNo.Name = "RTBNationalNo";
            this.RTBNationalNo.Size = new System.Drawing.Size(221, 25);
            this.RTBNationalNo.TabIndex = 5;
            this.RTBNationalNo.Text = "";
            this.RTBNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNationalNo_Validating);
            // 
            // RTBNameFirst
            // 
            this.RTBNameFirst.Location = new System.Drawing.Point(218, 62);
            this.RTBNameFirst.Multiline = false;
            this.RTBNameFirst.Name = "RTBNameFirst";
            this.RTBNameFirst.Size = new System.Drawing.Size(221, 25);
            this.RTBNameFirst.TabIndex = 1;
            this.RTBNameFirst.Text = "";
            this.RTBNameFirst.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameFirst_Validating);
            // 
            // RTBNameSecond
            // 
            this.RTBNameSecond.Location = new System.Drawing.Point(475, 59);
            this.RTBNameSecond.Multiline = false;
            this.RTBNameSecond.Name = "RTBNameSecond";
            this.RTBNameSecond.Size = new System.Drawing.Size(221, 25);
            this.RTBNameSecond.TabIndex = 2;
            this.RTBNameSecond.Text = "";
            this.RTBNameSecond.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameSecond_Validating);
            // 
            // RTBNameThird
            // 
            this.RTBNameThird.Location = new System.Drawing.Point(730, 59);
            this.RTBNameThird.Multiline = false;
            this.RTBNameThird.Name = "RTBNameThird";
            this.RTBNameThird.Size = new System.Drawing.Size(221, 25);
            this.RTBNameThird.TabIndex = 3;
            this.RTBNameThird.Text = "";
            this.RTBNameThird.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameThird_Validating);
            // 
            // RTBNameLast
            // 
            this.RTBNameLast.Location = new System.Drawing.Point(988, 59);
            this.RTBNameLast.Multiline = false;
            this.RTBNameLast.Name = "RTBNameLast";
            this.RTBNameLast.Size = new System.Drawing.Size(221, 25);
            this.RTBNameLast.TabIndex = 4;
            this.RTBNameLast.Text = "";
            this.RTBNameLast.Validating += new System.ComponentModel.CancelEventHandler(this.RTBNameLast_Validating);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVDL.Properties.Resources.Phone_32;
            this.pictureBox8.Location = new System.Drawing.Point(688, 160);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 33);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVDL.Properties.Resources.Country_32;
            this.pictureBox7.Location = new System.Drawing.Point(688, 209);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVDL.Properties.Resources.Calendar_32;
            this.pictureBox6.Location = new System.Drawing.Point(688, 111);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVDL.Properties.Resources.Address_321;
            this.pictureBox5.Location = new System.Drawing.Point(164, 257);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVDL.Properties.Resources.Email_321;
            this.pictureBox4.Location = new System.Drawing.Point(163, 209);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVDL.Properties.Resources.Man_32;
            this.pictureBox3.Location = new System.Drawing.Point(163, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDL.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(163, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVDL.Properties.Resources.Person_32;
            this.pictureBox1.Location = new System.Drawing.Point(163, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PBPersonImage
            // 
            this.PBPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBPersonImage.Image = global::DVDL.Properties.Resources.Male_512;
            this.PBPersonImage.Location = new System.Drawing.Point(988, 111);
            this.PBPersonImage.Name = "PBPersonImage";
            this.PBPersonImage.Size = new System.Drawing.Size(221, 217);
            this.PBPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBPersonImage.TabIndex = 0;
            this.PBPersonImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Person ID :";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVDL.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(193, 71);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 33);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 16;
            this.pictureBox9.TabStop = false;
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.Location = new System.Drawing.Point(243, 75);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(59, 20);
            this.lblPersonId.TabIndex = 13;
            this.lblPersonId.Text = "[????]";
            // 
            // LBLFormStatus
            // 
            this.LBLFormStatus.AutoSize = true;
            this.LBLFormStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFormStatus.ForeColor = System.Drawing.Color.Brown;
            this.LBLFormStatus.Location = new System.Drawing.Point(540, 53);
            this.LBLFormStatus.Name = "LBLFormStatus";
            this.LBLFormStatus.Size = new System.Drawing.Size(281, 42);
            this.LBLFormStatus.TabIndex = 26;
            this.LBLFormStatus.Text = "Update Person";
            // 
            // EP
            // 
            this.EP.ContainerControl = this;
            // 
            // LlblRemoveImage
            // 
            this.LlblRemoveImage.AutoSize = true;
            this.LlblRemoveImage.Location = new System.Drawing.Point(1020, 388);
            this.LlblRemoveImage.Name = "LlblRemoveImage";
            this.LlblRemoveImage.Size = new System.Drawing.Size(143, 25);
            this.LlblRemoveImage.TabIndex = 27;
            this.LlblRemoveImage.TabStop = true;
            this.LlblRemoveImage.Text = "Remove Image";
            // 
            // FrmAdd_EditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1313, 579);
            this.Controls.Add(this.LBLFormStatus);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lblPersonId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardPersonInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdd_EditPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Person Info.";
            this.CardPersonInfo.ResumeLayout(false);
            this.CardPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PBPersonImage;
        private System.Windows.Forms.GroupBox CardPersonInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.RichTextBox RTBNameLast;
        private System.Windows.Forms.RichTextBox RTBNameThird;
        private System.Windows.Forms.RichTextBox RTBNameFirst;
        private System.Windows.Forms.RichTextBox RTBNameSecond;
        private System.Windows.Forms.RichTextBox RTBNationalNo;
        private System.Windows.Forms.RichTextBox RTBEmail;
        private System.Windows.Forms.RichTextBox RTBAddress;
        private System.Windows.Forms.DateTimePicker DTPDateOfBirth;
        private System.Windows.Forms.RichTextBox RTBPhone;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RadioButton RBMale;
        private System.Windows.Forms.RadioButton RBFemale;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label LBLFormStatus;
        private System.Windows.Forms.ErrorProvider EP;
        private LinkLabel llblSetImage;
        private LinkLabel LlblRemoveImage;
    }
}