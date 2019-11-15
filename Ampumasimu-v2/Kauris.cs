using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ampumasimu_v2
{
    public class Kauris : Riista
    {

        public new double koko = 0.20;

        public double AnnaNopeus(double vauhdinArvonta)
        {
            double perusnopeus = 2;

            nopeus = vauhdinArvonta * perusnopeus;                                  

            return nopeus;
        }

    }
}