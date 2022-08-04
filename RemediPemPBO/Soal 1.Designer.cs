namespace RemediPemPBO
{
    partial class Soal_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.kodeBuku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.judulBuku = new System.Windows.Forms.TextBox();
            this.bukuAjar = new System.Windows.Forms.RadioButton();
            this.komik = new System.Windows.Forms.RadioButton();
            this.containerAjar = new System.Windows.Forms.Panel();
            this.edisiNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.bidangComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.containerKomik = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.luarNegeri = new System.Windows.Forms.RadioButton();
            this.dalamNegeri = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tambahBuku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.detail = new System.Windows.Forms.Button();
            this.containerAjar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edisiNum)).BeginInit();
            this.containerKomik.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Buku :";
            // 
            // kodeBuku
            // 
            this.kodeBuku.Location = new System.Drawing.Point(92, 6);
            this.kodeBuku.Name = "kodeBuku";
            this.kodeBuku.Size = new System.Drawing.Size(110, 20);
            this.kodeBuku.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Judul Buku : ";
            // 
            // judulBuku
            // 
            this.judulBuku.Location = new System.Drawing.Point(92, 32);
            this.judulBuku.Name = "judulBuku";
            this.judulBuku.Size = new System.Drawing.Size(204, 20);
            this.judulBuku.TabIndex = 4;
            // 
            // bukuAjar
            // 
            this.bukuAjar.AutoSize = true;
            this.bukuAjar.Location = new System.Drawing.Point(15, 91);
            this.bukuAjar.Name = "bukuAjar";
            this.bukuAjar.Size = new System.Drawing.Size(71, 17);
            this.bukuAjar.TabIndex = 6;
            this.bukuAjar.TabStop = true;
            this.bukuAjar.Text = "Buku Ajar";
            this.bukuAjar.UseVisualStyleBackColor = true;
            this.bukuAjar.CheckedChanged += new System.EventHandler(this.bukuAjar_CheckedChanged);
            // 
            // komik
            // 
            this.komik.AutoSize = true;
            this.komik.Location = new System.Drawing.Point(15, 153);
            this.komik.Name = "komik";
            this.komik.Size = new System.Drawing.Size(54, 17);
            this.komik.TabIndex = 7;
            this.komik.TabStop = true;
            this.komik.Text = "Komik";
            this.komik.UseVisualStyleBackColor = true;
            this.komik.CheckedChanged += new System.EventHandler(this.komik_CheckedChanged);
            // 
            // containerAjar
            // 
            this.containerAjar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.containerAjar.Controls.Add(this.edisiNum);
            this.containerAjar.Controls.Add(this.label4);
            this.containerAjar.Controls.Add(this.bidangComboBox);
            this.containerAjar.Controls.Add(this.label3);
            this.containerAjar.Location = new System.Drawing.Point(92, 69);
            this.containerAjar.Name = "containerAjar";
            this.containerAjar.Size = new System.Drawing.Size(204, 64);
            this.containerAjar.TabIndex = 8;
            // 
            // edisiNum
            // 
            this.edisiNum.Location = new System.Drawing.Point(72, 34);
            this.edisiNum.Name = "edisiNum";
            this.edisiNum.Size = new System.Drawing.Size(64, 20);
            this.edisiNum.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edisi        :";
            // 
            // bidangComboBox
            // 
            this.bidangComboBox.FormattingEnabled = true;
            this.bidangComboBox.Items.AddRange(new object[] {
            "Komputer",
            "Pemrograman",
            "Akuntansi",
            "Manajemen",
            "Ekonomi",
            "Lainnya"});
            this.bidangComboBox.Location = new System.Drawing.Point(72, 10);
            this.bidangComboBox.Name = "bidangComboBox";
            this.bidangComboBox.Size = new System.Drawing.Size(121, 21);
            this.bidangComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bidang    :";
            // 
            // containerKomik
            // 
            this.containerKomik.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.containerKomik.Controls.Add(this.panel3);
            this.containerKomik.Controls.Add(this.label6);
            this.containerKomik.Location = new System.Drawing.Point(92, 139);
            this.containerKomik.Name = "containerKomik";
            this.containerKomik.Size = new System.Drawing.Size(204, 64);
            this.containerKomik.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.luarNegeri);
            this.panel3.Controls.Add(this.dalamNegeri);
            this.panel3.Location = new System.Drawing.Point(72, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 46);
            this.panel3.TabIndex = 11;
            // 
            // luarNegeri
            // 
            this.luarNegeri.AutoSize = true;
            this.luarNegeri.Location = new System.Drawing.Point(4, 26);
            this.luarNegeri.Name = "luarNegeri";
            this.luarNegeri.Size = new System.Drawing.Size(80, 17);
            this.luarNegeri.TabIndex = 1;
            this.luarNegeri.TabStop = true;
            this.luarNegeri.Text = "Luar Negeri";
            this.luarNegeri.UseVisualStyleBackColor = true;
            // 
            // dalamNegeri
            // 
            this.dalamNegeri.AutoSize = true;
            this.dalamNegeri.Location = new System.Drawing.Point(4, 4);
            this.dalamNegeri.Name = "dalamNegeri";
            this.dalamNegeri.Size = new System.Drawing.Size(89, 17);
            this.dalamNegeri.TabIndex = 0;
            this.dalamNegeri.TabStop = true;
            this.dalamNegeri.Text = "Dalam Negeri";
            this.dalamNegeri.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Produk    :";
            // 
            // tambahBuku
            // 
            this.tambahBuku.Location = new System.Drawing.Point(92, 209);
            this.tambahBuku.Name = "tambahBuku";
            this.tambahBuku.Size = new System.Drawing.Size(204, 23);
            this.tambahBuku.TabIndex = 14;
            this.tambahBuku.Text = "Tambah";
            this.tambahBuku.UseVisualStyleBackColor = true;
            this.tambahBuku.Click += new System.EventHandler(this.tambahBuku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(302, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 199);
            this.listBox1.TabIndex = 15;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(302, 209);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(135, 23);
            this.detail.TabIndex = 16;
            this.detail.Text = "Detail";
            this.detail.UseVisualStyleBackColor = true;
            this.detail.Click += new System.EventHandler(this.detail_Click);
            // 
            // Soal_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 237);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tambahBuku);
            this.Controls.Add(this.containerKomik);
            this.Controls.Add(this.containerAjar);
            this.Controls.Add(this.komik);
            this.Controls.Add(this.bukuAjar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.judulBuku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodeBuku);
            this.Name = "Soal_1";
            this.Text = "Soal_1";
            this.containerAjar.ResumeLayout(false);
            this.containerAjar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edisiNum)).EndInit();
            this.containerKomik.ResumeLayout(false);
            this.containerKomik.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodeBuku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox judulBuku;
        private System.Windows.Forms.RadioButton bukuAjar;
        private System.Windows.Forms.RadioButton komik;
        private System.Windows.Forms.Panel containerAjar;
        private System.Windows.Forms.NumericUpDown edisiNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox bidangComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel containerKomik;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton luarNegeri;
        private System.Windows.Forms.RadioButton dalamNegeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tambahBuku;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button detail;
    }
}