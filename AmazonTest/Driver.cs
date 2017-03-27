using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonTest
{
   public class Driver
    {
        
       
        //instancio el driver para poder usarlo donde quiera.
        public static IWebDriver Instance { get; set; }
        public static void initialize()
        {
            Instance = new ChromeDriver();
        }
        public static string Address
        {

            get { return "https://www.amazon.com "; }
        }
        public static void Maximizar()
        {
            Driver.Instance.Manage().Window.Maximize();
        }
    }
}
