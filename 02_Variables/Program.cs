using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();


            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice  = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;


            //Console.WriteLine("--- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("--- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("--- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("--- Patates Birim Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("--- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double patatoTotalPrice = patatoPrice * patatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;


            //Console.WriteLine("Alınan Ürün: Elma     - " + "Birim Fiyatı: " + applePrice + " -  Gramaj: " + appleGram + " - Toplam: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " -  Gramaj: " + orangeGram + " - Toplam: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek    - " + "Birim Fiyatı: " + strawberryPrice + " -  Gramaj: " + strawberryGram + " - Toplam: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates  - " + "Birim Fiyatı: " + patatoPrice + " -  Gramaj: " + patatoGram + " - Toplam: " + patatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates  - " + "Birim Fiyatı: " + tomatoPrice + " -  Gramaj: " + tomatoGram + " - Toplam: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");
            #endregion

            #region Char Değişkenler

            // ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //Char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();


            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName =Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname =Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict =Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity =Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge =Console.ReadLine();
            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdentityNumber =Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No:"  + passengerIdentityNumber +" - Yolcu Adı Soyadı: " +passengerName+ " " + passengerSurname + " " + passengerDistrict+ " / " + passengerCity + " " + passengerAge );
            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice= 20000;
            //chairPrice = 5000;
            //tvPrice= 12000;


            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütefen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalprice;
            //totalprice = shoesCount * shoesPrice + chairPrice * chairCount + computerPrice * computerCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+ totalprice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız: " +result);
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lüten cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Seçtiğniz cinsiyet: " +gender);
            #endregion



            Console.Read();
        }
    }
}
