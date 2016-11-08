using EnergyPage.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Steps
{
    [Binding]
    public class EnergyComparisonSteps //TODO Break subpages into different step files
    {
        private readonly YourSupplierPage yourSupplierPage;
        private readonly YourEnergyPage yourEnergyPage;
        private readonly YourDetailsPage yourDetailsPage;
        private readonly YourResultsPage yourResultsPage;
        public EnergyComparisonSteps(YourSupplierPage yourSupplierPage, YourEnergyPage yourEnergyPage, YourDetailsPage yourDetailsPage, YourResultsPage yourResultsPage)
        {
            this.yourSupplierPage = yourSupplierPage;
            this.yourEnergyPage = yourEnergyPage;
            this.yourDetailsPage = yourDetailsPage;
            this.yourResultsPage = yourResultsPage;
        }

        [Given(@"I am at the energy comparison page")]
        public void GivenIAmAtTheEnergyComparisonPage()
        {
            yourSupplierPage.LoadSupplierPage();
        }

        [Given(@"I have entered a post code (.*)")]
        public void GivenIHaveEnteredAPostCode(string postCode)
        {
            yourSupplierPage.EnterPostCode(postCode);
            yourSupplierPage.ClickFindPostCode();
        }

        [Given(@"I have entered the bill handy (.*)")]
        public void GivenIHaveEnteredTheBillHandy(bool isBillHandy)
        {
            yourSupplierPage.SelectBillHandy(isBillHandy);
        }

        [Given(@"I have selected what to compare (.*)")]
        public void GivenIHaveSelectedWhatToCompare(string itemToCompare)
        {
            yourSupplierPage.SelectItemToCompare(itemToCompare);
        }

        [Then(@"Post code error is displayed")]
        public void ThenPostCodeErrorIsDisplayed()
        {
            Assert.IsTrue(yourSupplierPage.IsPostCodeErrorDisplayed());
        }


        [When(@"I click next")]
        public void WhenIClickNext()
        {
            yourSupplierPage.ClickNextButton();
        }

        [Then(@"Your Energy Form is displayed")]
        public void ThenYourEnergyFormIsDisplayed()
        {
           Assert.AreEqual(yourEnergyPage.GetFormHeading(), "Your Energy");
        }


        [Then(@"I have entered electricity usage (.*)")]
        public void ThenIHaveEnteredElectricityUsage(int usage)
        {
            yourEnergyPage.EnterElectricityUsage(usage);
        }

        [When(@"I click next at energy form")]
        public void WhenIClickNextAtEnergyForm()
        {
            yourEnergyPage.ClickNextButton();
        }

        [Then(@"Your Details Form is displayed")]
        public void ThenYourDetailsFormIsDisplayed()
        {
            Assert.AreEqual(yourEnergyPage.GetFormHeading(),"Your Preferences");
        }

        [Then(@"I select tariff type")]
        public void ThenISelectTariffType()
        {
            yourDetailsPage.SelectTariffType();
        }

        [Then(@"I select payment type")]
        public void ThenISelectPaymentType()
        {
            yourDetailsPage.SelectPaymentType();
        }

        [Then(@"I enter my email (.*)")]
        public void ThenIEnterMyEmail(string email)
        {
            yourDetailsPage.EnterEmailAddress(email);
        }

        [Then(@"I accept the terms & conditions")]
        public void ThenIAcceptTheTermsConditions()
        {
            yourDetailsPage.AcceptTerms();
        }

        [When(@"I click go to prices at Your details")]
        public void WhenIClickGoToPricesAtYourDetails()
        {
            yourDetailsPage.ClickGoToPrices();
        }

        [Then(@"Your results page is displayed")]
        public void ThenYourResultsPageIsDisplayed()
        {
            Assert.IsTrue(yourResultsPage.IsResultsPageLoaded());
        }

    }
}
