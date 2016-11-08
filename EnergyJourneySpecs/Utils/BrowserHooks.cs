using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Utils
{
    [Binding]
    public class BrowserHooks
    {
        private readonly BrowserContext browserContext;

        public BrowserHooks(BrowserContext browserContext)
        {
            this.browserContext = browserContext;
        }

        [AfterTestRun]
        public static void CloseBrowser()
        {
            BrowserContext.Quit();
        }

        [AfterScenario]
        public void HandleWebErrors()
        {
            if (ScenarioContext.Current.TestError != null && browserContext.IsInitialized)
            {
                browserContext.TakeScreenshot();
                CloseBrowser(); // restart browser in case of an error
            }
        }
    }
}