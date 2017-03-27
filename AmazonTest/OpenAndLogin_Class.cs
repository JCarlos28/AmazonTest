using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AmazonTest
{
    public class OpenAndLogin_Class
    {
        

   
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.Address);
         

        }
        //precionar ingresar, luego llenar los campos y preciona ingresar
        public static void UserAndPass(string userName, string passWord)
        {
            Driver.Instance.FindElement(By.Id("nav-link-accountList")).Click();

            Driver.Instance.FindElement(By.Id("ap_email")).SendKeys(userName);

            Driver.Instance.FindElement(By.Id("ap_password")).SendKeys(passWord);

            Driver.Instance.FindElement(By.Id("signInSubmit")).Click();

      

         

        }
     
    }
}
