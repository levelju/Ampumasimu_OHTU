using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ampumasimu_v2
{
    public class Riista : ISaalis
    {
        
        public double koko = 0.28;
        public double nopeus = 2;

        int saalis;

        public void LaskeSaalis(int kiloa)
        {
            Console.WriteLine("Sait {0} kiloa lihaa.", kiloa);
            saalis++;
        }
                
        public double LaskeMatka(double nopeus, double aika)
        {
            double oikeaEnnakko = nopeus * aika;
            return oikeaEnnakko;
        }
    }
}