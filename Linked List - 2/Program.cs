using Linked_List___2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List tyList = new List();

            int sayi;
            int secim = menu();

            while(secim != 0)
            {
                switch (secim)
                {
                    case 1:
                        Console.Write("Başa sayı ekleyin: "); sayi = int.Parse(Console.ReadLine());
                        tyList.basaEkle(sayi);
                        tyList.yazdir();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.Write("Sona sayı ekleyin: "); sayi = int.Parse(Console.ReadLine());
                        tyList.sonaEkle(sayi);
                        tyList.yazdir();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        Console.Write("Baştan silin: "); tyList.bastanSil();
                        tyList.yazdir();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        Console.Write("Sondan silin: "); tyList.sondanSil();
                        tyList.yazdir();
                        Console.WriteLine("\n");
                        break;
                    case 0:
                        Console.WriteLine("\n");
                        break;
                }
                secim = menu();
            }
        }

        private static int menu()
        {
            int secim;

            Console.WriteLine("1 - başa ekle");
            Console.WriteLine("2 - sona ekle");
            Console.WriteLine("3 - baştan sil");
            Console.WriteLine("4 - sondan sil");
            Console.WriteLine("0 - programı kapat");
            Console.WriteLine("Seçiminiz: ");
            secim = int.Parse(Console.ReadLine());

            return secim;
        }
    }
}