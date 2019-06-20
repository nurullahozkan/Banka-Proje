namespace Banka
{
    partial class TransferForm
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
            this.textBox_aliciAdSoyad = new System.Windows.Forms.TextBox();
            this.button_gonder = new System.Windows.Forms.Button();
            this.textBox_gondAdSoyad = new System.Windows.Forms.TextBox();
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.textBox_aliciHesapNo = new System.Windows.Forms.TextBox();
            this.label_gonderenAdSoyad = new System.Windows.Forms.Label();
            this.label_aliciAdSoyad = new System.Windows.Forms.Label();
            this.label_aliciHesapNo = new System.Windows.Forms.Label();
            this.label_tutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_aliciAdSoyad
            // 
            this.textBox_aliciAdSoyad.Location = new System.Drawing.Point(393, 102);
            this.textBox_aliciAdSoyad.Name = "textBox_aliciAdSoyad";
            this.textBox_aliciAdSoyad.Size = new System.Drawing.Size(235, 22);
            this.textBox_aliciAdSoyad.TabIndex = 0;
            // 
            // button_gonder
            // 
            this.button_gonder.BackColor = System.Drawing.Color.Yellow;
            this.button_gonder.Location = new System.Drawing.Point(259, 238);
            this.button_gonder.Name = "button_gonder";
            this.button_gonder.Size = new System.Drawing.Size(143, 54);
            this.button_gonder.TabIndex = 1;
            this.button_gonder.Text = "GÖNDER";
            this.button_gonder.UseVisualStyleBackColor = false;
            this.button_gonder.Click += new System.EventHandler(this.Button_gonder_Click);
            // 
            // textBox_gondAdSoyad
            // 
            this.textBox_gondAdSoyad.Location = new System.Drawing.Point(393, 65);
            this.textBox_gondAdSoyad.Name = "textBox_gondAdSoyad";
            this.textBox_gondAdSoyad.Size = new System.Drawing.Size(235, 22);
            this.textBox_gondAdSoyad.TabIndex = 2;
            this.textBox_gondAdSoyad.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.Location = new System.Drawing.Point(475, 177);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(153, 22);
            this.textBox_tutar.TabIndex = 4;
            // 
            // textBox_aliciHesapNo
            // 
            this.textBox_aliciHesapNo.Location = new System.Drawing.Point(393, 139);
            this.textBox_aliciHesapNo.Name = "textBox_aliciHesapNo";
            this.textBox_aliciHesapNo.Size = new System.Drawing.Size(235, 22);
            this.textBox_aliciHesapNo.TabIndex = 5;
            this.textBox_aliciHesapNo.TextChanged += new System.EventHandler(this.TextBox_aliciHesapNo_TextChanged);
            // 
            // label_gonderenAdSoyad
            // 
            this.label_gonderenAdSoyad.AutoSize = true;
            this.label_gonderenAdSoyad.Location = new System.Drawing.Point(90, 65);
            this.label_gonderenAdSoyad.Name = "label_gonderenAdSoyad";
            this.label_gonderenAdSoyad.Size = new System.Drawing.Size(163, 17);
            this.label_gonderenAdSoyad.TabIndex = 6;
            this.label_gonderenAdSoyad.Text = "GÖNDEREN AD/SOYAD";
            this.label_gonderenAdSoyad.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label_aliciAdSoyad
            // 
            this.label_aliciAdSoyad.AutoSize = true;
            this.label_aliciAdSoyad.Location = new System.Drawing.Point(90, 102);
            this.label_aliciAdSoyad.Name = "label_aliciAdSoyad";
            this.label_aliciAdSoyad.Size = new System.Drawing.Size(115, 17);
            this.label_aliciAdSoyad.TabIndex = 7;
            this.label_aliciAdSoyad.Text = "ALİCİ AD/SOYAD";
            // 
            // label_aliciHesapNo
            // 
            this.label_aliciHesapNo.AutoSize = true;
            this.label_aliciHesapNo.Location = new System.Drawing.Point(90, 142);
            this.label_aliciHesapNo.Name = "label_aliciHesapNo";
            this.label_aliciHesapNo.Size = new System.Drawing.Size(165, 17);
            this.label_aliciHesapNo.TabIndex = 8;
            this.label_aliciHesapNo.Text = "ALİCİ HESAP NUMARASI";
            // 
            // label_tutar
            // 
            this.label_tutar.AutoSize = true;
            this.label_tutar.Location = new System.Drawing.Point(90, 177);
            this.label_tutar.Name = "label_tutar";
            this.label_tutar.Size = new System.Drawing.Size(55, 17);
            this.label_tutar.TabIndex = 9;
            this.label_tutar.Text = "TUTAR";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 368);
            this.Controls.Add(this.label_tutar);
            this.Controls.Add(this.label_aliciHesapNo);
            this.Controls.Add(this.label_aliciAdSoyad);
            this.Controls.Add(this.label_gonderenAdSoyad);
            this.Controls.Add(this.textBox_aliciHesapNo);
            this.Controls.Add(this.textBox_tutar);
            this.Controls.Add(this.textBox_gondAdSoyad);
            this.Controls.Add(this.button_gonder);
            this.Controls.Add(this.textBox_aliciAdSoyad);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_aliciAdSoyad;
        private System.Windows.Forms.Button button_gonder;
        private System.Windows.Forms.TextBox textBox_gondAdSoyad;
        private System.Windows.Forms.TextBox textBox_tutar;
        private System.Windows.Forms.TextBox textBox_aliciHesapNo;
        private System.Windows.Forms.Label label_gonderenAdSoyad;
        private System.Windows.Forms.Label label_aliciAdSoyad;
        private System.Windows.Forms.Label label_aliciHesapNo;
        private System.Windows.Forms.Label label_tutar;
    }
}