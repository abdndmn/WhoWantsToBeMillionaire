// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

namespace WhoWantsToBeMillionaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kızınca tüküren hayvan hangisidir? \n a)Lama b)Deve");
            string firstAnswer = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine("Dünyaya en yakın gezegen hangisidir? \n a)Venüs b)Mars");
            string secondAnswer = Console.ReadLine()?.Trim().ToLower();
            if (firstAnswer == "a" && secondAnswer == "a") //ilk iki sorunun cevabı dogruysa kazanacagı icin 3. soru sorulmuyor
            {
                Console.WriteLine("Tebrikler 1 milyon kazandınız.");
            }
            else if (firstAnswer == "a" || secondAnswer == "a") //ilk iki sorudan birinin cevabı dogruysa 3. soru sorulup 3. sorunun cevabı da dogruysa kazandınız yazdırılacak.
            {
                Console.WriteLine("5*2+8/2-2 işleminin sonucu kaçtır?\n a)7 b)12");
                string thirdAnswer = Console.ReadLine()?.Trim().ToLower();

                if (thirdAnswer == "b")
                {
                    Console.WriteLine("Tebrikler 1 milyon kazandınız.");
                }
                else
                {
                    Console.WriteLine("Kaybettiniz!");
                }
            }
            else
            {
                Console.WriteLine("Kaybettiniz!");
            }





        }
    }
}

