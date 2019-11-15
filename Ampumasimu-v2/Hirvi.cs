using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ampumasimu_v2
{
    public class Hirvi : Riista
    {

        public new double koko = 0.50;

        public double AnnaNopeus(double vauhdinArvonta)
        {
            double perusnopeus = 3;

            nopeus = vauhdinArvonta * perusnopeus;

            return nopeus;
        }

    }
}