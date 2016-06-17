using EnergyPage;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Utils
{
    public class BaseTest : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}