namespace Banka
{
    partial class HesapListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_musterino = new System.Windows.Forms.TextBox();
            this.btn_git = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 428);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Numarası :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_musterino
            // 
            this.txt_musterino.Location = new System.Drawing.Point(149, 423);
            this.txt_musterino.Margin = new System.Windows.Forms.Padding(4);
            this.txt_musterino.Name = "txt_musterino";
            this.txt_musterino.Size = new System.Drawing.Size(132, 22);
            this.txt_musterino.TabIndex = 2;
            this.txt_musterino.TextChanged += new System.EventHandler(this.txt_musterino_TextChanged);
            this.txt_musterino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_musterino_KeyPress);
            // 
            // btn_git
            // 
            this.btn_git.Location = new System.Drawing.Point(336, 422);
            this.btn_git.Margin = new System.Windows.Forms.Padding(4);
            this.btn_git.Name = "btn_git";
            this.btn_git.Size = new System.Drawing.Size(100, 28);
            this.btn_git.TabIndex = 3;
            this.btn_git.Text = "GİT";
            this.btn_git.UseVisualStyleBackColor = true;
            this.btn_git.Click += new System.EventHandler(this.btn_git_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(703, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "* Hesap eklemek veya hesap bilgilerini görmek için müşteri numarası ile hesap bil" +
    "gileri bölünümne giriş yapınız.";
            // 
            // HesapListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_git);
            this.Controls.Add(this.txt_musterino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HesapListele";
            this.Text = "Hesap Listesi";
            this.Load += new System.EventHandler(this.HesapListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_musterino;
        private System.Windows.Forms.Button btn_git;
        private System.Windows.Forms.Label label2;
    }
}