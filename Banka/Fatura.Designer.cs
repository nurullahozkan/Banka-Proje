namespace Banka
{
    partial class Fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_sonodemetarihi = new System.Windows.Forms.TextBox();
            this.txt_hesapkesimtarihi = new System.Windows.Forms.TextBox();
            this.txt_asgaritutar = new System.Windows.Forms.TextBox();
            this.txt_donemborcu = new System.Windows.Forms.TextBox();
            this.txt_kartno = new System.Windows.Forms.TextBox();
            this.txt_musterino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(377, 370);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 28);
            this.btn_guncelle.TabIndex = 31;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(212, 370);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 28);
            this.btn_sil.TabIndex = 30;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(79, 370);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 29;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 251);
            this.dataGridView1.TabIndex = 28;
            // 
            // txt_sonodemetarihi
            // 
            this.txt_sonodemetarihi.Location = new System.Drawing.Point(212, 284);
            this.txt_sonodemetarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sonodemetarihi.Name = "txt_sonodemetarihi";
            this.txt_sonodemetarihi.Size = new System.Drawing.Size(132, 22);
            this.txt_sonodemetarihi.TabIndex = 27;
            this.txt_sonodemetarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sonodemetarihi_KeyPress);
            // 
            // txt_hesapkesimtarihi
            // 
            this.txt_hesapkesimtarihi.Location = new System.Drawing.Point(212, 235);
            this.txt_hesapkesimtarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_hesapkesimtarihi.Name = "txt_hesapkesimtarihi";
            this.txt_hesapkesimtarihi.Size = new System.Drawing.Size(132, 22);
            this.txt_hesapkesimtarihi.TabIndex = 26;
            this.txt_hesapkesimtarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hesapkesimtarihi_KeyPress);
            // 
            // txt_asgaritutar
            // 
            this.txt_asgaritutar.Location = new System.Drawing.Point(212, 185);
            this.txt_asgaritutar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_asgaritutar.Name = "txt_asgaritutar";
            this.txt_asgaritutar.Size = new System.Drawing.Size(132, 22);
            this.txt_asgaritutar.TabIndex = 25;
            this.txt_asgaritutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_asgaritutar_KeyPress);
            // 
            // txt_donemborcu
            // 
            this.txt_donemborcu.Location = new System.Drawing.Point(212, 145);
            this.txt_donemborcu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_donemborcu.Name = "txt_donemborcu";
            this.txt_donemborcu.Size = new System.Drawing.Size(132, 22);
            this.txt_donemborcu.TabIndex = 24;
            this.txt_donemborcu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_donemborcu_KeyPress);
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(212, 106);
            this.txt_kartno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(132, 22);
            this.txt_kartno.TabIndex = 23;
            this.txt_kartno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kartno_KeyPress);
            // 
            // txt_musterino
            // 
            this.txt_musterino.Location = new System.Drawing.Point(212, 58);
            this.txt_musterino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_musterino.Name = "txt_musterino";
            this.txt_musterino.Size = new System.Drawing.Size(132, 22);
            this.txt_musterino.TabIndex = 22;
            this.txt_musterino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_musterino_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Son Ödeme Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hesap Kesim Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Asgari Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dönem Borcu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kart No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Müşteri No";
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 407);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_sonodemetarihi);
            this.Controls.Add(this.txt_hesapkesimtarihi);
            this.Controls.Add(this.txt_asgaritutar);
            this.Controls.Add(this.txt_donemborcu);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.txt_musterino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_sonodemetarihi;
        private System.Windows.Forms.TextBox txt_hesapkesimtarihi;
        private System.Windows.Forms.TextBox txt_asgaritutar;
        private System.Windows.Forms.TextBox txt_donemborcu;
        private System.Windows.Forms.TextBox txt_kartno;
        private System.Windows.Forms.TextBox txt_musterino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}