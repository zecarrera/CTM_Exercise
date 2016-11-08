using System;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace EnergyJourneyTests.Utils
{
    public class BrowserContext
    {
        private static Lazy<IWebDriver> webDriver = CreateLazyWebDriver();

        private static Lazy<IWebDriver> CreateLazyWebDriver()
        {
            return new Lazy<IWebDriver>(CreateWebDriver);
        }

        private static IWebDriver CreateWebDriver()
        {
            switch ((ConfigurationManager.AppSettings["Browser"] ?? "Firefox").ToLowerInvariant())
            {
                case "firefox":
                    return new FirefoxDriver();
                case "ie":
                    return new InternetExplorerDriver();
                case "chrome":
                    return new ChromeDriver();
            }

            return new FirefoxDriver();
        }

        public IWebDriver WebDriver
        {
            get { return webDriver.Value; }
        }

        public Uri BaseUrl { get; private set; }

        public BrowserContext()
        {
            BaseUrl = new Uri(ConfigurationManager.AppSettings["BaseUrl"]);
        }

        public void NavigateTo(string path)
        {
            WebDriver.Navigate().GoToUrl(GetUrl(path));
        }

        private Uri GetUrl(string path)
        {
            return new Uri(BaseUrl, path);
        }

        public static void Quit()
        {
            if (GetIsInitialized())
            {
                webDriver.Value.Quit();
                webDriver = CreateLazyWebDriver();
            }
        }

        private static bool GetIsInitialized()
        {
            return webDriver.IsValueCreated;
        }

        public bool IsInitialized
        {
            get { return GetIsInitialized(); }
        }

        public void AssertOnPath(string path)
        {
            var expectedUrl = GetUrl(path).GetLeftPart(UriPartial.Path);
            var actualUrl = new Uri(WebDriver.Url).GetLeftPart(UriPartial.Path);
            actualUrl.Should().BeEquivalentTo(expectedUrl, "browser should be on page '{0}'", path);
        }

        public void TakeScreenshot()
        {
            try
            {
                string fileNameBase = string.Format("error_{0}_{1}_{2}",
                        TestFolders.ToPath(FeatureContext.Current.FeatureInfo.Title),
                        TestFolders.ToPath(ScenarioContext.Current.ScenarioInfo.Title),
                        TestFolders.GetRawTimestamp());

                string pageSource = WebDriver.PageSource;
                string sourceFilePath = TestFolders.GetOutputFilePath(fileNameBase + "_source.html");
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));

                ITakesScreenshot takesScreenshot = WebDriver as ITakesScreenshot;

                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();
                    string screenshotFilePath = TestFolders.GetOutputFilePath(fileNameBase + "_screenshot.png");
                    screenshot.SaveAsFile(screenshotFilePath, ImageFormat.Png);

                    Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }
    }
}