using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                // to go to this url
                driver.Url = "http://facebook.com";

                //maximize the browser
                driver.Manage().Window.Maximize();

                //set Implicit Time Wait as well
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                //extract "username or email" field from the login page and entered the provided email there
                driver.FindElement(By.Id("email")).SendKeys("enter your email");

                //extract "password" field and entered the provided password and press enter (keyboard)
                driver.FindElement(By.Id("pass")).SendKeys("password" + Keys.Enter);

                // extract the profile element and click 
                driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/']")).Click();

                //extract the "Friends" tab and click 
                driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/friends']")).Click();

                // verify

                //this variable contains true if the mentioned element is displayed
                bool a = driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/friends']")).Displayed;

                //information about the element returned by FindElement
                Console.WriteLine(driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/friends']")));

                //just to check
                Console.WriteLine(a == true);

                //assert 
                Assert.AreEqual(a, true);

                //assert
                Assert.IsTrue(a); // preferable
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception encountered : " + e);
            }
            finally
            {

                //closes the browser
                driver.Close();

                //most important step
                driver.Quit();
            }
        }
    }
}
