﻿namespace HastaneOtomasyon
{
    partial class frmHemsireGuncelleSil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstHemsireler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.dTDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbServisler = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lstHemsireler);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 369);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hemşireler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ara : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstHemsireler
            // 
            this.lstHemsireler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstHemsireler.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstHemsireler.FullRowSelect = true;
            this.lstHemsireler.GridLines = true;
            this.lstHemsireler.Location = new System.Drawing.Point(6, 62);
            this.lstHemsireler.Name = "lstHemsireler";
            this.lstHemsireler.Size = new System.Drawing.Size(314, 301);
            this.lstHemsireler.TabIndex = 0;
            this.lstHemsireler.UseCompatibleStateImageBehavior = false;
            this.lstHemsireler.View = System.Windows.Forms.View.Details;
            this.lstHemsireler.SelectedIndexChanged += new System.EventHandler(this.lstHemsireler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı ";
            this.columnHeader1.Width = 139;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 171;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(91, 102);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(191, 21);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(89, 233);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(191, 22);
            this.txtMail.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(89, 207);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(191, 22);
            this.txtTelefon.TabIndex = 7;
            // 
            // dTDogumTarihi
            // 
            this.dTDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTDogumTarihi.Location = new System.Drawing.Point(89, 182);
            this.dTDogumTarihi.Name = "dTDogumTarihi";
            this.dTDogumTarihi.Size = new System.Drawing.Size(190, 22);
            this.dTDogumTarihi.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(91, 261);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(191, 77);
            this.txtAdres.TabIndex = 9;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(91, 76);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(191, 22);
            this.txtTCKimlikNo.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(91, 50);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(191, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad : ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(91, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(191, 22);
            this.txtAd.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Adres : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mail  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "T.C. Kimlik No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doğum Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cinsiyet :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefon :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbServisler);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbDoktorlar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbCinsiyet);
            this.groupBox3.Controls.Add(this.txtMail);
            this.groupBox3.Controls.Add(this.txtTelefon);
            this.groupBox3.Controls.Add(this.dTDogumTarihi);
            this.groupBox3.Controls.Add(this.txtAdres);
            this.groupBox3.Controls.Add(this.txtTCKimlikNo);
            this.groupBox3.Controls.Add(this.txtSoyad);
            this.groupBox3.Controls.Add(this.txtAd);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(359, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 344);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hemşire Bilgileri";
            // 
            // cmbServisler
            // 
            this.cmbServisler.FormattingEnabled = true;
            this.cmbServisler.Location = new System.Drawing.Point(88, 129);
            this.cmbServisler.Name = "cmbServisler";
            this.cmbServisler.Size = new System.Drawing.Size(191, 21);
            this.cmbServisler.TabIndex = 4;
            this.cmbServisler.SelectedIndexChanged += new System.EventHandler(this.cmbServisler_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Branş :";
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(88, 156);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(191, 21);
            this.cmbDoktorlar.TabIndex = 5;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doktor :";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::HastaneOtomasyon.Properties.Resources.save;
            this.button1.Location = new System.Drawing.Point(566, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Güncelle";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::HastaneOtomasyon.Properties.Resources.iptal;
            this.button2.Location = new System.Drawing.Point(485, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Sil";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmHemsireGuncelleSil
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHemsireGuncelleSil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hemşire Güncelle/Sil";
            this.Load += new System.EventHandler(this.frmHemsireGuncelleSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lstHemsireler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.DateTimePicker dTDogumTarihi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbServisler;
        private System.Windows.Forms.Label label11;
    }
}