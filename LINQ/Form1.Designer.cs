namespace LINQ
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTumSiparisler = new System.Windows.Forms.Button();
            this.tumSayiler = new System.Windows.Forms.Button();
            this.tum_isimler = new System.Windows.Forms.Button();
            this.sayilar_negatif = new System.Windows.Forms.Button();
            this.sayilar_pozitif = new System.Windows.Forms.Button();
            this.sayilar_cift = new System.Windows.Forms.Button();
            this.sayılar_tek = new System.Windows.Forms.Button();
            this.sayilar_enbüyük = new System.Windows.Forms.Button();
            this.sayılar_enkucuk = new System.Windows.Forms.Button();
            this.sayilar_kactane = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alfabetikSirali = new System.Windows.Forms.Button();
            this.AlfabetikTersSirali = new System.Windows.Forms.Button();
            this.Uzunluklar = new System.Windows.Forms.Button();
            this.Ibarındıranlar = new System.Windows.Forms.Button();
            this.Dilebaslayanlar = new System.Windows.Forms.Button();
            this.btnSadeceTarih = new System.Windows.Forms.Button();
            this.btnIlkBesTariih = new System.Windows.Forms.Button();
            this.btnSonBesTarih = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnTumSiparisler
            // 
            this.btnTumSiparisler.Location = new System.Drawing.Point(12, 115);
            this.btnTumSiparisler.Name = "btnTumSiparisler";
            this.btnTumSiparisler.Size = new System.Drawing.Size(158, 36);
            this.btnTumSiparisler.TabIndex = 1;
            this.btnTumSiparisler.Text = "Tüm Siparişler";
            this.btnTumSiparisler.UseVisualStyleBackColor = true;
            this.btnTumSiparisler.Click += new System.EventHandler(this.btnTumSiparisler_Click);
            // 
            // tumSayiler
            // 
            this.tumSayiler.Location = new System.Drawing.Point(12, 27);
            this.tumSayiler.Name = "tumSayiler";
            this.tumSayiler.Size = new System.Drawing.Size(158, 37);
            this.tumSayiler.TabIndex = 2;
            this.tumSayiler.Text = "Tüm Sayılar";
            this.tumSayiler.UseVisualStyleBackColor = true;
            this.tumSayiler.Click += new System.EventHandler(this.tumSayiler_Click);
            // 
            // tum_isimler
            // 
            this.tum_isimler.Location = new System.Drawing.Point(12, 70);
            this.tum_isimler.Name = "tum_isimler";
            this.tum_isimler.Size = new System.Drawing.Size(158, 39);
            this.tum_isimler.TabIndex = 3;
            this.tum_isimler.Text = "Tüm İsimler";
            this.tum_isimler.UseVisualStyleBackColor = true;
            // 
            // sayilar_negatif
            // 
            this.sayilar_negatif.Location = new System.Drawing.Point(176, 27);
            this.sayilar_negatif.Name = "sayilar_negatif";
            this.sayilar_negatif.Size = new System.Drawing.Size(62, 39);
            this.sayilar_negatif.TabIndex = 4;
            this.sayilar_negatif.Text = "Negatif";
            this.sayilar_negatif.UseVisualStyleBackColor = true;
            this.sayilar_negatif.Click += new System.EventHandler(this.sayilar_negatif_Click);
            // 
            // sayilar_pozitif
            // 
            this.sayilar_pozitif.Location = new System.Drawing.Point(244, 27);
            this.sayilar_pozitif.Name = "sayilar_pozitif";
            this.sayilar_pozitif.Size = new System.Drawing.Size(56, 39);
            this.sayilar_pozitif.TabIndex = 5;
            this.sayilar_pozitif.Text = "Pozitif";
            this.sayilar_pozitif.UseVisualStyleBackColor = true;
            this.sayilar_pozitif.Click += new System.EventHandler(this.sayilar_pozitif_Click);
            // 
            // sayilar_cift
            // 
            this.sayilar_cift.Location = new System.Drawing.Point(306, 27);
            this.sayilar_cift.Name = "sayilar_cift";
            this.sayilar_cift.Size = new System.Drawing.Size(49, 39);
            this.sayilar_cift.TabIndex = 6;
            this.sayilar_cift.Text = "Çift";
            this.sayilar_cift.UseVisualStyleBackColor = true;
            this.sayilar_cift.Click += new System.EventHandler(this.sayilar_cift_Click);
            // 
            // sayılar_tek
            // 
            this.sayılar_tek.Location = new System.Drawing.Point(361, 27);
            this.sayılar_tek.Name = "sayılar_tek";
            this.sayılar_tek.Size = new System.Drawing.Size(49, 39);
            this.sayılar_tek.TabIndex = 7;
            this.sayılar_tek.Text = "tek";
            this.sayılar_tek.UseVisualStyleBackColor = true;
            this.sayılar_tek.Click += new System.EventHandler(this.sayılar_tek_Click);
            // 
            // sayilar_enbüyük
            // 
            this.sayilar_enbüyük.Location = new System.Drawing.Point(426, 25);
            this.sayilar_enbüyük.Name = "sayilar_enbüyük";
            this.sayilar_enbüyük.Size = new System.Drawing.Size(90, 39);
            this.sayilar_enbüyük.TabIndex = 8;
            this.sayilar_enbüyük.Text = "En Büyük";
            this.sayilar_enbüyük.UseVisualStyleBackColor = true;
            this.sayilar_enbüyük.Click += new System.EventHandler(this.sayilar_enbüyük_Click);
            // 
            // sayılar_enkucuk
            // 
            this.sayılar_enkucuk.Location = new System.Drawing.Point(522, 27);
            this.sayılar_enkucuk.Name = "sayılar_enkucuk";
            this.sayılar_enkucuk.Size = new System.Drawing.Size(84, 39);
            this.sayılar_enkucuk.TabIndex = 9;
            this.sayılar_enkucuk.Text = "En Küçük";
            this.sayılar_enkucuk.UseVisualStyleBackColor = true;
            this.sayılar_enkucuk.Click += new System.EventHandler(this.sayılar_enkucuk_Click);
            // 
            // sayilar_kactane
            // 
            this.sayilar_kactane.Location = new System.Drawing.Point(612, 27);
            this.sayilar_kactane.Name = "sayilar_kactane";
            this.sayilar_kactane.Size = new System.Drawing.Size(84, 39);
            this.sayilar_kactane.TabIndex = 10;
            this.sayilar_kactane.Text = "Kaç Tane";
            this.sayilar_kactane.UseVisualStyleBackColor = true;
            this.sayilar_kactane.Click += new System.EventHandler(this.sayilar_kactane_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 199);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 164);
            this.listBox1.TabIndex = 11;
            // 
            // alfabetikSirali
            // 
            this.alfabetikSirali.Location = new System.Drawing.Point(176, 72);
            this.alfabetikSirali.Name = "alfabetikSirali";
            this.alfabetikSirali.Size = new System.Drawing.Size(138, 39);
            this.alfabetikSirali.TabIndex = 12;
            this.alfabetikSirali.Text = "Alfabetik Sıralı";
            this.alfabetikSirali.UseVisualStyleBackColor = true;
            this.alfabetikSirali.Click += new System.EventHandler(this.alfabetikSirali_Click);
            // 
            // AlfabetikTersSirali
            // 
            this.AlfabetikTersSirali.Location = new System.Drawing.Point(320, 72);
            this.AlfabetikTersSirali.Name = "AlfabetikTersSirali";
            this.AlfabetikTersSirali.Size = new System.Drawing.Size(135, 39);
            this.AlfabetikTersSirali.TabIndex = 13;
            this.AlfabetikTersSirali.Text = "Alfabetik ters Sıralı";
            this.AlfabetikTersSirali.UseVisualStyleBackColor = true;
            this.AlfabetikTersSirali.Click += new System.EventHandler(this.AlfabetikTersSirali_Click);
            // 
            // Uzunluklar
            // 
            this.Uzunluklar.Location = new System.Drawing.Point(461, 72);
            this.Uzunluklar.Name = "Uzunluklar";
            this.Uzunluklar.Size = new System.Drawing.Size(112, 39);
            this.Uzunluklar.TabIndex = 14;
            this.Uzunluklar.Text = "Uzunluklar";
            this.Uzunluklar.UseVisualStyleBackColor = true;
            this.Uzunluklar.Click += new System.EventHandler(this.Uzunluklar_Click);
            // 
            // Ibarındıranlar
            // 
            this.Ibarındıranlar.Location = new System.Drawing.Point(579, 72);
            this.Ibarındıranlar.Name = "Ibarındıranlar";
            this.Ibarındıranlar.Size = new System.Drawing.Size(112, 39);
            this.Ibarındıranlar.TabIndex = 15;
            this.Ibarındıranlar.Text = "i barındıran";
            this.Ibarındıranlar.UseVisualStyleBackColor = true;
            this.Ibarındıranlar.Click += new System.EventHandler(this.Ibarındıranlar_Click);
            // 
            // Dilebaslayanlar
            // 
            this.Dilebaslayanlar.Location = new System.Drawing.Point(579, 117);
            this.Dilebaslayanlar.Name = "Dilebaslayanlar";
            this.Dilebaslayanlar.Size = new System.Drawing.Size(138, 39);
            this.Dilebaslayanlar.TabIndex = 16;
            this.Dilebaslayanlar.Text = "D ile başlayanlar";
            this.Dilebaslayanlar.UseVisualStyleBackColor = true;
            this.Dilebaslayanlar.Click += new System.EventHandler(this.Dilebaslayanlar_Click);
            // 
            // btnSadeceTarih
            // 
            this.btnSadeceTarih.Location = new System.Drawing.Point(176, 115);
            this.btnSadeceTarih.Name = "btnSadeceTarih";
            this.btnSadeceTarih.Size = new System.Drawing.Size(138, 36);
            this.btnSadeceTarih.TabIndex = 17;
            this.btnSadeceTarih.Text = "Sadece Tarihler";
            this.btnSadeceTarih.UseVisualStyleBackColor = true;
            this.btnSadeceTarih.Click += new System.EventHandler(this.btnSadeceTarih_Click);
            // 
            // btnIlkBesTariih
            // 
            this.btnIlkBesTariih.Location = new System.Drawing.Point(320, 115);
            this.btnIlkBesTariih.Name = "btnIlkBesTariih";
            this.btnIlkBesTariih.Size = new System.Drawing.Size(69, 36);
            this.btnIlkBesTariih.TabIndex = 18;
            this.btnIlkBesTariih.Text = "ilk 5";
            this.btnIlkBesTariih.UseVisualStyleBackColor = true;
            this.btnIlkBesTariih.Click += new System.EventHandler(this.btnIlkBesTariih_Click);
            // 
            // btnSonBesTarih
            // 
            this.btnSonBesTarih.Location = new System.Drawing.Point(393, 117);
            this.btnSonBesTarih.Name = "btnSonBesTarih";
            this.btnSonBesTarih.Size = new System.Drawing.Size(69, 36);
            this.btnSonBesTarih.TabIndex = 19;
            this.btnSonBesTarih.Text = "Son 5";
            this.btnSonBesTarih.UseVisualStyleBackColor = true;
            this.btnSonBesTarih.Click += new System.EventHandler(this.btnSonBesTarih_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "Yang Wang";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sipariş Sayısı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSonBesTarih);
            this.Controls.Add(this.btnIlkBesTariih);
            this.Controls.Add(this.btnSadeceTarih);
            this.Controls.Add(this.Dilebaslayanlar);
            this.Controls.Add(this.Ibarındıranlar);
            this.Controls.Add(this.Uzunluklar);
            this.Controls.Add(this.AlfabetikTersSirali);
            this.Controls.Add(this.alfabetikSirali);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sayilar_kactane);
            this.Controls.Add(this.sayılar_enkucuk);
            this.Controls.Add(this.sayilar_enbüyük);
            this.Controls.Add(this.sayılar_tek);
            this.Controls.Add(this.sayilar_cift);
            this.Controls.Add(this.sayilar_pozitif);
            this.Controls.Add(this.sayilar_negatif);
            this.Controls.Add(this.tum_isimler);
            this.Controls.Add(this.tumSayiler);
            this.Controls.Add(this.btnTumSiparisler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTumSiparisler;
        private System.Windows.Forms.Button tumSayiler;
        private System.Windows.Forms.Button tum_isimler;
        private System.Windows.Forms.Button sayilar_negatif;
        private System.Windows.Forms.Button sayilar_pozitif;
        private System.Windows.Forms.Button sayilar_cift;
        private System.Windows.Forms.Button sayılar_tek;
        private System.Windows.Forms.Button sayilar_enbüyük;
        private System.Windows.Forms.Button sayılar_enkucuk;
        private System.Windows.Forms.Button sayilar_kactane;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button alfabetikSirali;
        private System.Windows.Forms.Button AlfabetikTersSirali;
        private System.Windows.Forms.Button Uzunluklar;
        private System.Windows.Forms.Button Ibarındıranlar;
        private System.Windows.Forms.Button Dilebaslayanlar;
        private System.Windows.Forms.Button btnSadeceTarih;
        private System.Windows.Forms.Button btnIlkBesTariih;
        private System.Windows.Forms.Button btnSonBesTarih;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}

