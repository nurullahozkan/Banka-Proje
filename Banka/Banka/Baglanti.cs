using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Banka
{
    public class Baglanti
    {
        private NpgsqlConnection baglanti;

        public Baglanti()
        {
            if (baglanti == null)
            {
                baglanti = new NpgsqlConnection("Server=localhost;User ID=postgres;password=sevgi123+.;Database=banka");

                baglanti.Open();
            }
            else
            {
                baglanti.Open();
            }
        }

        public NpgsqlConnection getBaglanti()
        {
            if(baglanti == null)
            {
                baglanti = new NpgsqlConnection();
            }
            return baglanti;
        }
        
        
        
    }
}
