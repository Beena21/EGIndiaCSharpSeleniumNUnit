using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_training.Selenium
{
    internal class FileDownload_copy
    {
        IWebDriver driver;
        string downloadPath = "C:\\Users\\belro\\Downloads";

        [SetUp]
        public void StartBrowser()
        {
            // Configure the web driver manager to set up the Firefox capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            // Set Firefox preferences for file download
            FirefoxOptions options = new FirefoxOptions();
            options.SetPreference("browser.download.folderList", 2);
            options.SetPreference("browser.download.dir", downloadPath);
            options.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream");

            // Initialize the web driver
            driver = new FirefoxDriver(options);

            // Launch the Firefox browser
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase1()
        {
            // Find the file link and click to download
            IWebElement fileLink = driver.FindElement(By.LinkText("image.png"));
            fileLink.Click();

            // Wait for the file to be downloaded
            Thread.Sleep(5000);

            // Verify the file is downloaded
            string filePath = Path.Combine(downloadPath, "image.png");
            Assert.IsTrue(File.Exists(filePath), "File not downloaded.");

            // Clean up the downloaded file
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}