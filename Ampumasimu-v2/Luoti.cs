using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ampumasimu_v2
{
    public class Luoti
    {

        public void AnimoiLuoti(double matka)
        {
            string tyhja = "-";
            string luoti = ">";

                Console.WriteLine("\nPAM!\n");
                for (int i = 1; i < matka / 10; i++)

                {
                    System.Threading.Thread.Sleep(20);
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    // Console.Clear();
                    Console.WriteLine(value: string.Concat(Enumerable.Repeat(tyhja, i)) + luoti);
                }
     
        }
        public double LaskeAika(double nopeus, double matka)
        {
            double matka1 = matka;
          //  double nopeus1 = nopeus;
            double aika = matka1 / nopeus;
            return aika;
        }



    }
}