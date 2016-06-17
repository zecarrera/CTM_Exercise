using System;
using EnergyPage;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Steps
{
    [Binding]
    public class EnergyComparisonSteps
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

        [Given(@"I have navigated to energy comparison page")]
        public void GivenIHaveNavigatedToEnergyComparisonPage()
        {
            Driver.Navigate();
        }
        
        [Then(@"the page's title should be  (.*)")]
        public void ThenThePageSTitleShouldBeEnergy_CompareGasAndElectricitySuppliersCompareTheMarket(string expectedTitle)
        {
            Assert.That(EnergyComparePage.GetPageTitle(), Is.EqualTo(expectedTitle));
        }
    }
}
