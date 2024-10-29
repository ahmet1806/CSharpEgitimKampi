using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud-Create-Read-Update-Dekete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();



            Console.WriteLine("-------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğniz Kategori Adı: ");
            //string categoryName= Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQL;initial catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;


            //Console.Write("Ürün Aıd: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQL;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice, PoductStatus) values (@productName,@productPrice, @poductStatus)", connection);
            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice); 
            //command.Parameters.AddWithValue("poductStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı!");








            #endregion

            #region Ürün Listeme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQL;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select *From TblCategory", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{ 
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString());

            //    }Console.WriteLine();


            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());




            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQL;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı!");

            #endregion

            #region Ürün Güncelleme İşlemleri
            Console.Write("Güncellencek Ürün Id:  ");
            int  productId= int.Parse(Console.ReadLine());

            Console.Write("Güncellencek Ürün Adı :  ");
            string productName = Console.ReadLine();

            Console.Write("Güncellencek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());











            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQL;initial Catalog=EgitimKampıDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı");







            #endregion
           
            
            
            Console.Read();

        }
    }
}
