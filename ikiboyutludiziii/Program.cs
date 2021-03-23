using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikiboyutludiziii
{
    class Program
    {
        static void Main(string[] args)
        {
            int mevcut = 0;
            Console.Write("Kaç öğrenci hesaplamak istiyorsun? ");
            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] öğrenci = new string[mevcut];

            for (int i = 0; i < mevcut; i++)
            {
                string ad, soyad;
                Console.WriteLine("Adı yazınız.");
                ad = Console.ReadLine();
                Console.WriteLine("Soyadı yazınız.");
                soyad = Console.ReadLine();
                Console.ReadKey();

                int vize, final, ort;
                Console.Write("Vize notunu söyle bakalım. ");
                vize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Final notun nedir? ");
                final = Convert.ToInt32(Console.ReadLine());
                ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
                Console.WriteLine();
                Console.WriteLine("Ortalamanız = {0}", ort);
                Console.WriteLine();
                if (ort < 50 || final < 50)
                    Console.WriteLine("Kaldın.");
                else
                    Console.WriteLine("Geçtin. Tebrikler!");
                if (ort >= 0 && ort <= 38)
                {
                    Console.WriteLine("Ortalamanız={0} ", ort);
                    Console.WriteLine("FF ile kaldınız");
                }
                else if (ort >= 39 && ort <= 47)
                {
                    Console.WriteLine("Ortalamanız={0} ", ort);
                    Console.WriteLine("FD ile kaldınız");
                }
                else if (ort >= 48 && ort <= 57)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("DD ile koşullu geçmişsin.");
                }
                else if (ort >= 58 && ort <= 67)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("DC ile koşullu geçtin");
                }
                else if (ort >= 68 && ort <= 74)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("CC Geçtiniz");
                }
                else if (ort >= 80 && ort <= 79)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("BB Geçtiniz, biraz daha çalışmalısınız.");
                }
                else if (ort >= 75 && ort <= 84)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("CB Geçtiniz");
                }
                else if (ort >= 85 && ort <= 89)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("BA Geçtiniz");
                }
                else if (ort >= 90 && ort <= 100)
                {
                    Console.WriteLine("Ortalamanız={0}", ort);
                    Console.WriteLine("AA geçtiniz, tebrikler");
                }
                else

                    Console.ReadKey();
            }
        }
    }
}
    