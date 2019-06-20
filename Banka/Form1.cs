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
    public partial class Form1 : Form,subject
    {

        Baglanti t;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            t = new Baglanti();
            btn_save.Visible = false;
            btn_ekle.Visible = false;

            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from musteri", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            txt_musterino.ReadOnly = false;
            txt_tcno.ReadOnly = true;
            txt_ad.ReadOnly=true;
            txt_soyad.ReadOnly=true;
            txt_telno.ReadOnly=true;
            txt_email.ReadOnly=true;
            txt_adres.ReadOnly=true;
            txt_sifre.ReadOnly=true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        public int musterinoUret()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand musterino = new NpgsqlCommand("select max(musteri_no) from musteri", t.getBaglanti());
            NpgsqlDataReader dr = musterino.ExecuteReader();
            dr.Read();
            int sonNumara;
            sonNumara = dr[0].GetHashCode();
            sonNumara++;
            t.getBaglanti().Close();
            return sonNumara;
        }

        public string hesapNoCek()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select hesapno from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = hesapno.ExecuteReader();
            dr.Read();
            if (dr.HasRows==false)
            {
                MessageBox.Show("Bu Müşteri Numarasına Tanımlı Hesap Bulunamamaktadır");
                return null;
            }
            else
            {
                string sonHesapNo = dr[0].ToString();
                t.getBaglanti().Close();
                return sonHesapNo;
            }    
        }

        public string ibanNoCek()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand iban = new NpgsqlCommand("select iban from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = iban.ExecuteReader();
            dr.Read();
            String sonIban = dr[0].ToString();
            return sonIban;
        }

        public string bakiyeCek()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select hesapbakiye from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }

        public string hesapAcımTarihiCek()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand tarih = new NpgsqlCommand("select hesapacımtarihi from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = tarih.ExecuteReader();
            dr.Read();
            String sonTarih = dr[0].ToString();
            return sonTarih;
        }

        public bool musteriNoKontrol()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand mnBilgi = new NpgsqlCommand("Select * from musteri where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = mnBilgi.ExecuteReader();

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


        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            
            Baglanti t = new Baglanti();
            t.getBaglanti();
            if (txt_tcno.Text != "" && txt_ad.Text!= "" && txt_soyad.Text!="" && txt_telno.Text!="" && txt_email.Text!="" && txt_adres.Text!="" && txt_sifre.Text!="")
            {
                
                NpgsqlCommand cmdekle = new NpgsqlCommand("insert into musteri(musteri_no,tcno,adi,soyadi,telno,email,adres,sifre) values ('" + txt_musterino.Text + "','" + txt_tcno.Text + "','" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_telno.Text + "','" + txt_email.Text + "','" + txt_adres.Text + "','" + txt_sifre.Text + "')", t.getBaglanti());
                cmdekle.ExecuteNonQuery();
                Hesap hesap = new Hesap();
                hesap.txt_musterino.Text = txt_musterino.Text;
                hesap.txt_hesapno.Text = hesap.hesapNoUret();
                hesap.txt_iban.Text = hesap.ibanUret();
                hesap.txt_iban.ReadOnly = true;
                hesap.txt_hesapno.ReadOnly = true;
                hesap.txt_musterino.ReadOnly = true;
                hesap.ShowDialog();
                btn_yenimusteri.Visible = true;
            }
            else
            {
                MessageBox.Show("EKSİK BİLGİ GİRDİNİZ");
                btn_yenimusteri.Visible = true;
            }
                

            txt_musterino.Text = "";
            txt_tcno.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_telno.Text = "";
            txt_email.Text = "";
            txt_adres.Text = "";
            txt_sifre.Text = "";
            Form1_Load(sender, e);
        }
        
        private void btn_sil_Click(object sender, EventArgs e)
        {
            
            if(txt_musterino.Text != "")
            {
                if (!musteriNoKontrol())
                {
                    MessageBox.Show("Müşteri Numarası Giriniz");
                }
                else
                {
                    NpgsqlCommand cmdsil = new NpgsqlCommand("delete from musteri where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                    cmdsil.ExecuteNonQuery();
                    MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
                }
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Müşteri Numarasını Giriniz");
            }
            txt_musterino.Text = "";
            txt_tcno.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_telno.Text = "";
            txt_email.Text = "";
            txt_adres.Text = "";
            txt_sifre.Text = "";
            Form1_Load(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Visible = true;
            btn_update.Visible = false;
            
            txt_tcno.ReadOnly=true;
            txt_ad.ReadOnly = true;
            txt_soyad.ReadOnly = true;
            txt_telno.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_adres.ReadOnly = false;
            txt_sifre.ReadOnly = false;
            
            if (txt_musterino.Text == "")
            {
               MessageBox.Show("Müşteri Numarası Giriniz");
                btn_save.Visible = false;
                btn_update.Visible = true;
                txt_telno.ReadOnly = true;
                txt_email.ReadOnly = true;
                txt_adres.ReadOnly = true;
                txt_sifre.ReadOnly = true;
            }
            
            else
            {
                if (musteriNoKontrol())
                {
                    btn_save.Visible = true;
                    btn_update.Visible = false;
                    txt_telno.ReadOnly = false;
                    txt_email.ReadOnly = false;
                    txt_adres.ReadOnly = false;
                    txt_sifre.ReadOnly = false;
                }
                else
                {
                    btn_save.Visible = false;
                    btn_update.Visible = true;
                    txt_telno.ReadOnly = true;
                    txt_email.ReadOnly = true;
                    txt_adres.ReadOnly = true;
                    txt_sifre.ReadOnly = true;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_update.Visible = true;
            txt_tcno.ReadOnly = false;
            txt_ad.ReadOnly = false;
            txt_soyad.ReadOnly = false;

            if(txt_musterino.Text == "")
            {
                MessageBox.Show("Müşteri Numarası Giriniz");
            }
            else
            {
                if (musteriNoKontrol())
                {
                    if (txt_telno.Text != "" || txt_email.Text != "" || txt_adres.Text != "" || txt_sifre.Text != "")
                    {
                        if (txt_telno.Text != "")
                        {
                            NpgsqlCommand cmdsave = new NpgsqlCommand("update musteri set telno='" + txt_telno.Text + "' where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                            cmdsave.ExecuteNonQuery();
                        }
                        if (txt_email.Text != "")
                        {
                            NpgsqlCommand cmdsave1 = new NpgsqlCommand("update musteri set email='" + txt_email.Text + "' where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                            cmdsave1.ExecuteNonQuery();
                        }
                        if (txt_adres.Text != "")
                        {
                            NpgsqlCommand cmdsave2 = new NpgsqlCommand("update musteri set adres='" + txt_adres.Text + "' where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                            cmdsave2.ExecuteNonQuery();
                        }
                        if (txt_sifre.Text != "")
                        {
                            NpgsqlCommand cmdsave3 = new NpgsqlCommand("update musteri set sifre='" + txt_sifre.Text + "' where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                            cmdsave3.ExecuteNonQuery();
                        }
                        MessageBox.Show("GÜNCELLEME BAŞARILI");
                    }
                    else
                    {
                        MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ BİLGİLERİ GİRİNİZ");
                    }
                }
            }
            txt_musterino.Text = "";
            txt_tcno.Text = "";
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_telno.Text = "";
            txt_email.Text = "";
            txt_adres.Text = "";
            txt_sifre.Text = "";
            Form1_Load(sender, e);
        }
        
        public void button1_Click(object sender, EventArgs e)// hesap bilgisi butonu
        {
            Baglanti t = new Baglanti();
            if (txt_musterino.Text == "")
            {
                MessageBox.Show("Lütfen Hesap Bilgilerini Görmek İstediğiniz Müşteri Numarasını Giriniz");
            }
            else 
            {
             
                Hesap hesap = new Hesap();

                if(musteriNoKontrol())
                {
                    if (hesapNoCek() != null)
                    {
                        hesap.txt_musterino.Text = txt_musterino.Text;
                        hesap.txt_musterino.ReadOnly = true;
                        if (hesapSayısıKontrol() == true)
                        {
                            hesap.txt_hesapno.ReadOnly = true;
                            hesap.txt_iban.ReadOnly = true;
                            hesap.txt_hesapno.Text = hesapNoCek();
                            hesap.txt_iban.Text = ibanNoCek();
                            hesap.btn_ekle.Visible = false;
                            hesap.ShowDialog();
                        }
                        else
                        {
                            hesap.txt_hesapno.ReadOnly = false;
                            hesap.txt_iban.ReadOnly = false;
                            hesap.txt_hesapno.Text = "";
                            hesap.txt_iban.Text = "";
                            hesap.btn_ekle.Visible = false;
                            hesap.ShowDialog();
                        }
                        
                    }   
                }
            }
            
        }

        private void musno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_yenimusteri_Click(object sender, EventArgs e)
        {
            btn_yenimusteri.Visible = false;
            btn_ekle.Visible = true;

            txt_musterino.ReadOnly = true;
            txt_tcno.ReadOnly = false;
            txt_ad.ReadOnly = false;
            txt_soyad.ReadOnly = false;
            txt_telno.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_adres.ReadOnly = false;
            txt_sifre.ReadOnly = false;

            txt_musterino.Text = musterinoUret().ToString();
        }

        private void txt_tcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txt_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txt_telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public void bildirim()
        {
            string msj = "BankMNS'nin".Replace("'", "''") + " bu ay ki faiz oranları güncellenmiştir .  ";
            NpgsqlCommand b = new NpgsqlCommand("update musteri set mesaj = '" + msj + "'", t.getBaglanti());
            b.ExecuteNonQuery();
        }
    }
}
