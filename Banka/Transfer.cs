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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        Baglanti t;

        public int he_id_uret()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand musterino = new NpgsqlCommand("select max(he_id) from havaleft", t.getBaglanti());
            NpgsqlDataReader dr = musterino.ExecuteReader();
            dr.Read();
            int sonNumara;
            sonNumara = dr[0].GetHashCode();
            sonNumara++;
            t.getBaglanti().Close();
            return sonNumara;
        }

        public string BakiyeCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select hesapbakiye from hesap where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = hesapno.ExecuteReader();
            dr.Read();
            String bakiye = dr[0].ToString();
            t.getBaglanti().Close();
            return bakiye;
        }

        public string HesapNoCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select hesapno from hesap where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = hesapno.ExecuteReader();
            dr.Read();
            String bakiye = dr[0].ToString();
            t.getBaglanti().Close();
            return bakiye;
        }

        public string AdCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select adi from musteri where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = hesapno.ExecuteReader();
            dr.Read();
            String bakiye = dr[0].ToString();
            t.getBaglanti().Close();
            return bakiye;
        }

        public string SoyAdCek(string musterino)
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand hesapno = new NpgsqlCommand("select soyadi from musteri where musteri_no='" + musterino + "'", t.getBaglanti());
            NpgsqlDataReader dr = hesapno.ExecuteReader();
            dr.Read();
            String bakiye = dr[0].ToString();
            t.getBaglanti().Close();
            return bakiye;
        }

        public void BakiyeUpdate(string musterino, string newbakiye)
        {
            NpgsqlCommand cmdsave = new NpgsqlCommand("update hesap set hesapbakiye='" + newbakiye + "' where musteri_no='" + musterino + "'", t.getBaglanti());
            cmdsave.ExecuteNonQuery();
        }

        public void AddHavaleEftTable(string aliciadi, string alicihesapno, string gondericimusno, string gondericihesapno, string miktar)
        {
            NpgsqlCommand cmdekle = new NpgsqlCommand("insert into havaleft(he_id,alici_adi,alici_hesapno,goncerici_musterino,gonderici_hesapno,miktar) values ('" + he_id_uret().ToString() + "','" + aliciadi + "','" + alicihesapno + "','" + gondericimusno + "','" + gondericihesapno + "','" + miktar + "')", t.getBaglanti());
            cmdekle.ExecuteNonQuery();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            t = new Baglanti();


            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from havaleft", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            //dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gondericibakiye = Convert.ToInt32(BakiyeCek(txt_musterino_gonderen.Text));
            int alicibakiye = Convert.ToInt32(BakiyeCek(txt_musterino_alan.Text));
            int miktar = Convert.ToInt32(txtmiktar.Text);
            MusteriPanel musteriPanel = new MusteriPanel();


            if (gondericibakiye >= miktar)
            {
                BakiyeUpdate(txt_musterino_gonderen.Text, (gondericibakiye - miktar).ToString());
                BakiyeUpdate(txt_musterino_alan.Text, (alicibakiye + miktar).ToString());
                AddHavaleEftTable(AdCek(txt_musterino_alan.Text) + " " + SoyAdCek(txt_musterino_alan.Text), HesapNoCek(txt_musterino_alan.Text), txt_musterino_gonderen.Text, HesapNoCek(txt_musterino_gonderen.Text), txtmiktar.Text);
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye");
            }

                Transfer_Load(sender, e);
                
                musteriPanel.MusteriPanel_Load(sender, e);
                musteriPanel.ShowDialog();
            }
    }
}
