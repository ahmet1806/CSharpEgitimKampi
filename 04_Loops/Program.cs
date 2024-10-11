using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler 1+2+3+4+5+6
            // 3+3=6+4=10+5=15+6=21

            //For (x;y;z;)
            // x: başlangıç
            // y:bitiş
            // z: artış-azalış

            //int i;

            //for (i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3; i<=50; i+=3  )
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");

            //int finisValue= int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finisValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuruyet");

            //}
            #endregion

            #region For Döngüsü İle Karar Yapıları
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalvalue = 0;

            //for (int i=1; i<=10; i++)
            //{
            //    totalvalue += i;

            //}
            //Console.WriteLine(totalvalue);


            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)

            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;

            //        Console.WriteLine(i);
            //    }
            //}
            //    Console.WriteLine("------");
            //    Console.WriteLine(totalValue);


            //int count = 0;

            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);




            //1-2-4-8-16...

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i +  " .Saat Sonunda : " + bacterium);

            //}
            #endregion

            #region While Döngüsü

            //While (şart9
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i < 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //        i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden gelen 3 basmaklı sayının basamakları toplamını hesaplayan kodu yazınız

            //456


            //Console.Write("Sayıyı Giriniz: ");
            //int number =int.Parse(Console.ReadLine());
            //int ones, tens, hunders;
            //int sum;


            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hunders = number / 100;// 4.56---->4

            //Console.WriteLine(ones+ "-" + tens + "-" + hunders);
            //sum=ones+ tens+ hunders;
            //Console.WriteLine(sum);
            #endregion

            Console.Read();
        }
    }
}
