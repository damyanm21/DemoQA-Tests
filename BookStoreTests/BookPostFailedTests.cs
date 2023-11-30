using static DemoQA.Tests.BookStoreTests.Utilities.Constants.BookPostFailedTestsConstants;

namespace DemoQA.Tests.BookStoreTests
{
    /// <summary>
    /// 4. Adding an invalid book to a user's collection and validating the error.
    /// </summary>
    [TestFixture]
    public class BookPostFailedTests
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
        public void AddBookToCollection_InvalidBook_Failed()
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Post);

            request.AddJsonBody(new
            {
                userId = ValidUserId,
                collectionOfIsbns = new[] { new { isbn = InvalidIsbn } }
            });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.False);

            // Print the response status description for validating the error
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{TestCompletedWithStatus}{response.IsSuccessStatusCode}");
        }
    }
}
