namespace Banka
{
    partial class KrediKartı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KrediKartı));
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_kullanilan = new System.Windows.Forms.TextBox();
            this.txt_toplamlimit = new System.Windows.Forms.TextBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.txt_sonkullanmatarihi = new System.Windows.Forms.TextBox();
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
            this.btn_guncelle.BackColor = System.Drawing.Color.Red;
            this.btn_guncelle.Location = new System.Drawing.Point(399, 417);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(100, 28);
            this.btn_guncelle.TabIndex = 31;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click_1);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.Location = new System.Drawing.Point(237, 417);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 28);
            this.btn_sil.TabIndex = 30;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click_1);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Red;
            this.btn_ekle.Location = new System.Drawing.Point(63, 417);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 29;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 241);
            this.dataGridView1.TabIndex = 28;
            // 
            // txt_kullanilan
            // 
            this.txt_kullanilan.Location = new System.Drawing.Point(191, 282);
            this.txt_kullanilan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kullanilan.Name = "txt_kullanilan";
            this.txt_kullanilan.Size = new System.Drawing.Size(132, 22);
            this.txt_kullanilan.TabIndex = 27;
            this.txt_kullanilan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kullanilan_KeyPress);
            // 
            // txt_toplamlimit
            // 
            this.txt_toplamlimit.Location = new System.Drawing.Point(191, 228);
            this.txt_toplamlimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_toplamlimit.Name = "txt_toplamlimit";
            this.txt_toplamlimit.Size = new System.Drawing.Size(132, 22);
            this.txt_toplamlimit.TabIndex = 26;
            this.txt_toplamlimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_toplamlimit_KeyPress);
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(191, 182);
            this.txt_cvv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(132, 22);
            this.txt_cvv.TabIndex = 25;
            this.txt_cvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cvv_KeyPress);
            // 
            // txt_sonkullanmatarihi
            // 
            this.txt_sonkullanmatarihi.Location = new System.Drawing.Point(191, 130);
            this.txt_sonkullanmatarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_sonkullanmatarihi.Name = "txt_sonkullanmatarihi";
            this.txt_sonkullanmatarihi.Size = new System.Drawing.Size(132, 22);
            this.txt_sonkullanmatarihi.TabIndex = 24;
            this.txt_sonkullanmatarihi.TextChanged += new System.EventHandler(this.txt_sonkullanmatarihi_TextChanged);
            this.txt_sonkullanmatarihi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sonkullanmatarihi_KeyPress);
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(191, 82);
            this.txt_kartno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(132, 22);
            this.txt_kartno.TabIndex = 23;
            this.txt_kartno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kartno_KeyPress);
            // 
            // txt_musterino
            // 
            this.txt_musterino.Location = new System.Drawing.Point(191, 11);
            this.txt_musterino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_musterino.Name = "txt_musterino";
            this.txt_musterino.Size = new System.Drawing.Size(132, 22);
            this.txt_musterino.TabIndex = 22;
            this.txt_musterino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_musterino_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kullanılan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Toplam Limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "CVV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "S.K.T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kart No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Müşteri No";
            // 
            // KrediKartı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 455);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_kullanilan);
            this.Controls.Add(this.txt_toplamlimit);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.txt_sonkullanmatarihi);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.txt_musterino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KrediKartı";
            this.Text = "KrediKartı";
            this.Load += new System.EventHandler(this.KrediKartı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_kullanilan;
        private System.Windows.Forms.TextBox txt_toplamlimit;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.TextBox txt_sonkullanmatarihi;
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