using System;
using EnergyJourneyTests.Utils;
using EnergyPage;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Steps
{
    [Binding]
    public class EnergyComparisonSteps:BaseTest
    {

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
