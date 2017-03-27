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
            Driver.Instance.FindElement(By.Name("enterAddressAddressLine1")).SendKeys(InputVariables.AddresLine1);
            Driver.Instance.FindElement(By.Name("enterAddressAddressLine2")).SendKeys(InputVariables.AddresLine2);
            Driver.Instance.FindElement(By.Name("enterAddressCity")).SendKeys(InputVariables.State);
            Driver.Instance.FindElement(By.Name("enterAddressStateOrRegion")).SendKeys(InputVariables.State);
            Driver.Instance.FindElement(By.Name("enterAddressPostalCode")).SendKeys(InputVariables.Zip);
            
            new SelectElement(Driver.Instance.FindElement(By.Id("enterAddressCountryCode"))).SelectByText("Dominican Republic");
            

        }
    }
}
