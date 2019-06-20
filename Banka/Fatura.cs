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
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
        }

        Baglanti t;
        Form1 form1;
        public void Fatura_Load(object sender, EventArgs e)
        {
            t = new Baglanti();
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from fatura", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;


        }

        private void btn_ekle_Click_1(object sender, EventArgs e)
        {
            t = new Baglanti();
            form1 = new Form1();
            form1.txt_musterino.Text = txt_musterino.Text;
            if (txt_musterino.Text != "" && txt_kartno.Text != "")
            {
                if (txt_musterino.Text != "" && txt_kartno.Text != "" && txt_donemborcu.Text != "" && txt_asgaritutar.Text != "" && txt_hesapkesimtarihi.Text != "" && txt_sonodemetarihi.Text != "") ;
                {
                    if (form1.musteriNoKontrol())
                    {
                        NpgsqlCommand cmdekle = new NpgsqlCommand("insert into fatura(musteri_no,kart_no,donemborcu,asgaritutar,hesapkesimtarihi,sonodemetarihi) values ('" + txt_musterino.Text + "','" + txt_kartno.Text + "','" + txt_donemborcu.Text + "','" + txt_asgaritutar.Text + "','" + txt_hesapkesimtarihi.Text + "','" + txt_sonodemetarihi.Text + "')", t.getBaglanti());
                        cmdekle.ExecuteNonQuery();
                        MessageBox.Show("Fatura Eklendi");
                        txt_musterino.Text = "";
                        txt_kartno.Text = "";
                        txt_donemborcu.Text = "";
                        txt_asgaritutar.Text = "";
                        txt_hesapkesimtarihi.Text = "";
                        txt_sonodemetarihi.Text = "";
                        Fatura_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("EKSİK BİLGİ GİRDİNİZ");
                    }
                }
            }
            else
                MessageBox.Show("Müşteri ve Kart Numarası Giriniz");
        }

        private void btn_sil_Click_1(object sender, EventArgs e)
        {
            form1 = new Form1();
            txt_kartno.ReadOnly = false;
            form1.txt_musterino.Text = txt_musterino.Text;
            if (txt_musterino.Text != "")
            {
                if (!form1.musteriNoKontrol())
                {
                    MessageBox.Show("Müşteri Numarası Giriniz");
                }
                else
                {
                    if (txt_kartno.Text != "")
                    {
                        NpgsqlCommand cmdsil = new NpgsqlCommand("delete from fatura where musteri_no='" + txt_musterino.Text + "' and kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
                        cmdsil.ExecuteNonQuery();
                        MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
                    }
                    else
                        MessageBox.Show("Kart Numarası Giriniz");
                }
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Müşteri Numarasını Giriniz");
            }
            txt_musterino.Text = "";
            txt_kartno.Text = "";
            txt_donemborcu.Text = "";
            txt_asgaritutar.Text = "";
            txt_hesapkesimtarihi.Text = "";
            txt_sonodemetarihi.Text = "";
            Fatura_Load(sender, e);
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            if (txt_donemborcu.Text != "")
            {
                NpgsqlCommand cmdsave = new NpgsqlCommand("update fatura set donemborcu='" + txt_donemborcu.Text + "' where musteri_no='" + txt_musterino.Text + "'and kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
                cmdsave.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Tamamlandı");
            }
            else
            {
                MessageBox.Show("Güncellemek İstediğin Donem Borcunu Gir");
            }
            txt_musterino.Text = "";
            txt_kartno.Text = "";
            txt_donemborcu.Text = "";
            txt_asgaritutar.Text = "";
            txt_hesapkesimtarihi.Text = "";
            txt_sonodemetarihi.Text = "";
            Fatura_Load(sender, e);
        }

        private void txt_musterino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_kartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_donemborcu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar!='.')
            {
                e.Handled = true;
            }
        }

        private void txt_asgaritutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_hesapkesimtarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_sonodemetarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
 }


