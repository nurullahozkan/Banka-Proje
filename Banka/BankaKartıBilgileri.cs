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
    public partial class BankaKartıBilgileri : Form
    {
        public BankaKartıBilgileri()
        {
            InitializeComponent();
        }

        Baglanti t;
        Hesap hesap;
        Form1 form1;
        public string kartNoUret()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select max(kart_no) from bankakartı", t.getBaglanti());
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
        public int bakiyeSorgu()
        {
            form1 = new Form1();
            t = new Baglanti();
            hesap = new Hesap();
            form1.txt_musterino.Text = txt_musterino.Text;
            hesap.txt_musterino.Text = txt_musterino.Text;
            hesap.txt_hesapno.Text = txt_hesapno.Text;
            if (hesap.hesapSayısıKontrol())
            {
                txt_hesapno.ReadOnly = true;
                txt_hesapno.Text = form1.hesapNoCek();
                NpgsqlCommand bakiyeSorgu = new NpgsqlCommand("select hesapbakiye from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                NpgsqlDataReader dr = bakiyeSorgu.ExecuteReader();
                dr.Read();
                int bakiye;
                bakiye = dr[0].GetHashCode();
                t.getBaglanti().Close();
                return bakiye;
            }
            else
            {
                if (txt_hesapno.Text != "")
                {
                    NpgsqlCommand bakiyeSorgu = new NpgsqlCommand("select hesapbakiye from hesap where musteri_no='" + txt_musterino.Text + "' and hesapno='" + txt_hesapno.Text + "'", t.getBaglanti());
                    NpgsqlDataReader dr = bakiyeSorgu.ExecuteReader();
                    dr.Read();
                    int bakiye;
                    bakiye = dr[0].GetHashCode();
                    t.getBaglanti().Close();
                    return bakiye;
                }
                else
                {
                    MessageBox.Show("Lütfen Hesap Numarası Giriniz");
                    btn_newkart.Visible = true;
                    txt_sonkullanmatarihi.ReadOnly = true;
                    txt_cvv.ReadOnly = true;
                    return 0;
                }  
            }
        }
        public string sonKullanmaTarihiUret()
        {
            Random skt = new Random();
            int sayi1 = skt.Next(10, 26);
            int sayi2 = skt.Next(10, 26);
            string ySKT;
            if (sayi1 > sayi2)
            {
                int tmp = sayi1;
                sayi1 = sayi2;
                sayi2 = tmp;
                ySKT = sayi1 + "/" + sayi2;
            }
            else
                ySKT = sayi1 + "/" + sayi2;
            return ySKT;
        }
        public int cvvUret()
        {
            Random cvv = new Random();
            int sayi = cvv.Next(100, 999);
            return sayi;
        }

      
        public void BankaKartıBilgileri_Load(object sender, EventArgs e)
        {
            t = new Baglanti();
            btn_save.Visible = false;
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from bankakartı", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            
            
            txt_sonkullanmatarihi.ReadOnly = true;
            txt_cvv.ReadOnly = true;
            txt_bakiye.ReadOnly = true;
        }


        private void btn_newkart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            btn_newkart.Visible = false;
            btn_ekle.Visible = true;

            form1.txt_musterino.Text = txt_musterino.Text;
            txt_hesapno.ReadOnly = false;
            txt_kartno.ReadOnly = false;
            txt_sonkullanmatarihi.ReadOnly = true;
            txt_cvv.ReadOnly = true;
            txt_bakiye.ReadOnly = true;
            
            if (txt_musterino.Text != "")
            {
                txt_bakiye.Text = bakiyeSorgu().ToString();

                if (form1.musteriNoKontrol())
                {
                    if (form1.hesapSayısıKontrol() == true)
                    {
                        txt_musterino.ReadOnly = true;
                        txt_hesapno.ReadOnly = true;
                        txt_kartno.ReadOnly = true;
                    }
                    else
                    {
                        txt_musterino.ReadOnly = true;
                        txt_hesapno.ReadOnly = false;
                        txt_kartno.ReadOnly = true;
                    }
                }
                else
                {
                    txt_hesapno.ReadOnly = true;
                    txt_kartno.ReadOnly = true;
                    txt_sonkullanmatarihi.ReadOnly = true;
                    txt_cvv.ReadOnly = true;
                    txt_bakiye.ReadOnly = true;
                    btn_newkart.Visible = true;
                }
                txt_sonkullanmatarihi.Text = sonKullanmaTarihiUret();
                txt_cvv.Text = cvvUret().ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Müşteri Numarası Giriniz");
                txt_hesapno.ReadOnly = true;
                txt_kartno.ReadOnly = true;
                txt_sonkullanmatarihi.ReadOnly = true;
                txt_cvv.ReadOnly = true;
                txt_bakiye.ReadOnly = true;
                btn_newkart.Visible = true;
            }


        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            t = new Baglanti();
            form1 = new Form1();
            form1.txt_musterino.Text = txt_musterino.Text;
            if (txt_musterino.Text != "" && txt_sonkullanmatarihi.Text != "" && txt_cvv.Text != "" && txt_bakiye.Text != "")
            {
                if (form1.musteriNoKontrol())
                {
                    if (form1.hesapSayısıKontrol() == true)
                    {
                        NpgsqlCommand cmdekle = new NpgsqlCommand("insert into bankakartı(musteri_no,hesapno,kart_no,sonkullanmatarihi,cvv,hesapbakiye) values ('" + txt_musterino.Text + "','" + form1.hesapNoCek() + "','" + kartNoUret() + "','" + txt_sonkullanmatarihi.Text + "','" + txt_cvv.Text + "','" + txt_bakiye.Text + "')", t.getBaglanti());
                        cmdekle.ExecuteNonQuery();
                        btn_ekle.Visible = false;
                        btn_newkart.Visible = true;
                        txt_musterino.ReadOnly = false;
                        txt_kartno.ReadOnly = false;
                        MessageBox.Show("Kart Eklendi");
                    }
                    else
                    {
                        if (txt_hesapno.Text != "")
                        {
                                NpgsqlCommand cmdekle = new NpgsqlCommand("insert into bankakartı(musteri_no,hesapno,kart_no,sonkullanmatarihi,cvv,hesapbakiye) values ('" + txt_musterino.Text + "','" + txt_hesapno.Text + "','" + kartNoUret() + "','" + txt_sonkullanmatarihi.Text + "','" + txt_cvv.Text + "','" + txt_bakiye.Text + "')", t.getBaglanti());
                                cmdekle.ExecuteNonQuery();
                                btn_ekle.Visible = false;
                                btn_newkart.Visible = true;
                                txt_musterino.ReadOnly = false;
                                txt_kartno.ReadOnly = false;
                                MessageBox.Show("Kart Eklendi");
                        }
                        else
                            MessageBox.Show("Kart Eklemek İstediğiniz Hesap Numarasını Giriniz");

                        btn_ekle.Visible = false;
                        btn_newkart.Visible = true;
                        txt_musterino.ReadOnly = false;
                    }

                }
            }
            else
            {
                MessageBox.Show("EKSİK BİLGİ GİRDİNİZ");
                btn_newkart.Visible = true;
                txt_musterino.ReadOnly = false;
            }

            txt_musterino.Text = "";
            txt_hesapno.Text = "";
            txt_kartno.Text = "";
            txt_sonkullanmatarihi.Text="";
            txt_cvv.Text = "";
            txt_bakiye.Text = "";
            BankaKartıBilgileri_Load(sender, e);
        }

        private void btn_sil_Click(object sender, EventArgs e)
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
                        NpgsqlCommand cmdsil = new NpgsqlCommand("delete from bankakartı where musteri_no='" + txt_musterino.Text + "' and kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
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
            txt_hesapno.Text = "";
            txt_kartno.Text = "";
            txt_sonkullanmatarihi.Text = "";
            txt_cvv.Text = "";
            txt_bakiye.Text = "";
            BankaKartıBilgileri_Load(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.txt_musterino.Text = txt_musterino.Text;

            btn_save.Visible = true;
            btn_update.Visible = false;

            txt_hesapno.ReadOnly = true;
            txt_sonkullanmatarihi.ReadOnly = true;
            txt_cvv.ReadOnly = true;
            txt_bakiye.ReadOnly = false;

            if (txt_musterino.Text == ""&& txt_kartno.Text=="")
            {
                MessageBox.Show("Müşteri ve Kart Numaralarını Giriniz");
                btn_save.Visible = false;
                btn_update.Visible = true;
                txt_bakiye.ReadOnly = true;
            }
            else
            {
                if (form1.musteriNoKontrol())
                {
                    btn_save.Visible = true;
                    btn_update.Visible = false;
                }
                else
                {
                    btn_save.Visible = false;
                    btn_update.Visible = true;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_update.Visible = true;

            if (txt_bakiye.Text != "")
            {
                NpgsqlCommand cmdsave = new NpgsqlCommand("update bankakartı set hesapbakiye='" + txt_bakiye.Text + "' where musteri_no='" + txt_musterino.Text + "'and kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
                cmdsave.ExecuteNonQuery();
                MessageBox.Show("Güncelleme Tamamlandı");
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Bakiye Miktarını Giriniz");
            }
            txt_musterino.Text = "";
            txt_hesapno.Text = "";
            txt_kartno.Text = "";
            txt_sonkullanmatarihi.Text = "";
            txt_cvv.Text = "";
            txt_bakiye.Text = "";
            BankaKartıBilgileri_Load(sender, e);
        }
    }
}
