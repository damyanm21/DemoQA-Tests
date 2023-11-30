namespace DemoQA.Tests.BookStoreTests.Utilities.Constants
{
    public static class BookDeleteSuccessTestsConstants
    {
        public const string BaseUrl = "https://demoqa.com";
        public const string Endpoint = "/swagger/BookStore/BookStoreV1BookDelete";
        public const string LogDirectory = "Logs/bookstoreDeleteTestLogs.txt";

        public const string ValidUserId = "453cf0ff-d3be-47b3-9d98-7712e99318ad";
        public const string ValidIsbn = "9781449325862";
        public const string Status = "Response Status: ";
        public const string TestCompletedWithStatus = "Remove a valid book from a user's collection test completed with status: ";
    }
}
