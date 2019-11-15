using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ampumasimu_v2
{
    public class Ampuja
    {
        public string name;
        public double pisteet=0;

        public void NimeaAmpuja(string nimi)
        {
            name = nimi;
        }


        public double LaskeOsumapiste(double ennakko, double matka) 
        {
            double vastaus = ennakko - matka;
            if (vastaus < 0)
            {
                            
                double erotus = vastaus * -1;
                return erotus;
             }
            else
            {
                double erotus = vastaus * 1;
                return erotus;
            }
        }


    }
}