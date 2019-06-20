using Npgsql;
using System;
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
    public partial class HesapListele : Form
    {
        public HesapListele()
        {
            InitializeComponent();
        }

        public void HesapListele_Load(object sender, EventArgs e)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from hesap", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            Baglanti t = new Baglanti();
            Hesap hesap = new Hesap();
            Form1 form1 = new Form1();
            hesap.txt_musterino.Text = txt_musterino.Text;
            form1.txt_musterino.Text = txt_musterino.Text;
            if (txt_musterino.Text != "")
            {
                if (hesap.musteriNoKontrol())
                {
                    if (form1.hesapSayısıKontrol() == true)
                    {
                        form1.txt_musterino.Text = txt_musterino.Text;
                        hesap.txt_hesapno.Text = form1.hesapNoCek();
                        hesap.txt_iban.Text = form1.ibanNoCek();
                        hesap.txt_musterino.ReadOnly = true;
                        hesap.txt_hesapno.ReadOnly = true;
                        hesap.txt_iban.ReadOnly = true;
                        hesap.Hesap_Load(sender, e);
                        hesap.ShowDialog();
                    }
                    else
                    {
                        form1.txt_musterino.Text = txt_musterino.Text;
                        hesap.txt_musterino.ReadOnly = true;
                        hesap.txt_hesapno.Text = "";
                        hesap.txt_iban.Text = "";
                        hesap.Hesap_Load(sender, e);
                        hesap.ShowDialog();
                    }
                }
            }
            else
                MessageBox.Show("Lütfen Müşteri Numarası Giriniz");
        }

        private void txt_musterino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_musterino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
