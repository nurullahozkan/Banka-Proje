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
    public partial class Hesap : Form
    {
        Baglanti t = new Baglanti();

        public Hesap()
        {
            InitializeComponent();
        }

        public string hesapNoUret()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select max(hesapno) from hesap", t.getBaglanti());
            NpgsqlDataReader dr = hesapno.ExecuteReader();
            dr.Read();
            string sonHesapno;
            sonHesapno = dr[0].ToString();
            char[] dizi = sonHesapno.ToCharArray();
            if (dizi[14] == '9')
            {
                dizi[14] = '0';
                if (dizi[13] == '9')
                {
                    dizi[13] = '0';
                    if (dizi[12] == '9')
                    {
                        dizi[12] = '0';
                        if (dizi[11] == '9')
                        {
                            dizi[11] = '0';
                            dizi[10]++;
                        }
                        else
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

            string k = new string(dizi);
            t.getBaglanti().Close();
            return k;
        }
        public string ibanUret()
        {
            String iban = "TR000001500" + hesapNoUret();
            return iban;
        }
        public bool musteriNoKontrol()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hbilgi = new NpgsqlCommand("Select * from musteri where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = hbilgi.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Böyle Bir Müşteri Numarası Bulunmamaktadır");
                t.getBaglanti().Close();
                return false;
            }

        }
        public bool hesapSayısıKontrol()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand mnBilgi = new NpgsqlCommand("select count(hesapno) from hesap where musteri_no ='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = mnBilgi.ExecuteReader();
            dr.Read();
            if (dr[0].ToString() == "1")
            {
                return true;
            }
            else
                return false;

        }


        public void btn_ekle_Click(object sender, EventArgs e)
        {


            if (musteriNoKontrol())
            {
                if (txt_bakiye.Text != "")
                {
                    Baglanti t = new Baglanti();
                    NpgsqlCommand cmdekle = new NpgsqlCommand("insert into hesap(musteri_no,hesapno,iban,hesapbakiye,hesapacımtarihi) values ('" + txt_musterino.Text + "','" + hesapNoUret() + "','" + ibanUret() + "','" + txt_bakiye.Text + "','" + txt_tarih.Text + "')", t.getBaglanti());
                    cmdekle.ExecuteNonQuery();
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                }
                else
                    MessageBox.Show("EKSİK BİLGİ GİRDİNİZ");
            }
            txt_hesapno.Text = "";
            txt_iban.Text = "";
            txt_bakiye.Text = "";
            txt_tarih.Text = "";
            Hesap_Load(sender, e);
        }

        public void Hesap_Load(object sender, EventArgs e)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            btn_save.Visible = false;
            txt_tarih.ReadOnly = true;
            txt_tarih.Text = DateTime.Now.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (musteriNoKontrol())
            {
                if (txt_musterino.Text == "")
                {
                    MessageBox.Show("Müşteri Numarası Giriniz");
                }
                else
                {
                    Form1 form1 = new Form1();
                    form1.txt_musterino.Text = txt_musterino.Text;
                    if (form1.hesapSayısıKontrol() == true)
                    {
                        Baglanti t = new Baglanti();
                        NpgsqlCommand cmdsil = new NpgsqlCommand("delete from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                        cmdsil.ExecuteNonQuery();
                        MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
                    }
                    else
                    {
                        if (txt_hesapno.Text != "")
                        {
                            Baglanti t = new Baglanti();
                            NpgsqlCommand cmdsil = new NpgsqlCommand("delete from hesap where hesapno='" + txt_hesapno.Text + "'", t.getBaglanti());
                            cmdsil.ExecuteNonQuery();
                            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
                        }
                        else
                            MessageBox.Show("Lütfen Kullanıcıya Ait Silmek İstediğiniz Hesabın Numarasını Giriniz");
                    }
                }
            }
            txt_hesapno.Text = "";
            txt_iban.Text = "";
            txt_bakiye.Text = "";
            txt_tarih.Text = "";
            Hesap_Load(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Visible = true;
            btn_update.Visible = false;

            txt_tarih.ReadOnly = true;
            if (txt_musterino.Text == "")
            {
                MessageBox.Show("Müşteri Numarası Giriniz");
                btn_save.Visible = false;
                btn_update.Visible = true;
            }
            else
            {
                Form1 form1 = new Form1();
                form1.txt_musterino.Text = txt_musterino.Text;
                if (form1.hesapSayısıKontrol() != true)
                {
                    if (txt_hesapno.Text == "")
                    {
                        MessageBox.Show("Lütfen Hesap Numarasını Giriniz");
                        btn_save.Visible = false;
                        btn_update.Visible = true;

                    }
                    else
                    {
                        btn_save.Visible = true;
                        btn_update.Visible = false;
                    }
                }
                else
                {
                    txt_hesapno.ReadOnly = true;
                    txt_iban.ReadOnly = true;
                    txt_hesapno.Text = form1.hesapNoCek();
                    txt_iban.Text = form1.ibanNoCek();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            btn_update.Visible = true;
            txt_musterino.ReadOnly = true;
            txt_hesapno.ReadOnly = false;
            txt_iban.ReadOnly = false;
            txt_tarih.ReadOnly = false;

            form1.txt_musterino.Text = txt_musterino.Text;
            if (musteriNoKontrol())
            {
                if (form1.hesapSayısıKontrol() == true)
                {
                    if (txt_bakiye.Text != "")
                    {
                        NpgsqlCommand cmdsave = new NpgsqlCommand("update hesap set hesapbakiye='" + txt_bakiye.Text + "' where hesapno='" + txt_hesapno.Text + "'", t.getBaglanti());
                        cmdsave.ExecuteNonQuery();
                        MessageBox.Show("GÜNCELLEME BAŞARILI");
                        txt_hesapno.ReadOnly = true;
                        txt_iban.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ BİLGİLERİ GİRİNİZ");
                    }
                }
                else
                {
                    if (txt_bakiye.Text != "")
                    {
                        NpgsqlCommand cmdsave = new NpgsqlCommand("update hesap set hesapbakiye='" + txt_bakiye.Text + "' where hesapno='" + txt_hesapno.Text + "'", t.getBaglanti());
                        cmdsave.ExecuteNonQuery();
                        MessageBox.Show("GÜNCELLEME BAŞARILI");
                    }
                    else
                    {
                        MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ BİLGİLERİ GİRİNİZ");
                    }
                }
            }
            txt_hesapno.Text = "";
            txt_iban.Text = "";
            txt_bakiye.Text = "";
            txt_tarih.Text = "";
            Hesap_Load(sender, e);
        }

        private void txt_bakiye_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_bakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
