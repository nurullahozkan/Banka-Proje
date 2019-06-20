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
    public partial class Login : Form,Fonksiyonlar
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool tcnoKontrol()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand tcBilgi = new NpgsqlCommand("Select * from musteri where tcno='" + txt_tcno.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = tcBilgi.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else
            {
                if (txt_tcno.Text == "Admin" && txt_sifre.Text == "12345" || txt_tcno.Text == "Admin2" && txt_sifre.Text == "1")
                {
                    YöneticiPanel yöneticiPanel = new YöneticiPanel();
                    yöneticiPanel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
                    t.getBaglanti().Close();
                    return false;
                }
                return false;
            }
        }

        public bool sifreKontrol()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand tcBilgi = new NpgsqlCommand("Select sifre from musteri where tcno='" + txt_tcno.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = tcBilgi.ExecuteReader();
            dr.Read();
            string sifre = dr[0].ToString();
            if (sifre == txt_sifre.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Girilen Şifre Yanlış");
                return false;
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (tcnoKontrol() == true)
            {
                if (sifreKontrol() == true)
                {
                    Form1 form1 = new Form1();
                    MusteriPanel musteriPanel = new MusteriPanel();
                    musteriPanel.MusteriPanel_Load(sender, e);
                    musteriPanel.lbl_isim.Text = AdCek(txt_tcno.Text); // Müşteri Bilgileri Kısmı
                    musteriPanel.lbl_müsterino.Text = MusteriNoCek(txt_tcno.Text);
                    musteriPanel.txt_telno.Text = telNoCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_email.Text = emailCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_adres.Text = adresCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_sifre.Text = sifreCek(musteriPanel.lbl_müsterino.Text);

                    form1.txt_musterino.Text = musteriPanel.lbl_müsterino.Text; // Hesap Bilgileri Kısmı
                    musteriPanel.txt_hesapno.Text = form1.hesapNoCek();
                    musteriPanel.txt_iban.Text = form1.ibanNoCek();
                    musteriPanel.txt_bakiye.Text = form1.bakiyeCek();
                    musteriPanel.txt_tarih.Text = form1.hesapAcımTarihiCek();

                    musteriPanel.txt_kartno.Text = bankaKartNoCek(musteriPanel.lbl_müsterino.Text);// Banka Kartı Bilgileri
                    musteriPanel.txt_sonkullanmatarihi.Text = bankaKartSKTCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_cvv.Text = cvvCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_bankakartbakiye.Text =bakiyeCek(musteriPanel.lbl_müsterino.Text);

                    musteriPanel.txt_kredikartno.Text = krediKartNoCek(musteriPanel.lbl_müsterino.Text);// Kredi Kartı Bilgileri
                    musteriPanel.txt_krediskt.Text = krediKartSKTCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_kredicvv.Text = kredicvvCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_kreditoplamlimit.Text = krediToplamLimit(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_kullanılanlimit.Text = krediKullanılanLimit(musteriPanel.lbl_müsterino.Text);

                    musteriPanel.txt_faturakartno.Text = krediKartNoCek(musteriPanel.lbl_müsterino.Text);//Fatura Bilgileri
                    musteriPanel.txt_donemborc.Text = donemBorcuCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_asgaritutar.Text = asgariTutarCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.txt_sot.Text = sonOdemeTarihiCek(musteriPanel.lbl_müsterino.Text);

                    musteriPanel.lbl_mesaj.Text = mesajCek(musteriPanel.lbl_müsterino.Text);
                    musteriPanel.ShowDialog();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public string AdCek(string tcno)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand ad = new NpgsqlCommand("select adi from musteri where tcno='" + tcno + "'", t.getBaglanti());
            NpgsqlDataReader dr = ad.ExecuteReader();
            dr.Read();
            String isim = dr[0].ToString() + ";";
            t.getBaglanti().Close();
            return isim;
        }

        public string MusteriNoCek(string tcno)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand ad = new NpgsqlCommand("select musteri_no from musteri where tcno='" + tcno + "'", t.getBaglanti());
            NpgsqlDataReader dr = ad.ExecuteReader();
            dr.Read();
            String musterino = dr[0].ToString();
            t.getBaglanti().Close();
            return musterino;
        }

        public string telNoCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand tel = new NpgsqlCommand("select telno from musteri where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = tel.ExecuteReader();
            dr.Read();
            String sonTelNo = dr[0].ToString();
            return sonTelNo;
        }

        public string emailCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand email = new NpgsqlCommand("select email from musteri where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = email.ExecuteReader();
            dr.Read();
            String sonEmail = dr[0].ToString();
            return sonEmail;
        }

        public string adresCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand adres = new NpgsqlCommand("select adres from musteri where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = adres.ExecuteReader();
            dr.Read();
            String sonAdres = dr[0].ToString();
            return sonAdres;
        }

        public string sifreCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand sifre = new NpgsqlCommand("select sifre from musteri where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = sifre.ExecuteReader();
            dr.Read();
            String sonSifre = dr[0].ToString();
            return sonSifre;
        }

        public string bankaKartNoCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand kartno = new NpgsqlCommand("select kart_no from bankakartı where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = kartno.ExecuteReader();
            dr.Read();
            String sonkartno = dr[0].ToString();
            return sonkartno;
        }

        public string bankaKartSKTCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand skt = new NpgsqlCommand("select sonkullanmatarihi from bankakartı where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = skt.ExecuteReader();
            dr.Read();
            String sonSKT = dr[0].ToString();
            return sonSKT;
        }

        public string cvvCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand cvv = new NpgsqlCommand("select cvv from bankakartı where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = cvv.ExecuteReader();
            dr.Read();
            String sonCVV = dr[0].ToString();
            return sonCVV;
        }

        public string bakiyeCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select hesapbakiye from bankakartı where kart_no='" + bankaKartNoCek(musterino) + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }
        
        public string krediKartNoCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand kartno = new NpgsqlCommand("select kart_no from kredikartı where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = kartno.ExecuteReader();
            dr.Read();
            String sonkartno = dr[0].ToString();
            return sonkartno;
        }

        public string krediKartSKTCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand skt = new NpgsqlCommand("select sonkullanmatarihi from kredikartı where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = skt.ExecuteReader();
            dr.Read();
            String sonSKT = dr[0].ToString();
            return sonSKT;
        }

        public string kredicvvCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand cvv = new NpgsqlCommand("select cvv from kredikartı where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = cvv.ExecuteReader();
            dr.Read();
            String sonCVV = dr[0].ToString();
            return sonCVV;
        }

        public string krediToplamLimit(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select toplamlimit from kredikartı where kart_no='" + krediKartNoCek(musterino) + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }

        public string krediKullanılanLimit(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select kullanılan from kredikartı where kart_no='" + krediKartNoCek(musterino) + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }

        public string donemBorcuCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select donemborcu from fatura where kart_no='" + krediKartNoCek(musterino) + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }

        public string asgariTutarCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select asgaritutar from fatura where kart_no='" + krediKartNoCek(musterino) + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }

        public string sonOdemeTarihiCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select sonodemetarihi from fatura where kart_no='" + krediKartNoCek(musterino) + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }

        public string mesajCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand bakiye = new NpgsqlCommand("select mesaj from musteri where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = bakiye.ExecuteReader();
            dr.Read();
            String sonBakiye = dr[0].ToString();
            return sonBakiye;
        }
    }
}
