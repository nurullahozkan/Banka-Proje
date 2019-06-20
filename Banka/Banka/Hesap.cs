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
        Baglanti t= new Baglanti();

        public Hesap()
        {
            InitializeComponent();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
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
                if(dizi[13]=='9')
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
            String iban = "TR000001500"+hesapNoUret();
            return iban;
        }
        public void btn_ekle_Click(object sender, EventArgs e)
        {
           
            Baglanti t = new Baglanti();
            if (txt_bakiye.Text != "")
            {
                NpgsqlCommand cmdekle = new NpgsqlCommand("insert into hesap(musteri_no,hesapno,iban,hesapbakiye,hesapacımtarihi) values ('" + txt_musterino.Text + "','" + hesapNoUret() + "','" + ibanUret() + "','" + txt_bakiye.Text + "','" +txt_tarih.Text  + "')", t.getBaglanti());
                cmdekle.ExecuteNonQuery();
                MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
            }
            else
               MessageBox.Show("EKSİK BİLGİ GİRDİNİZ");

            txt_musterino.Text = "";
            txt_hesapno.Text = "";
            txt_iban.Text = "";
            txt_bakiye.Text = "";
            txt_tarih.Text = "";
            Hesap_Load(sender, e);
        }

        public void Hesap_Load(object sender, EventArgs e)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from hesap", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            btn_save.Visible = false;
            txt_iban.ReadOnly = true;
            txt_hesapno.ReadOnly = true;
            txt_tarih.ReadOnly = true;
            txt_tarih.Text = DateTime.Now.ToString();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_musterino.Text == "")
            {
                MessageBox.Show("Müşteri Numarası Giriniz");
            }
            else
            {
                Baglanti t = new Baglanti();
                NpgsqlCommand cmdsil = new NpgsqlCommand("delete from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                cmdsil.ExecuteNonQuery();
                MessageBox.Show("SİLME İŞLEMİ BAŞARILI");
            }
            txt_musterino.Text = "";
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

            
            txt_hesapno.ReadOnly = true;
            txt_iban.ReadOnly = true;
            txt_tarih.ReadOnly = true;

            if (txt_musterino.Text == "")
            {
                MessageBox.Show("Müşteri Numarası Giriniz");
            }
            else
            {
                NpgsqlCommand cmdupdate = new NpgsqlCommand("Select * from hesap where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                NpgsqlDataReader dr = cmdupdate.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_update.Visible = true;
            txt_musterino.ReadOnly = false;
            txt_hesapno.ReadOnly = false;
            txt_iban.ReadOnly = false;
            txt_tarih.ReadOnly = false;


            if (txt_bakiye.Text != "")
            {
               
                    NpgsqlCommand cmdsave = new NpgsqlCommand("update hesap set hesapbakiye='" + txt_bakiye.Text + "' where musteri_no='" + txt_musterino.Text + "'", t.getBaglanti());
                    cmdsave.ExecuteNonQuery();
                
                MessageBox.Show("GÜNCELLEME BAŞARILI");
            }
            else
            {
                MessageBox.Show("GÜNCELLEMEK İSTEDİĞİNİZ BİLGİLERİ GİRİNİZ");
            }

            txt_musterino.Text = "";
            txt_hesapno.Text = "";
            txt_iban.Text = "";
            txt_bakiye.Text = "";
            txt_tarih.Text = "";
            Hesap_Load(sender, e);
        }
    }
}
