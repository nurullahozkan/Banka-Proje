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
    public partial class TransferBilgileri : Form
    {
        public TransferBilgileri()
        {
            InitializeComponent();
        }
        Baglanti t;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void TransferBilgileri_Load(object sender, EventArgs e)
        {

            t = new Baglanti();


            NpgsqlCommand cmdveri = new NpgsqlCommand("Select * from havaleft", t.getBaglanti());
            NpgsqlDataReader dr = cmdveri.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
