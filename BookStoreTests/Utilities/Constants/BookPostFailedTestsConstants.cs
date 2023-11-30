namespace DemoQA.Tests.BookStoreTests.Utilities.Constants
{
    public static class BookPostFailedTestsConstants
    {
        public const string BaseUrl = "https://demoqa.com";
        public const string Endpoint = "/BookStore/BookStoreV1BooksPost";
        public const string LogDirectory = "Logs/bookstorePostTestLogs.txt";

        public const string ValidUserId = "453cf0ff-d3be-47b3-9d98-7712e99318ad";
        public const string InvalidIsbn = "123";

        public const string Status = "Response Status: ";
        public const string TestCompletedWithStatus = "Adding invalid book to a user's collection test completed with status: ";
    }
}
