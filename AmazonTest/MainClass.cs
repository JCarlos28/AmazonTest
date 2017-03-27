using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmazonTest
{
    // Amazon test: primero abre la pagina para logearse, luego escribe el item, selecciona el item,
    //              despues de seleccionarlo busca el tamaño, color y cantidad. Luego realiza el checkout
    //              
    [TestClass]
    public class MainClass
    {
        // inicializa el browser
        [TestInitialize]
        public void init()
        {
            Driver.initialize();  
            OpenAndLogin_Class.GoTo();
            Driver.Maximizar();
            
        }
        //Primero se loge, luego selecciona el item a comprar y hace el checkout
        [TestMethod]
        public void searchItem()
        {
            OpenAndLogin_Class.UserAndPass(InputVariables.email, InputVariables.pass);
            SearchItem_Class.WritteAndSearch(InputVariables.name);
            CheckOut.PressAdd();
        }
     
        
    }
}
