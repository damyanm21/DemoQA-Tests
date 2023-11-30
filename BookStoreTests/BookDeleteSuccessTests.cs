using static DemoQA.Tests.BookStoreTests.Utilities.Constants.BookDeleteSuccessTestsConstants;

namespace DemoQA.Tests.BookStoreTests
{
    /// <summary>
    /// 7. Remove a valid book from a user's collection.
    /// </summary>

    [TestFixture]
    public class BookDeleteSuccessTests
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
        public void DeleteBookByISBN_Successful()
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Delete);

            request.AddJsonBody(new
            {
                isbn = ValidIsbn,
                userId = ValidUserId
            });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.True);

            // Print the response status description for validating the removed book.
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{TestCompletedWithStatus}{response.IsSuccessStatusCode}");
        }
    }
}
