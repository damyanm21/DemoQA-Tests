using static DemoQA.Tests.AccountTests.Utilities.Constants.UserPostSuccessTestsConstants;

namespace DemoQA.Tests.AccountTests
{
    /// <summary>
    /// 2. Creating a new user and validating that it's created.
    /// </summary>
    [TestFixture]
    public class UserPostSuccessTests
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

        [Test]
        [TestCase(LowercaseUsername, Description = LowercaseUsernameDescription)]
        [TestCase(PascalcaseUsername, Description = PascalcaseUsernameDescription)]
        [TestCase(LowercaseUsernameWithNumbers, Description = LowercaseUsernameWithNumbersDescription)]
        [TestCase(PascalcaseUsernameWithNumbers, Description = PascalcaseUsernameWithNumbersDescription)]
        [TestCase(PascalcaseUsernameWithNumbersAndUnderscore, Description = PascalcaseUsernameWithNumbersAndUnderscoreDescription)]
        [TestCase(UsernameWithSpace, Description = UsernameWithSpaceDescription)]
        [TestCase(UppercaseUsername, Description = UppercaseUsernameDescription)]
        [TestCase(SingleCharacterUsername, Description = SingleCharacterUsernameDescription)]
        [TestCase(SingleNumberUsername, Description = SingleNumberUsernameDescription)]
        [TestCase(SingleSymbolUsername, Description = SingleSymbolUsernameDescription)]
        [TestCase(SpaceOnlyUsername, Description = SpaceOnlyUsernameDescription)]
        public void CreateUserAccount_ValidCredentials_Successful(string userName)
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Post);

            request.AddJsonBody(new { userName, password = ValidPassword });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.True, $"{UserCreationTestFor} {userName} {CompletedWithStatus} {response.Content}");

            // Print the response status description for validating the successfully added user
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result using logger
            Log.Information($"{UserCreationTestFor}{userName}{CompletedWithStatus}{response.IsSuccessStatusCode}");
        }
    }
}
