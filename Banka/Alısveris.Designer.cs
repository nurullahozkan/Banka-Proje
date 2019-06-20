namespace Banka
{
    partial class Alısveris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alısveris));
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_av_id = new System.Windows.Forms.TextBox();
            this.txt_urunkodu = new System.Windows.Forms.TextBox();
            this.txt_urunadi = new System.Windows.Forms.TextBox();
            this.txt_urunfiyati = new System.Windows.Forms.TextBox();
            this.txt_kartno = new System.Windows.Forms.TextBox();
            this.txt_sktarihi = new System.Windows.Forms.TextBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(333, 242);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 50);
            this.btn_sil.TabIndex = 30;
            this.btn_sil.Text = "Alışveriş Bilgilerini Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(333, 126);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 54);
            this.btn_ekle.TabIndex = 29;
            this.btn_ekle.Text = "Alışveriş Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(538, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 426);
            this.dataGridView1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Alışveriş ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ürün Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Kartno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Son Kullanma Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "CVV";
            // 
            // txt_av_id
            // 
            this.txt_av_id.Location = new System.Drawing.Point(163, 90);
            this.txt_av_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_av_id.Name = "txt_av_id";
            this.txt_av_id.Size = new System.Drawing.Size(132, 22);
            this.txt_av_id.TabIndex = 41;
            // 
            // txt_urunkodu
            // 
            this.txt_urunkodu.Location = new System.Drawing.Point(163, 122);
            this.txt_urunkodu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urunkodu.Name = "txt_urunkodu";
            this.txt_urunkodu.Size = new System.Drawing.Size(132, 22);
            this.txt_urunkodu.TabIndex = 42;
            // 
            // txt_urunadi
            // 
            this.txt_urunadi.Location = new System.Drawing.Point(163, 154);
            this.txt_urunadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urunadi.Name = "txt_urunadi";
            this.txt_urunadi.Size = new System.Drawing.Size(132, 22);
            this.txt_urunadi.TabIndex = 43;
            // 
            // txt_urunfiyati
            // 
            this.txt_urunfiyati.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_urunfiyati.Location = new System.Drawing.Point(163, 186);
            this.txt_urunfiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_urunfiyati.Name = "txt_urunfiyati";
            this.txt_urunfiyati.Size = new System.Drawing.Size(132, 22);
            this.txt_urunfiyati.TabIndex = 44;
            this.txt_urunfiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_urunfiyati_KeyPress);
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(163, 218);
            this.txt_kartno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(132, 22);
            this.txt_kartno.TabIndex = 45;
            this.txt_kartno.Enter += new System.EventHandler(this.txt_kartno_Enter);
            this.txt_kartno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kartno_KeyPress);
            // 
            // txt_sktarihi
            // 
            this.txt_sktarihi.Location = new System.Drawing.Point(163, 250);
            this.txt_sktarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sktarihi.Name = "txt_sktarihi";
            this.txt_sktarihi.Size = new System.Drawing.Size(132, 22);
            this.txt_sktarihi.TabIndex = 46;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(163, 282);
            this.txt_cvv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(132, 22);
            this.txt_cvv.TabIndex = 47;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(333, 187);
            this.btn_iptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(100, 48);
            this.btn_iptal.TabIndex = 48;
            this.btn_iptal.Text = "Alışveriş İptali";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // Alısveris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 455);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.txt_sktarihi);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.txt_urunfiyati);
            this.Controls.Add(this.txt_urunadi);
            this.Controls.Add(this.txt_urunkodu);
            this.Controls.Add(this.txt_av_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alısveris";
            this.Text = "Alışveriş Bilgileri";
            this.Load += new System.EventHandler(this.Alısveris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_av_id;
        private System.Windows.Forms.TextBox txt_urunkodu;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.TextBox txt_urunfiyati;
        private System.Windows.Forms.TextBox txt_kartno;
        private System.Windows.Forms.TextBox txt_sktarihi;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.Button btn_iptal;
    }
}