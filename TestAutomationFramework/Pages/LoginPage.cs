using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomationFramework.Generators;

namespace TestAutomationFramework
{
    public class LoginPage
    {
        [FindsBy(How = How.CssSelector, Using = "input[type='email']")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.CssSelector, Using = "input[type='password']")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement logInButton;

        public void LogInAsLastRegisteredUser()
        {
            LogIn(UserGenerator.LastGeneratedUser);
        }

        public void LogInAsLastRegisteredUser(LoginOptions useLastGeneratedPassword)
        {
            var user = new User()
            {
                EmailAddress = UserGenerator.LastGeneratedUser.EmailAddress,
                Password = PasswordGenerator.LastGeneratedPassword
            };

            LogIn(user);
        }

        private void LogIn(User user)
        {
            emailAddressTextField.SendKeys(user.EmailAddress);
            passwordTextField.SendKeys(user.Password);

            logInButton.Click();
        }

        public enum LoginOptions
        {
            UseLastGeneratedPassword
        }

        public void Goto()
        {
            Pages.TopNavigation.LogIn();
        }
    }
}