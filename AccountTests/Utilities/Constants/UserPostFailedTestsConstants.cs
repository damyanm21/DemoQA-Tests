using NUnit.Framework.Internal;
using System.Reflection;

namespace DemoQA.Tests.AccountTests.Utilities.Constants
{
    public static class UserPostFailedTestsConstants
    {
        public const string BaseUrl = "https://demoqa.com";
        public const string Endpoint = "/Account/AccountV1UserPost";
        public const string LogDirectory = "Logs/userPostFailedTestLogs.txt";

        public const string InvalidPasswordNoNonAlphanumeric = "InvalidPassword123";
        public const string InvalidPasswordNoDigit = "InvalidPassword@";
        public const string InvalidPasswordNoUppercase = "invalidpassword123@";
        public const string InvalidPasswordNoLowercase = "INVALIDPASSWORD123@";
        public const string InvalidPasswordTooShort = "P@ss1";
        public const string NoNonAlphanumericDescription = "No Non-Alphanumeric Character";
        public const string PasswordNoDigitDescription = "No Digit";
        public const string PasswordNoUppercaseDescription = "No Uppercase";
        public const string PasswordNoLowercaseDescription = "No Lowercase";
        public const string PasswordTooShortDescription = "Password Too Short";
        public const string InvalidPasswordTestUser = "testuser";

        public const string MissingUsernameTestPassword = "Password_123@";

        public const string MissingPasswordTestUsername = "testuser";

        public const string Status = "Response Status:";
        public const string UserCreationTestsFor = "User creation tests for '";
        public const string CompletedWithStatus = "' completed with status: " ;
        public const string MissingUsernameTestCompleted = "User creation with missing username test completed with status: ";
        public const string MissingPasswordTestCompleted = "User creation with missing password test completed with status: ";
    }
}
