using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ampumasimu_v2
{
    class Kivaari
    {

        public double HaeNopeus1(double matka, int valinta)
        {
           string[] rivit;

            if (valinta == 1)
            {
                rivit = File.ReadAllLines(@"308.csv");
            }
            else
            {
                rivit = File.ReadAllLines(@"9362.csv");
            }
           

           string haku = matka.ToString();

            string value = Array.Find(rivit,
                       element => element.StartsWith(haku, StringComparison.Ordinal));

            int jakaja = value.IndexOf(";");
            double nopeus = double.Parse(value.Substring(jakaja + 1));

            return nopeus;                                                                                    
        }


    }
}
