using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomationFramework.Generators;

namespace TestAutomationFramework
{
    public class RegisterPage
    {
        [FindsBy(How = How.CssSelector, Using = "input[type='email']")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.Id, Using = "Input_Password")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.Id, Using = "Input_ConfirmPassword")]
        private IWebElement confirmPasswordTextField;

        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement registerButton;

        public void Goto()
        {
            Pages.TopNavigation.Register();
        }

        public void RegisterNewUser()
        {
            var user = UserGenerator.Generate();

            emailAddressTextField.SendKeys(user.EmailAddress);
            passwordTextField.SendKeys(user.Password);
            confirmPasswordTextField.SendKeys(user.Password);

            registerButton.Click();
        }
    }
}