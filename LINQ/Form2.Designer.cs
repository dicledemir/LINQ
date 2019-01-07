namespace LINQ
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_personel_sayi = new System.Windows.Forms.Label();
            this.lbl_ort_maas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "yeni personel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_personel_sayi
            // 
            this.lbl_personel_sayi.AutoSize = true;
            this.lbl_personel_sayi.Location = new System.Drawing.Point(46, 117);
            this.lbl_personel_sayi.Name = "lbl_personel_sayi";
            this.lbl_personel_sayi.Size = new System.Drawing.Size(160, 17);
            this.lbl_personel_sayi.TabIndex = 1;
            this.lbl_personel_sayi.Text = "Şu anda 0 personel var.";
            // 
            // lbl_ort_maas
            // 
            this.lbl_ort_maas.AutoSize = true;
            this.lbl_ort_maas.Location = new System.Drawing.Point(43, 153);
            this.lbl_ort_maas.Name = "lbl_ort_maas";
            this.lbl_ort_maas.Size = new System.Drawing.Size(201, 17);
            this.lbl_ort_maas.TabIndex = 2;
            this.lbl_ort_maas.Text = "Personel maaşı ortalama 0 TL.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son eklenen personelin";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(46, 237);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(45, 17);
            this.lblYas.TabIndex = 4;
            this.lblYas.Text = "yaşı 0";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(46, 280);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(57, 17);
            this.lblMaas.TabIndex = 5;
            this.lblMaas.Text = "maaşı 0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 371);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ort_maas);
            this.Controls.Add(this.lbl_personel_sayi);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_personel_sayi;
        private System.Windows.Forms.Label lbl_ort_maas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblMaas;
    }
}