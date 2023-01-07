using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Administration.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Administration;

namespace Administration.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public AuthController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


public IActionResult Register(string name,string email ,string password)
    {
        try{
            string fileName=@"C:\Abhijit\dotnetlab\AdministrationApp\Administration\Controllers\admin.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            List<Admin> jsonAdmins = JsonSerializer.Deserialize<List<Admin>>(jsonString);

            Admin ad = new Admin(name,email,password);
            jsonAdmins.Add(ad);

            var options=new JsonSerializerOptions {IncludeFields=true};
            var produtsJson=JsonSerializer.Serialize<List<Admin>>(jsonAdmins,options);


        }
        catch(Exception e){

        }

        return View();
    }





public IActionResult Login()
    {
        return View();
    }


    public IActionResult Validate(string email,string password)
    {  
         try{
            string fileName=@"C:\Abhijit\dotnetlab\AdministrationApp\Administration\Controllers\admin.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            List<Admin> jsonAdmins = JsonSerializer.Deserialize<List<Admin>>(jsonString);
           
            foreach (Admin ad in jsonAdmins)
            {
                if(ad.Email==email && ad.Password==password){
                    return Redirect("/home/Welcome");
                }
            }
            
            }
            catch(Exception exp){
            }

        return View();
    }


     public IActionResult Welcome()
    {
        return View();
    }




[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

   
}