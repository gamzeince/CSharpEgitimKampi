using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dzi Örnekleri
            //DeğişkenTürü[] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);
            //Console.Read();



            //string[] cities = new string[5];
            //cities[0] = "Milan";
            //cities[1] = "Badapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Bali";

            //Console.WriteLine(cities[5]);
            //Console.Read();


            //int[]numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 878;
            //numbers[3] = 24;
            //numbers[8] = 8789;

            //Console.WriteLine(numbers[8]);
            //Console.Read();



            //string[] cities = { "prag", "roma", "atina" };
            //Console.WriteLine(cities[2]);
            //Console.Read();

            #endregion

            #region dizideki tüm elemanları listeleme

            //string[] colors = { "sarı", "kırmzıı", "yeşil", "turuncu", "pembe", "mavi", "beyaz" };

            //for (int i = 0; i < colors.Length; i++)
            //{ 
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i=0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'A', 'B', 'C', '*', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 85, 95, 41, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    { 
            //        maxNumber = myArray[i]; 
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "gamze", "sare", "ayse" };
            //Console.WriteLine(persons.Length);

            //int[] number = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(number); 
            //for(int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}


            //int[] number = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            #endregion


            #region Dizi Metotoları
            //string[] customers = { "gamze", "ayşe", "sare", "mustafa" };
            //int index = Array.IndexOf(customers, "gamze");
            //Console.WriteLine(index);


            //int[] numbers = { 45, 85, 96, 63, 74, 10, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "Dizinin En Küçük Elamanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehrini Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i< numbers.Length; i++)
            //{
            //    sum += numbers[i];  
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("*******************");
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
