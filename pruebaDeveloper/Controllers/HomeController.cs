using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Configuration;


namespace pruebaDeveloper.Controllers
{
  
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost] 
        public ActionResult RecibirDatos(FormCollection   formCollection)
        {
            
            string Usuario = formCollection["Usuario"];
            string name = formCollection["name"];
            string cargo = formCollection["cargo"];
            string Telefono = "+57" + formCollection ["Telefono"];
            string Email = formCollection["Email"];
            string NCelular = formCollection["NCelular"];
            string Tcontact = formCollection["Tcontact"];

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Fomrdb"].ConnectionString);
           con.Open();

                SqlCommand com = new SqlCommand(); // Create a object of SqlCommand class
                com.Connection = con; 
                com.CommandType = CommandType.StoredProcedure; 
                com.CommandText = "spInsertUser"; 

                com.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = Usuario;
                com.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                com.Parameters.Add("@cargo", SqlDbType.NVarChar).Value = cargo;
                com.Parameters.Add("@Telefono", SqlDbType.NVarChar).Value = Telefono;
                com.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                com.Parameters.Add("@NCelular", SqlDbType.NVarChar).Value = NCelular;
                com.Parameters.Add("@Tcontact", SqlDbType.NVarChar).Value = Tcontact;

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            return View("Index");


        }
    }
}