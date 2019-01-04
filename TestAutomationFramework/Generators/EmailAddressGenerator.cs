namespace TestAutomationFramework.Generators
{
    public class EmailAddressGenerator
    {
        public static string Generate()
        {
            return new RandomData().RandomEmailAddress();
        }
    }
}