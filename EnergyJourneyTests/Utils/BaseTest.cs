using EnergyPage.Pages;
using EnergyPage.Utils;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Utils
{
    public class BaseTest : Driver
    {
        public YourSupplierPage YourSupplierPage;
        public YourEnergyPage YourEnergyPage;
        public YourDetailsPage YourDetailsPage;
        public YourResultsPage YourResultsPage;

        [BeforeScenario]
        public void Setup()
        {
            Initialize();
            Instance.Navigate().GoToUrl(BaseAddress);
            YourSupplierPage = new YourSupplierPage(Instance);
            YourEnergyPage = new YourEnergyPage(Instance);
            YourDetailsPage = new YourDetailsPage(Instance);
            YourResultsPage = new YourResultsPage(Instance);
        }

        public string GetPageTitle()
        {
            return Instance.Url;
        }

        [AfterScenario]
        public void TearDown()
        {
            Close();
        }
    }
}