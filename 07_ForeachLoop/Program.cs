using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Forech
            //Forech(1;2;3;4)
            //1:Değişken TÜrü
            //2: Değişken Adı
            //3: In;
            //4: Liste, KOleksiyon, Dizi 

            //string[] cities = { "milano", "roma", "budapeşte", "istanbul", "varşova" };
            //foreach ( string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 45, 55, 67, 67, 89, 35, 79, 90 };
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = { 20, 22, 55, 67, 67, 89, 35, 70, 90 };
            //foreach (int number in numbers)
            //{
            //    if (number %2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 40, 78, 985, 74, 11, 22, 33, 41, 2015, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers) 
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);



            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{ 
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}





            #endregion
            #region sınac sistemi uygulaması
            Console.WriteLine("***** C#Eğitim Kampı Sınav Uygulaması ******");
            Console.WriteLine();
            Console.WriteLine();
 
            //sınıftaki ögrenci sayısını kullanıcıdan al
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            //öğrenci isimlerini ve not ort. saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();


                double totalExamResult = 0;
                //her ögrenci için 3 adet sınav notu girişi al

                for (int  j = 0; j <3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value;  //notları toplayalım
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }
          
            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"{studentNames[i]} adlı ögrencinin ortalaması:   { studentExamAvg[i]} ");

                //örenci ortalamsına göre geçti kaldı durumları
                if (studentExamAvg[i] <= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti :)) ");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı :((");
                }
                Console.WriteLine("----------------------------");
            }

            #endregion
            Console.Read();
        }
    }
}
