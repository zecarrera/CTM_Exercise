using EnergyJourneyTests.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyPage.Pages
{
    public class YourResultsPage:Base
    {
        private readonly BrowserContext browserContext;

        public YourResultsPage(BrowserContext bc)
        {
            browserContext = bc;
        }

        [FindsBy(How = How.Id, Using = "price-panels-container")]
        public IWebElement ResultsGrid { get; set; }


        public bool IsResultsPageLoaded()
        {
            WaitForElementToBeVisibleById(ResultsGrid);
            return ResultsGrid.Displayed;
        }
    }
}