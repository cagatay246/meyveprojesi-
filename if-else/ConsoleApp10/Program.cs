using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elma 2tl");
            Console.WriteLine("armut 3tl");
            Console.WriteLine("çilek 2tl");
            Console.WriteLine("muz 3tl");
            Console.WriteLine("diğer meyveler 4tl");
            Console.WriteLine("hangi meyveyi almak istersiniz");


            //kullanıcıya soru sorma
            Console.WriteLine("lütfen almak istediğiniz meyveyi girin:");
            String meyve = Console.ReadLine();

            //meyve ismini küçüf harf yapma
            meyve = meyve.ToLower();

            //fiyat belirlemek için yapılan if yapısı 
            if (meyve == "elma")
            {
                Console.WriteLine("Elmanın fiyatı:2 tl");

            }
            else if (meyve == "armut")

            {
                Console.WriteLine("armutun fiyatı :3 tl");

            }
            else if (meyve == "çilek")
            {
                Console.WriteLine("çileğin fiyatı: 2 tl");

            }
            else if (meyve == "muz")
            {
                Console.WriteLine("muzun fiyatı: 3tl");
            }
            else
            {
                Console.WriteLine("Diğer meyve fiyatı: 4 TL");
            }


        }
    }
}

