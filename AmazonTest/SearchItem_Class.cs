using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
namespace AmazonTest
{
    class  SearchItem_Class
    {
        //busca y selecciona el item
        public static void WritteAndSearch(string itemName)
        {

             Driver.Instance.FindElement(By.Id("twotabsearchtextbox")).SendKeys(itemName);

             Driver.Instance.FindElement(By.ClassName("nav-input")).Click();

             var ColResult =  Driver.Instance.FindElement(By.Id("resultsCol"));
             var SelectResult = ColResult.FindElements(By.TagName("li"))[3];
             SelectResult.Click();

            var SelectSize = Driver.Instance.FindElement(By.Id("native_dropdown_selected_size_name"));
            var SelectMedium = SelectSize.FindElement(By.Id("native_size_name_4"));
            SelectMedium.Click();
            
            var SelectColor = Driver.Instance.FindElement(By.Id("native_dropdown_selected_color_name"));
            var SelectLime = SelectColor.FindElement(By.Id("native_color_name_12"));
            SelectLime.Click();

            Thread.Sleep(3000);

            var SelectQty = Driver.Instance.FindElement(By.Id("selectQuantity"));
            var SelectThree = SelectQty.FindElements(By.TagName("option"))[2];
            SelectThree.Click();

            
        }
    }
}
