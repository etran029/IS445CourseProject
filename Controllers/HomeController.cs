using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WebForm()
        {
            return View();
        }

        public ActionResult AbsoluteLayout()
        {
            return View();
        }

        public ActionResult Static()
        {
            return View();
        }

        public ActionResult Absolute()
        {
            return View();
        }

        public ActionResult Float()
        {
            return View();
        }

        public ActionResult ClientSide()
        {
            return View();
        }
        
        public ActionResult ServerSide()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            return View();
        }


        public ActionResult FormatPhoneNumber(string inputNumber)
        {

          if (string.IsNullOrEmpty(inputNumber))
          {
            return View((object)"==Invalid input, please try again==");
          }
          else if (inputNumber.Length != 10)
          {
              return View((object)"==Incorrect amount of digits, please enter 10 digits==");
          }
          else
          {
              string formatted = formatNumber(inputNumber);
              return View((object)formatted);
          }
        }//end FormatPhoneNumber

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {
          // imiplement formatting here
          
          //JavaScript
          var first = inputNumber.Substring(0, 3);
          var second = inputNumber.Substring(3, 3);
          var third = inputNumber.Substring(6, 4);
          var phoneString = "(" + first + ") " + second + "-" + third + ".";
          return phoneString;
        }//end formatNumber
        
        public ActionResult FormatPhraseReverse(string inputPhrase)
        {
            if (string.IsNullOrEmpty(inputPhrase))
            {
                var error = "==Invalid input, please try again==";
                return View((object)error);
            }
            else
            {
                //var s = "Hello world";
                var words = inputPhrase;
                
                var result = String.Join(" ", words.Split(' ').Reverse());
                return View((object)result);

                /*
                string[] words = inputPhrase.Split(' ');

                string reverse = "";

                foreach (string part in words)
                {
                    reverse = part + " " + reverse;
                }

                return View((object)reverse);
                */
            }
        }//end FormatPhraseReverse
        
    }
}
