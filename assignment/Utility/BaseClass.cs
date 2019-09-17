using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment
{
   public class BaseClass
    {
        public IWebDriver driver;
        public void InvokeDriver()
        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           

        }
         
        public void CloseDriver()
        {

            driver.Close();
        }


        

        
        
    }
}
