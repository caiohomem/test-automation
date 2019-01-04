using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestAutomationFramework.Generators;

namespace TestAutomationFramework
{
    public class ManageAccountPage
    {
        [FindsBy(How = How.Id, Using = "Input_OldPassword")]
        private IWebElement currentPasswordTextField;

        [FindsBy(How = How.Id, Using = "Input_NewPassword")]
        private IWebElement newPasswordTextField;

        [FindsBy(How = How.Id, Using = "Input_ConfirmPassword")]
        private IWebElement confirmPasswordTextField;

        [FindsBy(How = How.CssSelector, Using = "button[type='submit'].btn-default")]
        private IWebElement changePasswordButton;

        [FindsBy(How = How.LinkText, Using = "Password")]
        private IWebElement tabPassword;

        public void Goto()
        {
            Pages.TopNavigation.ManageAccount();
        }

        public void ChangePassword()
        {
            currentPasswordTextField.SendKeys(UserGenerator.LastGeneratedUser.Password);
            newPasswordTextField.SendKeys(PasswordGenerator.Generate());
            confirmPasswordTextField.SendKeys(PasswordGenerator.LastGeneratedPassword);

            changePasswordButton.Click();
        }

        public void SelectTabPassword()
        {
            tabPassword.Click();
        }
    }
}