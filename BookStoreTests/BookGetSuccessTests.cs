using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static DemoQA.Tests.BookStoreTests.Utilities.Constants.BookGetSuccessTestsConstants;

namespace DemoQA.Tests.BookStoreTests
{
    /// <summary>
    /// 6. Validating that book with isbn 9781491904244 has 278 pages.
    /// </summary>
    [TestFixture]
    public class BookGetSuccessTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(LogDirectory)
                .CreateLogger();

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url + BookIsbn);
        }

        [Test]
        public void CheckBookPages_ValidIsbn_Successful()
        {
            // Arrange
            IWebElement pagesElement = driver.FindElement(By.CssSelector($"{PagesWrapper} {UserNameValue}"));

            // Act
            string totalPagesText = pagesElement.Text;

            // Assert
            int.TryParse(totalPagesText, out int totalPages);
            Assert.AreEqual(278, totalPages);

            // Print the response status description for validating the failed user creation
            Console.WriteLine($"{TotalPagesForBook}{BookIsbn}: {totalPages}");

            // Log the test result in a file
            Log.Information($"{TotalPagesForBook}{BookIsbn}: {totalPages}");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}