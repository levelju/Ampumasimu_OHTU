using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ampumasimu_v2
{
    class Program
    {    
       
        static void Main(string[] args)
        {
            int laukaus = 0, maara, valinta;
            double aika, matka, ennakko, juoksu, koko, luodinnopeus;
           
            string teksti="", teksti2="";
            Random gen = new Random();
                       

        Console.WriteLine("Anna ampujan nimi: ");

            Ampuja ampuja1 = new Ampuja();
            ampuja1.NimeaAmpuja(Console.ReadLine());


            Console.WriteLine("Montako luotia?: ");
            maara = int.Parse(Console.ReadLine());


            Console.Write("\nValitse aseen kaliiberi: \n1 = 308\n2 = 9.3x62\n");
            valinta = int.Parse(Console.ReadLine());

            Kivaari kivaari = new Kivaari();

            Luoti luoti1 = new Luoti();

            
            do
            {
                // arvotaan satunnaisluvulla millainen kohde tulee
                int riistanArvonta = gen.Next(2) + 1;
                double vauhdinArvonta = gen.Next(2) + 1;

                if (riistanArvonta == 1)
                {
                    teksti = "Hirvi tulee ";
                }
                if (riistanArvonta == 2)
                {
                     teksti = "Kauris tulee ";
                }
                if (vauhdinArvonta == 1)
                {
                     teksti2 = "kävellen";
                }
                if (vauhdinArvonta == 2)
                {
                     teksti2 = "juosten";
                }
                
                // tulostetaan arvonnan tulos
                Console.WriteLine(teksti + teksti2);                                   

                Console.WriteLine("Anna ampumamatka metreinä kymmenen metrin tarkkuudella: ");
                matka = double.Parse(Console.ReadLine());
                laukaus++;
                // rajoitetaan matka koska ballistiikkataulukko vain 200m asti
                if (matka > 200)
                {
                    Console.WriteLine("\nPAM!\n");
                    Console.WriteLine("Ammuit aivan liian kauas ja meni ohi!");
                    continue;
                }


                Console.WriteLine("Arvioi ennakko sentteinä: ");
                ennakko = double.Parse(Console.ReadLine()) / 100;
                               
  
                luodinnopeus = kivaari.HaeNopeus1(matka,valinta);
                

                luoti1.AnimoiLuoti(matka);

                aika = luoti1.LaskeAika(luodinnopeus, matka);
                

                // käsitellään varsinainen simulointi eli matkojen ja nopeuksien laskenta
                if (riistanArvonta == 2)

                {
                    Kauris kauris = new Kauris();
                    juoksu = kauris.LaskeMatka(kauris.AnnaNopeus(vauhdinArvonta), aika);

                    koko = kauris.koko;

                    if (koko/2 >= ampuja1.LaskeOsumapiste(ennakko, juoksu))


                    {
                        Console.WriteLine("Ennakko {0:f2}, kohteen liike {1:f2}, erotus {2:f2}", ennakko, juoksu, ennakko - juoksu);
                        Console.WriteLine("Osuma!");
                        ISaalis iSaalis = new Riista();
                        iSaalis.LaskeSaalis(30);
                        Console.WriteLine(" ");

                        ampuja1.pisteet++;
                    }
                    else
                    {
                        Console.WriteLine("Ennakko {0:f2}, kohteen liike {1:f2}, erotus {2:f2}", ennakko, juoksu, ennakko - juoksu);
                        Console.WriteLine("Ohi!");
                        Console.WriteLine(" ");

                    }
                }

                if (riistanArvonta == 1)

                {
                    Hirvi hirvi = new Hirvi();
                    juoksu = hirvi.LaskeMatka(hirvi.AnnaNopeus(vauhdinArvonta), aika);

                    koko = hirvi.koko;

                    if (koko/2 >= ampuja1.LaskeOsumapiste(ennakko, juoksu))
 
                    {
                        Console.WriteLine("Ennakko {0:f2}, kohteen liike {1:f2}, erotus {2:f2}", ennakko, juoksu, ennakko - juoksu);
                        Console.WriteLine("Osuma!");
                        ISaalis iSaalis = new Riista();
                        iSaalis.LaskeSaalis(100);
                        Console.WriteLine(" ");
                        ampuja1.pisteet++;
                    }
                    else
                    {
                        Console.WriteLine("Ennakko {0:f2}, kohteen liike {1:f2}, erotus {2:f2}", ennakko, juoksu, ennakko - juoksu);
                        Console.WriteLine("Ohi!");
                        Console.WriteLine(" ");
                        
                    }

                }                

                

            } while (laukaus < maara);

            
            Console.WriteLine("Paukut loppui");
            Console.WriteLine("Osumia: " + ampuja1.pisteet);
           

            Console.ReadLine();


        }
    }
}
