using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace assignment.Comm

{
    [Binding]
    public class ValidationOfSignInFunctionalitySteps:BaseClass
    {
        string expectedoutput=" ";

        [Given(@"we are on Login page")]
        public void GivenWeAreOnLoginPage()
        {
            InvokeDriver();


            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php ");
        }
        
        [When(@"Click on Sign In")]
        public void WhenClickOnSignIn()
        {
            driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();
        }
        
        
        
        
        
        

        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string email, string password)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("passwd")).SendKeys(password);
            if (email == "" && password == "")
            {
                expectedoutput = "An email address required.";
            }
            else if (password == "")
            {
                expectedoutput = "Password is required.";
            }
            else if (email == "")
            {
                expectedoutput = "An email address required.";
            }
            else
            {
                expectedoutput = "Authentication failed.";
            }

        }

        [When(@"user Click on Sign In Button")]
        public void WhenUserClickOnSignInButton()
        {
            driver.FindElement(By.Id("SubmitLogin")).Click();
        }

        [Then(@"An email address required should be visible")]
        public void ThenAnEmailAddressRequiredShouldBeVisible()
        {
            IWebElement element = driver.FindElement(By.XPath(" //*[@id='center_column']/div[1]/ol/li"));

            string actualoutput = element.GetAttribute("innerHTML");
            Assert.AreEqual(expectedoutput, actualoutput);
            driver.Quit();
        }



    }
}
    

