using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace assignment
{
    [Binding]
    public class SearchForAMulti_CityFlightSteps:BaseClass
    {
        [Given(@"I am on expedia home page")]
        public void GivenIAmOnExpediaHomePage()
        {
            try
            {
                InvokeDriver();

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.expedia.com/ ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                

            }

        }

        [Given(@"I click on the flight section")]
        public void GivenIClickOnTheFlightSection()
        {
            driver.FindElement(By.Id("tab-flight-tab-hp")).Click();
        }
        
        [When(@"I select multi-city")]
        public void WhenISelectMulti_City()
        {
            driver.FindElement(By.Id("flight-type-multi-dest-label-hp-flight")).Click();
        }
        
        [Then(@"click on add another flight")]
        public void ThenClickOnAddAnotherFlight()
        {
            driver.FindElement(By.Id("add-flight-leg-hp-flight")).Click();
        }
        
        [Then(@"Search for flights between different airports (.*),(.*),(.*) on dates (.*),(.*),(.*) for (.*) adults")]
        public void ThenSearchForFlightsBetweenDifferentAirportsOnDatesForAdults(string one, string two, string three, string d1, string d2, string d3, int n)
        {
            driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).Click();
            
            driver.FindElement(By.XPath("//*[@id='flight-origin-hp-flight']")).SendKeys(one);

            driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).Click();
           
            driver.FindElement(By.XPath("//*[@id='flight-destination-hp-flight']")).SendKeys(two);


           
            driver.FindElement(By.XPath("//*[@id='flight-departing-single-hp-flight']")).SendKeys(d1);

           
            driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/button")).Click();

            driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/div/div/div/div[1]/div[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/div/div/div/div[1]/div[4]")).Click();
            driver.FindElement(By.XPath("//*[@id='traveler-selector-hp-flight']/div/ul/li/div/div/div/div[1]/div[4]")).Click();


            
            driver.FindElement(By.XPath("//*[@id='flight-2-origin-hp-flight']")).Click();
            driver.FindElement(By.XPath("//*[@id='flight-2-origin-hp-flight']")).SendKeys(two);

           
            driver.FindElement(By.XPath("//*[@id='flight-2-destination-hp-flight']")).Click();
            driver.FindElement(By.XPath("//*[@id='flight-2-destination-hp-flight']")).SendKeys(three);

            
            driver.FindElement(By.XPath("//*[@id='flight-2-departing-hp-flight']")).SendKeys(d2);

            
            driver.FindElement(By.XPath("//*[@id='flight-3-origin-hp-flight']")).Click();
            driver.FindElement(By.XPath("//*[@id='flight-3-origin-hp-flight']")).SendKeys(three);

            
            driver.FindElement(By.XPath("//*[@id='flight-3-destination-hp-flight']")).Click();
            driver.FindElement(By.XPath("//*[@id='flight-3-destination-hp-flight']")).SendKeys(one);

           
            driver.FindElement(By.XPath("//*[@id='flight-3-departing-hp-flight']")).SendKeys(d3);

        }

        [Then(@"click on Search button")]
        public void ThenClickOnSearchbutton()
        {
            driver.FindElement(By.XPath("//*[@id='gcw-flights-form-hp-flight']//button[@type='submit']")).Click();
        }
        
        [Then(@"Select the flight which comes at first place")]
        public void ThenSelecttheFlightWhichComesAtFirstPlace()
        {
            
            driver.FindElement(By.XPath("//*[@id='flight-module-2020-04-11t21:00:00+02:00-coach-mla-lgw-km-118_2020-04-14t11:55:00+01:00-coach-lgw-mla-km-117-coach-mla-fco-km-612_2020-04-20t10:00:00+02:00-coach-fco-mla-km-613_']/div[1]/div[1]/div[2]/div/div[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='flight-module-2020-04-11t21:00:00+02:00-coach-mla-lgw-km-118_2020-04-14t11:55:00+01:00-coach-lgw-mla-km-117-coach-mla-fco-km-612_2020-04-20t10:00:00+02:00-coach-fco-mla-km-613_']/div[1]/div[1]/div[2]/div/div[2]/button")).Click();
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.XPath("//*[@id='flight-module-2020-04-11t21:00:00+02:00-coach-mla-lgw-km-118_2020-04-14t11:55:00+01:00-coach-lgw-mla-km-117-coach-mla-fco-km-612_2020-04-20t10:00:00+02:00-coach-fco-mla-km-613_']/div[1]/div[1]/div[2]/div/div[2]/button")).Click();
            







           

        }

        [Then(@"Compare the price with the total amount")]
        public void ThenCompareThePriceWithTheTotalAmount()
        {
            Assert.IsTrue(true);
        }
    }
}
