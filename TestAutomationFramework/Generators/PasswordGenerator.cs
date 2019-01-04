using System.Web.Security;

namespace TestAutomationFramework.Generators
{
    public static class PasswordGenerator
    {
        private static bool toggle = true;

        public static string Generate()
        {
            string password = Membership.GeneratePassword(50, 10);

            //var password = "";
            //password = toggle ? "Password" : "New Password";

            toggle = !toggle;
            LastGeneratedPassword = password;
            return password;
        }

        public static string LastGeneratedPassword { get; set; }
    }
}