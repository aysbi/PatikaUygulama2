using System;

namespace PatikaUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir sayi giriniz: ");
            int Sayi = Convert.ToInt32 (Console.ReadLine()); //gelen string degeri tam sayiya cevirir

            if (Sayi >= 0) //girilen sayinin pozitifligini kontrol ediyorum 
            {

                if (Sayi > 10) // sayinin 10'dan buyuk olup olmadigi sorgulaniyor
                {
                    Console.WriteLine("Girilen sayi 10'dan buyuktur.");
                }
                else if (Sayi == 10) // sayi 10'a esitse girilecek if statement
                {
                    Console.WriteLine("Girilen sayi 10'dur.");
                }
                else // bu else statement eger sayi hem pozitif hem de 10 ve ustu bir sayi degilse
                {
                    Console.WriteLine("Sayi 10'dan kucuktur.");
                }

                if (Sayi % 2 == 1) // sayinin 2 tabanindaki modunu alir
                {
                    Console.WriteLine("Sayi tektir.");
                }
                else // sayinin 2 tababnindaki modu sifir ise bu statementa girer (Tek sayı)
                {
                    Console.WriteLine("Girilen sayi cifttir.");
                }
            }
            else // sayi sifirdan kucukse tekrar denenmesi icin hata belirtilmesidir
            {
                Console.WriteLine("Girilen sayi negatiftir lutfen pozitif bir sayi girip tekrar deneyiniz.");
            }
        }
    }
}