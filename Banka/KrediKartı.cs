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
    public partial class KrediKartı : Form
    {
        public KrediKartı()
        {
            InitializeComponent();
        }

        Baglanti t;
        Hesap hesap;
        Form1 form1;
        public string kartNoUret()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select max(kart_no) from kredikartı", t.getBaglanti());
            NpgsqlDataReader dr = hesapno.ExecuteReader();
            dr.Read();
            string sonKartno;
            sonKartno = dr[0].ToString();
            char[] dizi = sonKartno.ToCharArray();
            if (dizi[15] == '9')
            {
                dizi[15] = '0';
                if (dizi[14] == '9')
                {
                    dizi[14] = '0';
                    if (dizi[13] == '9')
                    {
                        dizi[13] = '0';
                        if (dizi[12] == '9')
                        {
                            dizi[12] = '0';
                            dizi[11]++;
                        }
                        else
                            dizi[12]++;
                    }
                    else
                        dizi[13]++;
                }
                else
                    dizi[14]++;
            }
            else
                dizi[15]++;

            string k = new string(dizi);
            t.getBaglanti().Close();
            return k;
        }

        public void KrediKartı_Load(object sender, EventArgs e)
        {
            t = new Baglanti();
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from kredikartı", t.getBaglanti());
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
            if (txt_musterino.Text != "" && txt_sonkullanmatarihi.Text != "" && txt_cvv.Text != "" && txt_toplamlimit.Text != "" && txt_kullanilan.Text != "") ;
            {
                if (form1.musteriNoKontrol())
                {


                    NpgsqlCommand cmdekle = new NpgsqlCommand("insert into kredikartı(musteri_no,kart_no,sonkullanmatarihi,cvv,toplamlimit,kullanılan) values ('" + txt_musterino.Text + "','" + kartNoUret() + "','" + txt_sonkullanmatarihi.Text + "','" + txt_cvv.Text + "','" + txt_toplamlimit.Text + "','" + txt_kullanilan.Text + "')", t.getBaglanti());
                    cmdekle.ExecuteNonQuery();
                    MessageBox.Show("Kart Eklendi");
                    txt_musterino.Text = "";
                    txt_kartno.Text = "";
                    txt_cvv.Text = "";
                    txt_toplamlimit.Text = "";
                    txt_kullanilan.Text = "";
                    txt_sonkullanmatarihi.Text = "";
                    KrediKartı_Load(sender, e);

                }

                else
                {
                    MessageBox.Show("EKSİK BİLGİ GİRDİNİZ");
                }

            }
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
                        NpgsqlCommand cmdsil = new NpgsqlCommand("delete from kredikartı where musteri_no='" + txt_musterino.Text + "' and kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
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
            txt_sonkullanmatarihi.Text = "";
            txt_cvv.Text = "";
            txt_toplamlimit.Text = "";
            txt_kullanilan.Text = "";
            KrediKartı_Load(sender, e);
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {
            if (txt_toplamlimit.Text != "")
            {
                NpgsqlCommand cmdsave = new NpgsqlCommand("update kredikartı set toplamlimit='" + txt_toplamlimit.Text + "' where musteri_no='" + txt_musterino.Text + "'and kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
                cmdsave.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Tamamlandı");
            }
            else
            {
                MessageBox.Show("Kredi Kartı Limiti Girin");
            }
            txt_musterino.Text = "";
            txt_kartno.Text = "";
            txt_sonkullanmatarihi.Text = "";
            txt_cvv.Text = "";
            txt_toplamlimit.Text = "";
            KrediKartı_Load(sender, e);
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

        private void txt_sonkullanmatarihi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sonkullanmatarihi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_cvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_toplamlimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txt_kullanilan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}


