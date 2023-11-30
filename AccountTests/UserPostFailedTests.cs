using static DemoQA.Tests.AccountTests.Utilities.Constants.UserPostFailedTestsConstants;

namespace DemoQA.Tests.AccountTests
{
    /// <summary>
    /// 1. Different errors when creating a new user.
    /// </summary>
    [TestFixture]
    public class UserPostFailedTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(LogDirectory)
                .CreateLogger();

            _client = new RestClient(BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            Log.CloseAndFlush();
        }

        [TestCase(InvalidPasswordNoNonAlphanumeric, false, Description = NoNonAlphanumericDescription)]
        [TestCase(InvalidPasswordNoDigit, false, Description = PasswordNoDigitDescription)]
        [TestCase(InvalidPasswordNoUppercase, false, Description = PasswordNoUppercaseDescription)]
        [TestCase(InvalidPasswordNoLowercase, false, Description = PasswordNoLowercaseDescription)]
        [TestCase(InvalidPasswordTooShort, false, Description = PasswordTooShortDescription)]
        public void CreateUserAccount_InvalidPasswordScenarios_Failed(string password, bool expectedResult)
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Post);

            request.AddJsonBody(new { userName = InvalidPasswordTestUser, password });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.EqualTo(expectedResult));

            // Print the response status description for validating the failed user creation
            Console.WriteLine($"{Status} {response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{UserCreationTestsFor}{password}{CompletedWithStatus}{response.IsSuccessStatusCode}");
        }

        [Test]
        public void CreateUserAccount_MissingUserName_Failed()
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Post);
            request.AddJsonBody(new { password = MissingUsernameTestPassword });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.False);

            // Print the response status description for validating the failed user creation
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{MissingUsernameTestCompleted}{response.IsSuccessStatusCode}");
        }

        [Test]
        public void CreateUserAccount_MissingPassword_Failed()
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Post);
            request.AddJsonBody(new { userName = MissingPasswordTestUsername });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.False);

            // Print the response status description for validating the failed user creation
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{MissingPasswordTestCompleted}{response.IsSuccessStatusCode}");
        }
    }
}