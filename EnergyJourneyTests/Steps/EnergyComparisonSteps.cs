using System;
using EnergyJourneyTests.Utils;
using EnergyPage;
using EnergyPage.Utils;
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

        [Given(@"I have entered a post code (.*)")]
        public void GivenIHaveEnteredAPostCode(string postCode)
        {
            YourSupplierPage.EnterPostCode(postCode);
            YourSupplierPage.ClickFindPostCode();
        }

        [Given(@"I have entered the bill handy (.*)")]
        public void GivenIHaveEnteredTheBillHandy(bool isBillHandy)
        {
            YourSupplierPage.SelectBillHandy(isBillHandy);
        }

        [Given(@"I have selected what to compare (.*)")]
        public void GivenIHaveSelectedWhatToCompare(string itemToCompare)
        {
            YourSupplierPage.SelectItemToCompare(itemToCompare);
        }

        [Given(@"I have selected my gas supplier (.*)")]
        public void GivenIHaveSelectedMyGasSupplier(string provider)
        {
            YourSupplierPage.SelectGasProvider(provider);
        }

        [Given(@"I have selected my electricity supplier (.*)")]
        public void GivenIHaveSelectedMyElectricitySupplier(string provider)
        {
            YourSupplierPage.SelectElectricityProvider(provider);
        }

        [When(@"I click next")]
        public void WhenIClickNext()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Your Energy Form is displayed")]
        public void ThenYourEnergyFormIsDisplayed(Table table)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
