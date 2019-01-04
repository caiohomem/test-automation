﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomationFramework.Generators;

namespace TestAutomationFramework
{
    public class TopNavigationPage
    {
        [FindsBy(How = How.LinkText, Using = "About")]
        private IWebElement aboutLink;

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement homeLink;

        [FindsBy(How = How.LinkText, Using = "Contact")]
        private IWebElement contactLink;

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement registerLink;

        [FindsBy(How = How.PartialLinkText, Using = "Hello ")]
        private IWebElement emailLink;

        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement logOutLink;

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement logInLink;

        public void About()
        {
            aboutLink.Click();
        }

        public void Home()
        {
            homeLink.Click();
        }

        public void Contact()
        {
            contactLink.Click();
        }

        public void Register()
        {
            registerLink.Click();
        }

        public bool LoggedInAsLastRegisteredUser()
        {
            if (!emailLink.Exists())
                return false;
            return emailLink.Text.Contains(UserGenerator.LastGeneratedUser.EmailAddress);
        }

        public void LogOut()
        {
            if (logOutLink.Exists())
                logOutLink.Click();
        }

        public void LogIn()
        {
            logInLink.Click();
        }

        public bool IsLoggedIn()
        {
            return emailLink.Exists();
        }

        public void ManageAccount()
        {
            emailLink.Click();
        }
    }
}