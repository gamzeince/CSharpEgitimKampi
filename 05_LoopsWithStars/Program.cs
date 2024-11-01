using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 adet yıldız oluştur 
            //for(int i = 1; i<=10; i ++)
            //{
            //    Console.WriteLine("*");
            //}
            //Console.Read();
            #endregion


            #region yan yana 10 adet yıldız
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.Read();
            #endregion




            #region alt alta 10 yıldız, her satırda 10 adet yıldız
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            //Console.Read();
            #endregion



            #region dik üçgen 
            //for(int i = 1; i<=5; i++)
            //{
            //    for(int j=1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();
            #endregion


            #region ters dik üçgen 
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();
            #endregion



            #region dik ve ters dik üçgen 
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 4; k>= 1; k--)
            //{
            //    for (int g = 1; g <= k; g++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();
            #endregion


            #region bKLAVA DİLİMİ


            //int n = 5;
            //for(int i=1; i<= n; i++)
            //{
            //    for(int j=n-1; j> 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k<= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n-1; i>= 1; i-- )
            //{
            //    for (int j=n -1; j > 0; j --)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.Read();
            #endregion

            #region piramit
            //int n = 5; // Piramidin yüksekliği

            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşluklar için döngü
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldızlar için döngü
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            #endregion ters piramiy,

            int n = 5; 

            for (int i = n; i >= 1; i--) 
            {
             
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

               
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
