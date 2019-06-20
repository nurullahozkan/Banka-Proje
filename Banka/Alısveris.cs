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
    public partial class Alısveris : Form
    {
        public Alısveris()
        {
            InitializeComponent();
        }

        Baglanti t;

        public bool idKontrol()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand mnBilgi = new NpgsqlCommand("Select * from alısveris where av_id='" + txt_av_id.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = mnBilgi.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Böyle Bir ID Bulunmamaktadır");
                t.getBaglanti().Close();
                return false;
            }
        }
        public void bakiyeGuncelle()
        {
            t.getBaglanti().Close();
            t = new Baglanti();
            NpgsqlCommand kartBakiyeGuncelle = new NpgsqlCommand("update bankakartı set hesapbakiye=hesapbakiye - '" + Convert.ToInt32(txt_urunfiyati.Text) + "' where kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
            kartBakiyeGuncelle.ExecuteNonQuery();
            NpgsqlCommand hesapBakiyeGuncelle = new NpgsqlCommand(" update hesap set hesapbakiye=hesapbakiye - '" + Convert.ToInt32(txt_urunfiyati.Text) + "' where hesapno=(select hesapno from bankakartı where kart_no='" + txt_kartno.Text + "')", t.getBaglanti());
            hesapBakiyeGuncelle.ExecuteNonQuery();
        }
        public bool bakiyeKontrol()
        {
            NpgsqlCommand bakiyeKontrol = new NpgsqlCommand("Select hesapbakiye from bankakartı where kart_no='" + txt_kartno.Text + "' ", t.getBaglanti());
            NpgsqlDataReader dr = bakiyeKontrol.ExecuteReader();
            dr.Read();
            int hesapbakiye = dr[0].GetHashCode();
            int alısverisbakiye = Convert.ToInt32(txt_urunfiyati.Text);
            if (hesapbakiye >= alısverisbakiye)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string cvvCek()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand cvv = new NpgsqlCommand("select cvv from bankakartı where kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = cvv.ExecuteReader();
            dr.Read();
            String sonCVV = dr[0].ToString();
            return sonCVV;
        }
        public string bankaKartSKTCek()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand skt = new NpgsqlCommand("select sonkullanmatarihi from bankakartı where kart_no='" + txt_kartno.Text + "'", t.getBaglanti());
            NpgsqlDataReader dr = skt.ExecuteReader();
            dr.Read();
            String sonSKT = dr[0].ToString();
            return sonSKT;
        }

        public void Alısveris_Load(object sender, EventArgs e)
        {
            t = new Baglanti();
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from alısveris", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            txt_av_id.ReadOnly = true;
            txt_urunkodu.ReadOnly = false;
            txt_urunadi.ReadOnly = false;
            txt_urunfiyati.ReadOnly = false;
            txt_kartno.ReadOnly = false;
            txt_sktarihi.ReadOnly = false;
            txt_cvv.ReadOnly = false;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Baglanti t = new Baglanti();
            t.getBaglanti();
            if (txt_urunkodu.Text != "" && txt_urunadi.Text != "" && txt_urunfiyati.Text != "" && txt_kartno.Text != "" && txt_sktarihi.Text != "" && txt_cvv.Text != "")
            {
                if (bakiyeKontrol() == true)
                {
                    if (cvvCek() == txt_cvv.Text && bankaKartSKTCek()==txt_sktarihi.Text)
                    {
                        NpgsqlCommand cmdekle = new NpgsqlCommand("insert into alısveris(urunkodu,urunadi,urunfiyati,kart_no,sonkullanmatarihi,cvv) values ('" + txt_urunkodu.Text + "','" + txt_urunadi.Text + "','" + txt_urunfiyati.Text + "','" + txt_kartno.Text + "','" + txt_sktarihi.Text + "','" + txt_cvv.Text + "')", t.getBaglanti());
                        cmdekle.ExecuteNonQuery();
                        MessageBox.Show("Alışveriş Bilgisi Eklendi");
                        bakiyeGuncelle();
                    }
                    else
                        MessageBox.Show("Girilen CVV veya Son Kullanma Tarihi Hatalı");
                }
                else
                    MessageBox.Show("Yetersiz Bakiye");
            }
            else
            {
                MessageBox.Show("EKSİK BİLGİ GİRDİNİZ");
            }

            txt_urunkodu.Text = "";
            txt_urunadi.Text = "";
            txt_urunfiyati.Text = "";
            txt_kartno.Text = "";
            txt_sktarihi.Text = "";
            txt_cvv.Text = "";
            Alısveris_Load(sender, e);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            txt_av_id.ReadOnly = false;
            txt_urunkodu.ReadOnly = true;
            txt_urunadi.ReadOnly = true;
            txt_urunfiyati.ReadOnly = true;
            txt_kartno.ReadOnly = true;
            txt_sktarihi.ReadOnly = true;
            txt_cvv.ReadOnly = true;
            if (txt_av_id.Text == "")
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Alışveriş ID'sini Giriniz");
            }
            else
            {
                if (!idKontrol())
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Alışveriş ID'sini Giriniz");
                }
                else
                {
                    NpgsqlCommand cmdsil = new NpgsqlCommand("delete from alısveris where av_id='" + txt_av_id.Text + "'", t.getBaglanti());
                    cmdsil.ExecuteNonQuery();
                    MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
                    Alısveris_Load(sender, e);
                }                
            }
            txt_av_id.Text = "";
            txt_urunkodu.Text = "";
            txt_urunadi.Text = "";
            txt_urunfiyati.Text = "";
            txt_kartno.Text = "";
            txt_sktarihi.Text = "";
            txt_cvv.Text = "";
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if (txt_av_id.Text == "")
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Alışveriş ID'sini Giriniz");
            }
            else
            {
                NpgsqlCommand alısveris = new NpgsqlCommand("Select * from alısveris where av_id='" + txt_av_id.Text + "'", t.getBaglanti());
                NpgsqlDataReader dr = alısveris.ExecuteReader();
                dr.Read();
                int fiyat = dr[3].GetHashCode();
                t.getBaglanti().Close();
                t = new Baglanti();
                NpgsqlCommand kartBakiyeGuncelle = new NpgsqlCommand("update bankakartı set hesapbakiye=hesapbakiye + '" + fiyat + "' where kart_no=(select kart_no from alısveris where av_id='" + txt_av_id.Text + "')", t.getBaglanti());
                kartBakiyeGuncelle.ExecuteNonQuery();
                NpgsqlCommand hesapBakiyeGuncelle = new NpgsqlCommand(" update hesap set hesapbakiye=hesapbakiye + '" + fiyat + "' where hesapno=(select hesapno from bankakartı where kart_no=(select kart_no from alısveris where av_id='" + txt_av_id.Text + "'))", t.getBaglanti());
                hesapBakiyeGuncelle.ExecuteNonQuery();
                btn_sil_Click(sender, e);
            }           
        }

        private void txt_urunfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_kartno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
       
        private void txt_kartno_Enter(object sender, EventArgs e)
        {
        }
    }
}
