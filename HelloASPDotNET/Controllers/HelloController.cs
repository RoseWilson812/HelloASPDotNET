using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            
            string html = "<form method='post' action='/helloworld'>" +
            "<label for='languageSelect'></label>" +
               "<select name = 'languages' id = 'languageSelect' >" +
                  "<option value = 'Hello, ' > English</ option >" +
                  "<option value = 'Bonjour, ' > French</ option >" +
                  "<option value = 'Hola, ' > Spanish</ option >" +
                  "<option value = 'Guten Tag, ' > German</ option >" +
                  "<option value = 'Ciao, ' > Italian</ option >" +
              "</select>" +
            "<input type='text' name='name' />" +
            "<input type='submit' value='Greet Me!' />" +
         "</form>";
            return Content(html, "text/html");
          
            
         
           
        }
        // GET: /<controller>/welcome
        //[HttpGet("{welcome{name?}")]
        [HttpGet("{languages}/{name}")]
        [HttpPost]
        public IActionResult Welcome(string name, string languages )
        {
           string message = CreateMessage(name, languages);
            return Content(message, "text/html");
        }
        
        
        public static string CreateMessage (string iName, string iLanguage )
        {
            if (iName == null)
            {
                iName = "World";
            }
            string hello = "<h1>" + iLanguage + iName + "!</h1>";
            return hello;
        }

    }
}
