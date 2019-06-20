namespace Banka
{
    partial class Banka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banka));
            this.txt_faizorani = new System.Windows.Forms.TextBox();
            this.btn_mesajgonder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_faizorani
            // 
            this.txt_faizorani.Location = new System.Drawing.Point(618, 150);
            this.txt_faizorani.Margin = new System.Windows.Forms.Padding(4);
            this.txt_faizorani.Name = "txt_faizorani";
            this.txt_faizorani.Size = new System.Drawing.Size(132, 22);
            this.txt_faizorani.TabIndex = 6;
            this.txt_faizorani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_faizorani_KeyPress_1);
            // 
            // btn_mesajgonder
            // 
            this.btn_mesajgonder.Location = new System.Drawing.Point(633, 180);
            this.btn_mesajgonder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mesajgonder.Name = "btn_mesajgonder";
            this.btn_mesajgonder.Size = new System.Drawing.Size(117, 28);
            this.btn_mesajgonder.TabIndex = 5;
            this.btn_mesajgonder.Text = "Güncelle";
            this.btn_mesajgonder.UseVisualStyleBackColor = true;
            this.btn_mesajgonder.Click += new System.EventHandler(this.btn_mesajgonder_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 111);
            this.dataGridView1.TabIndex = 4;
            // 
            // Banka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(816, 455);
            this.Controls.Add(this.txt_faizorani);
            this.Controls.Add(this.btn_mesajgonder);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Banka";
            this.Text = "Banka";
            this.Load += new System.EventHandler(this.Banka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_faizorani;
        private System.Windows.Forms.Button btn_mesajgonder;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}