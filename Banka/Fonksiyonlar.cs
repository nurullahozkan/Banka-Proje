using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    interface Fonksiyonlar
    {
        string AdCek(string tcno);
        string MusteriNoCek(string tcno);
        string telNoCek(String musterino);
        string emailCek(String musterino);
        string adresCek(String musterino);
        string sifreCek(String musterino);
        string bankaKartNoCek(String musterino);
        string bankaKartSKTCek(String musterino);
        string cvvCek(String musterino);
        string bakiyeCek(String musterino);
    }
}
