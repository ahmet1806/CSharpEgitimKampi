using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            ////Console.WriteLine("Merhaba Dünya");
            ////Console.Write("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion


            #region String Değişkenler


            ////string
            ////Değişken_türü boşluk bırak deiğişken_adı;

            ////string name;
            ////name = "Ahmet";
            ////Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ahmet";
            //customerSurname = "Kara";
            //customerPhone = "+90 542 254 98 18";
            //customerEmail = "deneme@gmail.com";
            //district = "Keçiören";
            //city = "Ankara";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müsteri: "+customerName +" "+customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district +"/" + city);
            //Console.WriteLine("----------------------------------------");

            //Console.WriteLine();


            //customerName = "Ayşegül";
            //customerSurname = "Çınar";
            //customerPhone = "+90 555 545 90 05";
            //customerEmail = "test@test.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------");



            #endregion

            #region Int Değişkenler

            // int = tam  sayı değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonataPrice = 30;


            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizzza:" + pizzaPrice + " TL");
            Console.WriteLine("-----Kola:" + cokePrice + " TL");
            Console.WriteLine("-----Limonata:" + lemonataPrice + " TL");
            Console.WriteLine("-----Kızartma:" + friesPrice + " TL");
            Console.WriteLine("-----Su:" + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizaaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;




            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizaaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizaaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonataPrice;






            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı:" + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı:" + totalCokePrice+ " TL");
            Console.WriteLine("Limonata Tutarı:" + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı:" + totalWaterPrice + " TL");


            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamburgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Toplam Turar: " + totalPrice);



























            #endregion

            Console.Read();



        }
    }
}

