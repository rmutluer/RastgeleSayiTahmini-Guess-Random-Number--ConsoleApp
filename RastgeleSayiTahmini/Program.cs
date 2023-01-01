using System;

namespace RastgeleSayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            Random rnd = new Random();  
            int tutulanSayi = rnd.Next(1, 101); //1 ile 100 arası sayı üretir

            Console.WriteLine("**********Sayı tahmin oyunu***********");
            Console.WriteLine("Lütfen 1 ile 100 arasında bir tahmin giriniz");
        tahmin: int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

            if (sayac < 10)
            {
                if (tahminEdilenSayi == tutulanSayi)
                {
                    Console.WriteLine($"tebrikler {sayac} adımda bitirdiniz.");
                }
                else if (tahminEdilenSayi < tutulanSayi)
                {
                    Console.WriteLine($"Küçük sayı tahmin ettiniz tahmininizi yükseltin");
                    sayac++;
                    goto tahmin;
                }
                else if (tahminEdilenSayi > tutulanSayi)
                {
                    Console.WriteLine($"Büyük sayı tahmin ettiniz tahmininizi düşürün");
                    sayac++;
                    goto tahmin;
                }
            }
            else
            {
                Console.WriteLine($"bilemediniz, bir dahaki sefere");
            }
            Console.ReadLine();
        }
    }
}
