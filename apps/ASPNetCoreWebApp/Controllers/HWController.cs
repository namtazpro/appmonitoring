using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ASPNetCoreWebApp.Controllers
{
    public class HWController : Controller
    {
        // 
        // GET: /HW/ or /HW/Index
        // This is because of pattern in Startup.cs file. See pattern: "{controller=Home}/{action=Index}/{id?}");
        // ref: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-3.0&tabs=visual-studio

        /* This is the default return value i.e. string if you want to return a simple data string. But in this caase the controller controls the view which is not
         * what an MVC should do. So use IActionResult to return a View and have a Razor cshtml page called instead.
        public string Index()
        {
            return "This is my default action...";
        }
        */

        public IActionResult Index()
        {
            return View();

            //Navigate to https://localhost:{PORT}/HelloWorld. The Index method in the HelloWorldController didn't do much;
            // it ran the statement return View();, which specified that the method should use a view template file to render
            // a response to the browser. Because a view template file name wasn't specified, MVC defaulted to using the default view file.
            // The default view file has the same name as the method (Index), so in the /Views/HelloWorld/Index.cshtml is used. 
            //The image below shows the string "Hello from our View Template!" hard-coded in the view.

        }

        // 
        // GET: /HW/Welcome/ 
        // This is because of pattern in Startup.cs file. See pattern: "{controller=Home}/{action=Index}/{id?}");
        // call using /HW/Welcome?name=Rick&numtimes=4
        /*
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        */
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // GET: /HW/Sayhello/ 
        // This is because of pattern in Startup.cs file. See pattern: "{controller=Home}/{action=Index}/{id?}");
        // /HW/Welcome/3?name=Rick

        public string Sayhello(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}