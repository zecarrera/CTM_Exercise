using EnergyPage;
using EnergyPage.Pages;
using EnergyPage.Utils;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Utils
{
    public class BaseTest : Driver
    {
        public YourSupplierPage YourSupplierPage;

        [BeforeScenario]
        public void Setup()
        {
            Initialize();
            Instance.Navigate().GoToUrl(BaseAddress);
            YourSupplierPage = new YourSupplierPage();
        }

        [AfterScenario]
        public void TearDown()
        {
            Close();
        }
    }
}