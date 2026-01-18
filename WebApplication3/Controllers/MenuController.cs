using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MenuController : Controller

    {


    string baglanti = "Server=DESKTOP-KU8OK31\\SQLEXPRESS05;Database=Restorant;Trusted_Connection=True;TrustServerCertificate=True;";

        public IActionResult List()
        {

            

            using var sqlbaglantısı = new SqlConnection(baglanti);
            List<Menü> liste = sqlbaglantısı.Query<Menü>("Select * from Menü").ToList();


            return View(liste);
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(Menü menü)
        {
            using var sqlbaglantı = new SqlConnection(baglanti);
            string query = "INSERT INTO Menü (YemekAdı, Fiyat ) VALUES (@YemekAdı, @Fiyat )";
            sqlbaglantı.Execute(query, menü);

            return RedirectToAction("List");
            
            
        }
        public IActionResult Delete(int id)
        {
            using var sqlbaglantı = new SqlConnection(baglanti);
            string query = "DELETE FROM Menü WHERE Id = @id";
            sqlbaglantı.Execute(query, new { id });


            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            using var sqlbaglantı = new SqlConnection(baglanti);
            string query = "SELECT * FROM Menü WHERE Id = @id";
            Menü menü = sqlbaglantı.QueryFirstOrDefault<Menü>(query, new { id });

            return View(menü);
        }


        [HttpPost]
        public IActionResult Update(Menü menü)
        {
            using var sqlbaglantı = new SqlConnection(baglanti);
            string query = "UPDATE Menü SET YemekAdı = @YemekAdı, Fiyat = @Fiyat WHERE Id = @Id";
            sqlbaglantı.Execute(query, menü);

            return RedirectToAction("List");
        }
    }
}
