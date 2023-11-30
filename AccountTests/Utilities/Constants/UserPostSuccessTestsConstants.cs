namespace DemoQA.Tests.AccountTests.Utilities.Constants
{
    public static class UserPostSuccessTestsConstants
    {
        public const string BaseUrl = "https://demoqa.com";
        public const string Endpoint = "/swagger/Account/AccountV1UserPost";
        public const string LogDirectory = "Logs/userPostSuccessTestLogs.txt";

        public const string LowercaseUsername = "testuser";
        public const string PascalcaseUsername = "TestUser";
        public const string LowercaseUsernameWithNumbers = "testuser123";
        public const string PascalcaseUsernameWithNumbers = "TestUser123";
        public const string PascalcaseUsernameWithNumbersAndUnderscore = "TestUser_123";
        public const string UsernameWithSpace = "Test User";
        public const string UppercaseUsername = "TESTUSER";
        public const string SingleCharacterUsername = "t";
        public const string SingleNumberUsername = "1";
        public const string SingleSymbolUsername = "@";
        public const string SpaceOnlyUsername = " ";
        public const string LowercaseUsernameDescription = "Lowercase username";
        public const string PascalcaseUsernameDescription = "Pascalcase username";
        public const string LowercaseUsernameWithNumbersDescription = "Lowercase username with numbers";
        public const string PascalcaseUsernameWithNumbersDescription = "Pascalcase username with numbers";
        public const string PascalcaseUsernameWithNumbersAndUnderscoreDescription = "Pascalcase username with numbers and underscore";
        public const string UsernameWithSpaceDescription = "Username with space";
        public const string UppercaseUsernameDescription = "Uppercase username";
        public const string SingleCharacterUsernameDescription = "Single character username";
        public const string SingleNumberUsernameDescription = "Single number username";
        public const string SingleSymbolUsernameDescription = "Single symbol username";
        public const string SpaceOnlyUsernameDescription = "Space only Username";

        public const string ValidPassword = "Password_123!";
        public const string UserCreationTestFor = "User creation test for '";
        public const string CompletedWithStatus = "' completed with status: ";

        public const string Status = "Response Status: ";
    }
}
