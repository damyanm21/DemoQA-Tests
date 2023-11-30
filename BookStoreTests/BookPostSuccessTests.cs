using static DemoQA.Tests.BookStoreTests.Utilities.Constants.BookPostSuccessTestsConstants;

namespace DemoQA.Tests.BookStoreTests
{
    /// <summary>
    /// 3. Adding a valid book to a user's collection and validating it.
    /// </summary>
    [TestFixture]
    public class BookPostSuccessTests
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
        public void AddBookToCollection_ValidData_Successful()
        {
            // Arrange
            var request = new RestRequest(Endpoint, Method.Post);

            request.AddJsonBody(new
            {
                userId = ValidUserId,
                collectionOfIsbns = new[] { new { isbn = ValidIsbn } }
            });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.IsSuccessful, Is.True);

            // Print the response status description for validating the successfully added book
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{TestCompletedWithStatus}{response.IsSuccessStatusCode}");
        }
    }
}
