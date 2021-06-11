using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using Sketches_MVC.Models;
using System.Configuration;

namespace Sketches_MVC.Controllers
{
    public class StoreController : Controller
    {
        string connectionString = @"Data Source=DESKTOP-MDQBLQ0\MSSQLSERVER01;Initial Catalog=Stationary; Integrated Security=True";
        [HttpGet]
        public ActionResult Login()
        {
            DataTable dtblStore = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM  Store", sqlCon);

                sqlDa.Fill(dtblStore);
            }
            return View(dtblStore);

        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signin(LoginModel Sign)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {

                sqlcon.Open();
                string query = "select UserName,Password from Store where UserName=@UserName and Password=@Password";
                SqlCommand cmd = new SqlCommand(query,sqlcon);
                cmd.Parameters.AddWithValue("@UserName",Sign.UserName);
                cmd.Parameters.AddWithValue("@Password",Sign.Password);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Session["username"] = Sign.UserName.ToString();
                    return RedirectToAction("Success");
                    //ViewData["Message"] = "User Logged in success";
                }
                else {
                    ViewData["Message"] = "User Logged failed";
                }
                sqlcon.Close();
        }
        
    return View();
}

        public ActionResult Success()
        {
            
            return View();
        }
   
        //public ActionResult Logout()
        //{
        //    Session.Abandon();
        //    return RedirectToAction("SignIn");
        //}
         

        // GET: Store/Create
        [HttpGet]
        public ActionResult Registration()
        {
            return View(new LoginModel());
        }

        // POST: Store/Create
        [HttpPost]
        public ActionResult Registration(LoginModel loginModel)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                string query = "INSERT INTO Store VALUES(@UserName,@Password,@Email,@Mobile)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@UserName",loginModel.UserName);
                sqlCmd.Parameters.AddWithValue("@Password", loginModel.Password);
                sqlCmd.Parameters.AddWithValue("@Email",loginModel.Email);
                sqlCmd.Parameters.AddWithValue("@Mobile",loginModel.Mobile);
                sqlCmd.ExecuteNonQuery();



       
            }
            return RedirectToAction("SignIn");
        }

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Store/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Store/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
