using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region metotlar
            //geriye değer döndürmeyen metotlar
            //customer >>> listeke, ekle, sil , güncelle


            //void CustomerList()
            //{
            //    Console.WriteLine("gamze ince"); 
            //    Console.WriteLine("ayşe ince");
            //    Console.WriteLine("berkan ince");
            //    Console.WriteLine("mustafa ince");
            //}
            //CustomerList();


            //void Sum()
            //{
            //    int x = 5;
            //    int y = 5;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region geriye değer döndürmeyen paramtreli metotlar

            //void WriteMethod(string customerName)

            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Gamze İnce");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Gamze" , "İnce");
            //CustomerCard("Ayşe", "İnce");
            #endregion

            #region geriye değer döndürmeyen int parametreli metotolar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);  
            //}
            //Sum(4, 5, 6);
            #endregion


            #region geriye değer döndüren metotolar

            //string CustomerName()
            //{
            //    return "Gamze İnce";
            //}   
            //CustomerName();

            //String StudentCard()
            //{
            //    string name = "GAMZE";
            //    string surname = "İNCE";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());
            #endregion


            #region geriye değer döndüren string parametreli metotolar

            //string CountrCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başklent: " + capital + "BAYRAK RENGİ:  " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz");
            //x = Console.ReadLine();
            //Console.WriteLine("Başkenti Giriniz");
            //y = Console.ReadLine();
            //Console.WriteLine("Byarak Rengi Giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountrCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion



            #region örnek uygulama
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + "isimli öğrenci sınavı geçti " + "ortalama " + result;

            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci sınavı geçemedi " + "ortalama " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Gamze", 25, 41, 85));
            //Console.WriteLine(ExamResult("Ayşe", 30, 90, 67));


            #endregion

          

            Console.Read();
        }
    }
}
   