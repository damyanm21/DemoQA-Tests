using static DemoQA.Tests.BookStoreTests.Utilities.Constants.BookDeleteFailedTestsConstants;

namespace DemoQA.Tests.BookStoreTests
{
    /// <summary>
    /// 8. Remove an invalid book from a user's collection.
    /// </summary>
    [TestFixture]
    public class BookDeleteFailedTests
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
        public void DeleteBookByISBN_InvalidBookISBN_Failed()
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Delete);

            request.AddJsonBody(new
            {
                isbn = InvalidBookIsbn,
                userId = ValidUserId
            });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.False);

            // Print the response status description for validating the unsuccessful deleting of invalid book.
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{TestCompletedWithStatus}{response.IsSuccessStatusCode}");
        }
    }
}
