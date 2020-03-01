using System;
using TechTalk.SpecFlow;
using ClassLibrary1.Base;
using ClassLibrary1.Page;
using OpenQA.Selenium;


namespace ClassLibrary1.Step
{
    [Binding]
    [Scope(Tag = "regression")]
    public class TescologinSteps:Setup

    {
        public IWebDriver Browser;
            public Tescopage signin;
        [Given(@"I navigate to Tesco website")]
        public void GivenINavigateToTescoWebsite()
        {
            Browser = Driver;
            signin = new Tescopage(Browser);
            signin.Navigatemethod();
        }
        
        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            signin.ClickSignin();
        }
        
        [When(@"I entered the userdetails")]
        public void WhenIEnteredTheUserdetails()
        {
            signin.userdetails();
        }
        
        [Then(@"I am able to sign in Tesco")]
        public void ThenIAmAbleToSignInTesco()
        {
            signin.VerifyPageload();
        }
    }
}
