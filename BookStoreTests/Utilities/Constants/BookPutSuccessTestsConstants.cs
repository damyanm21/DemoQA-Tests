namespace DemoQA.Tests.BookStoreTests.Utilities.Constants
{
    public class BookPutSuccessTestsConstants
    {
        public const string BaseUrl = "https://demoqa.com";
        public const string Endpoint = "/swagger/BookStore/BookStoreV1BooksByISBNPut";
        public const string LogDirectory = "Logs/bookstorePutTestLogs.txt";

        public const string NewValidIsbn = "9781491904244";
        public const string ValidUserId = "453cf0ff-d3be-47b3-9d98-7712e99318ad";
        public const string OldValidIsbn = "9781449325862";

        public const string Status = "Response Status: ";
        public const string TestCompletedWithStatus = "Replacing book test completed with status: ";
    }
}
