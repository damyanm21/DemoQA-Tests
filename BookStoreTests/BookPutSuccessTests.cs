using static DemoQA.Tests.BookStoreTests.Utilities.Constants.BookPutSuccessTestsConstants;

namespace DemoQA.Tests.BookStoreTests
{
    /// <summary>
    /// 5. Replacing the book with isbn 9781449325862 in the user's collection with book isbn 9781491904244.
    /// </summary>
    [TestFixture]
    public class BookPutSuccessTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(LogDirectory)
                .CreateLogger();

            _client = new RestClient(BaseUrl + Endpoint);
        }

        [TearDown]
        public void TearDown()
        {
            Log.CloseAndFlush();
        }

        [Test]
        public void UpdateBookIsbn_ValidData_Successful()
        {
            // Arrange
            var request = new RestRequest(NewValidIsbn, Method.Put);

            request.AddJsonBody(new { userId = ValidUserId, isbn = OldValidIsbn });

            // Act
            var response = _client.Execute(request);

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            // Print the response status description for validating the successfully updated book
            Console.WriteLine($"{Status}{response.IsSuccessStatusCode}");

            // Log the test result in a file
            Log.Information($"{TestCompletedWithStatus}{response.IsSuccessStatusCode}");
        }
    }
}
