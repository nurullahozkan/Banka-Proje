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
    public partial class MusteriPanel : Form
    {
        Baglanti t = new Baglanti();

        public MusteriPanel()
        {
            InitializeComponent();
        }

        public string faizOranıCek()
        {
            Baglanti t = new Baglanti();
            NpgsqlCommand faiz = new NpgsqlCommand("select faiz_oranı from banka", t.getBaglanti());
            NpgsqlDataReader dr = faiz.ExecuteReader();
            dr.Read();
            string sonFaiz;
            sonFaiz = dr[0].ToString();
            return sonFaiz;
        }

        public void MusteriPanel_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Güncel Faiz Oranı : "+faizOranıCek());

            btn_save.Visible = false;
            btn_update.Visible = true;

            txt_telno.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_adres.ReadOnly = true;
            txt_sifre.ReadOnly = true;
            txt_hesapno.ReadOnly = true;
            txt_iban.ReadOnly = true;
            txt_bakiye.ReadOnly = true;
            txt_tarih.ReadOnly = true;
            txt_kartno.ReadOnly = true;
            txt_sonkullanmatarihi.ReadOnly = true;
            txt_cvv.ReadOnly = true;
            txt_bankakartbakiye.ReadOnly = true;
            txt_faizoranı.ReadOnly = true;
            txt_kredikartno.ReadOnly = true;
            txt_krediskt.ReadOnly = true;
            txt_kredicvv.ReadOnly = true;
            txt_kreditoplamlimit.ReadOnly = true;
            txt_kullanılanlimit.ReadOnly = true;
            txt_faturakartno.ReadOnly = true;
            txt_donemborc.ReadOnly = true;
            txt_asgaritutar.ReadOnly = true;
            txt_sot.ReadOnly = true;

            txt_faizoranı.Text = faizOranıCek();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_save.Visible = true;
            btn_update.Visible = false;

            txt_telno.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_adres.ReadOnly = false;
            txt_sifre.ReadOnly = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_update.Visible = true;

            if (txt_telno.Text != "" || txt_email.Text != "" || txt_adres.Text != "" || txt_sifre.Text != "")
            {
                if (txt_telno.Text != "")
                {
                    NpgsqlCommand cmdsave = new NpgsqlCommand("update musteri set telno='" + txt_telno.Text + "' where musteri_no='" + lbl_müsterino.Text + "'", t.getBaglanti());
                    cmdsave.ExecuteNonQuery();
                }
                if (txt_email.Text != "")
                {
                    NpgsqlCommand cmdsave1 = new NpgsqlCommand("update musteri set email='" + txt_email.Text + "' where musteri_no='" + lbl_müsterino.Text + "'", t.getBaglanti());
                    cmdsave1.ExecuteNonQuery();
                }
                if (txt_adres.Text != "")
                {
                    NpgsqlCommand cmdsave2 = new NpgsqlCommand("update musteri set adres='" + txt_adres.Text + "' where musteri_no='" + lbl_müsterino.Text + "'", t.getBaglanti());
                    cmdsave2.ExecuteNonQuery();
                }
                if (txt_sifre.Text != "")
                {
                    NpgsqlCommand cmdsave3 = new NpgsqlCommand("update musteri set sifre='" + txt_sifre.Text + "' where musteri_no='" + lbl_müsterino.Text + "'", t.getBaglanti());
                    cmdsave3.ExecuteNonQuery();
                }
                MessageBox.Show("GÜNCELLEME BAŞARILI");
            }
            MusteriPanel_Load(sender, e);
        }

        private void txt_telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.txt_musterino_gonderen.Text = lbl_müsterino.Text;
            transfer.txt_musterino_gonderen.ReadOnly = true;
            transfer.Show();
        }
    }
}
