using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AmazonTest
{
     public static class CheckOut
    {
        public static void PressAdd()
        {
            Driver.Instance.FindElement(By.Id("add-to-cart-button")).Click();
            Driver.Instance.FindElement(By.Id("hlb-ptc-btn-native")).Click();
            Driver.Instance.FindElement(By.Name("enterAddressFullName")).SendKeys(InputVariables.fullName);
            

        }
    }
}
