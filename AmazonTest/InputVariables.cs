using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonTest
{
    public class InputVariables
    {
          
        public static string email
        {
            
            get
            {
               
                return "juan.amazontest@gmail.com";
            }
        }
        public static string pass
        {
            get
            {
                return "a123456789";
            }
        }
        public static string name
        {
            get
            {
                return "white tshirt";
            }

        }
        public static string fullName
        {
            get
            {
                return "Juan Carlos Almonte Rozon";
            }
        }
    
    }
}
