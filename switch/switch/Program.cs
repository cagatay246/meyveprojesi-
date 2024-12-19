using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Elma fiyatı: 2 TL");
            Console.WriteLine("Armut fiyatı: 3 TL");
            Console.WriteLine("Çilek fiyatı: 2 TL");
            Console.WriteLine("Muz fiyatı: 3 TL");
            Console.WriteLine("Diğer meyve fiyatı: 4 TL");


            Console.WriteLine("almak istediğiniz meyve:");
            string meyve = Console.ReadLine();

            //kullanıcıdan gelen meyve ismini küçük harf yapmak 
            meyve = meyve.ToLower();

            switch (meyve)
            {
                case "elma":
                    Console.WriteLine("elma fiyatı 2 tl");
                    break;

                case "armut":
                    Console.WriteLine("armut fiyatı 3 tl");
                    break;

                case "çilek":
                    Console.WriteLine("çilek fiyatı 2 tl");
                    break;

                case "muz":
                    Console.WriteLine("muz fiyatı 3 tl");
                    break;

                deafult:
                    Console.WriteLine("diğer meyvelerin fiyatı 4 tl");
                    break;

            }
        }
    }
}
