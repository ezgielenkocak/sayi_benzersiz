using System;

namespace random_sayi_uretme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("başlangıç değer aralığını giriniz");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("bitiş değer aralığını giriniz: ");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("Kaç sayı üretmek istediğinizi girinizz: ");
            int adet = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] sayi = new int[adet];
            for (int i = 0; i < sayi.Length; i++)
            {
                sayi[i] = rnd.Next(bas, bit);
                for (int j = 0; j < i; j++)
                {
                    if (sayi[i] == sayi[j])
                    {
                        i--;
                        break;
                    }
                }

            }
            Array.Sort(sayi);
            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]);
            }
            Console.ReadKey();

        }
    }
}
