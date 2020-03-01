using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace ClassLibrary1.Page
{

    public class Tescopage

    {
        public IWebDriver driver;
        public Tescopage(IWebDriver Driver)
        {
            driver = Driver;
            PageFactory.InitElements(driver, this);
        }
        //test1
        //test3
        public void Navigatemethod()
        {
            driver.Navigate().GoToUrl("https://www.tesco.com/");
        }
        public void ClickSignin()
        {
            SigninButton.Click();
        }
        [FindsBy(How = How.CssSelector, Using = ".link-text")]
        public IWebElement SigninButton;
        public void userdetails()
        {
            Username.SendKeys("pv_gangwal@yahoo.co.uk");
            Task.Delay(2000).Wait();
            Password.SendKeys("Tia1156v");
            Task.Delay(2000).Wait();
            Signin.Click();
            Task.Delay(2000).Wait();

        }
        [FindsBy(How = How.CssSelector, Using = "#username")]
        public IWebElement Username;
        [FindsBy(How = How.CssSelector, Using = "#password")]
        public IWebElement Password;
        [FindsBy(How = How.CssSelector, Using = "#sign-in-form > button > span")]  
        public IWebElement Signin;
        public void VerifyPageload()
        {
            button.Displayed.Should().BeTrue();
        }
        [FindsBy(How = How.CssSelector, Using = " #content")]
        public IWebElement button;



    }    }