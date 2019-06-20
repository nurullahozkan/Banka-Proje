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
    public partial class YöneticiPanel : Form
    {
        public YöneticiPanel()
        {
            InitializeComponent();
        }

        private void btn_hesaplistele_Click(object sender, EventArgs e)
        {
            HesapListele hesap = new HesapListele();
            hesap.HesapListele_Load(sender, e);
            hesap.ShowDialog();
        }

        private void btn_kredikarti_Click(object sender, EventArgs e)
        {
            BankaKartıBilgileri kkart = new BankaKartıBilgileri();
            kkart.BankaKartıBilgileri_Load(sender, e);
            kkart.ShowDialog();
        }

        private void btn_alısveris_Click(object sender, EventArgs e)
        {
            Alısveris alısveris = new Alısveris();
            alısveris.Alısveris_Load(sender, e);
            alısveris.ShowDialog();
        }

        private void btn_musteribilgileri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Form1_Load(sender, e);
            form1.ShowDialog();
        }

        private void btn_banka_Click(object sender, EventArgs e)
        {
            Banka banka = new Banka();
            banka.Banka_Load(sender, e);
            banka.ShowDialog();
        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            fatura.Fatura_Load(sender, e);
            fatura.ShowDialog();
        }

        private void btn_kredi_karti_Click(object sender, EventArgs e)
        {
            KrediKartı krediKartı = new KrediKartı();
            krediKartı.KrediKartı_Load(sender, e);
            krediKartı.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferBilgileri transferBilgileri = new TransferBilgileri();
            transferBilgileri.TransferBilgileri_Load(sender, e);
            transferBilgileri.ShowDialog();
        }
    }
}
