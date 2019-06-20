using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Banka : Form, Observer
    {
        public Banka()
        {
            InitializeComponent();
        }

        Baglanti t;
        Form1 f = new Form1();
        public void Banka_Load(object sender, EventArgs e)
        {
            t = new Baglanti();
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from banka", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            txt_faizorani.Text = "";
        }

        public void Guncelle()
        {
            if (txt_faizorani.Text != "")
            {
                NpgsqlCommand guncelle = new NpgsqlCommand("update banka set faiz_oranı='" + txt_faizorani.Text + "' ", t.getBaglanti());
                guncelle.ExecuteNonQuery();
                MessageBox.Show("Faiz Oranı Güncellendi Ve Bütün Müşterilere Bildirim Gönderildi.");
                txt_faizorani.Text = "";
                f.ShowDialog();
            }
            else
            {
                t.getBaglanti().Close();
                MessageBox.Show("Bu Alan Boş Olamaz");
            }
        }
        
            private void btn_mesajgonder_Click_1(object sender, EventArgs e)
        {
            if (txt_faizorani.Text != "")
            {
                Form1 form1 = new Form1();
                this.Guncelle();
                f.bildirim();
                form1.Form1_Load(sender, e);
                Banka_Load(sender, e);
            }
            else
                MessageBox.Show("Bu Alan Boş Olamaz");
        }

        private void txt_faizorani_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar=='.' && e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }
    }
}
