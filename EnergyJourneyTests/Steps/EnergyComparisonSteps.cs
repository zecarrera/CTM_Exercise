using EnergyJourneyTests.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Steps
{
    [Binding]
    public class EnergyComparisonSteps:BaseTest
    {

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

        [Then(@"Post code error is displayed")]
        public void ThenPostCodeErrorIsDisplayed()
        {
            Assert.That(YourSupplierPage.IsPostCodeErrorDisplayed(), Is.True);
        }


        [When(@"I click next")]
        public void WhenIClickNext()
        {
            YourSupplierPage.ClickNextButton();
        }

        [Then(@"Your Energy Form is displayed")]
        public void ThenYourEnergyFormIsDisplayed()
        {
           Assert.That(YourEnergyPage.GetFormHeading(), Is.EqualTo("Your Energy"));
        }


        [Then(@"I have entered electricity usage (.*)")]
        public void ThenIHaveEnteredElectricityUsage(int usage)
        {
            YourEnergyPage.EnterElectricityUsage(usage);
        }

        [When(@"I click next at energy form")]
        public void WhenIClickNextAtEnergyForm()
        {
            YourEnergyPage.ClickNextButton();
        }

        [Then(@"Your Details Form is displayed")]
        public void ThenYourDetailsFormIsDisplayed()
        {
            Assert.That(YourDetailsPage.GetFormHeading(), Is.EqualTo("Your Preferences"));
        }

        [Then(@"I select tariff type")]
        public void ThenISelectTariffType()
        {
            YourDetailsPage.SelectTariffType();
        }

        [Then(@"I select payment type")]
        public void ThenISelectPaymentType()
        {
            YourDetailsPage.SelectPaymentType();
        }

        [Then(@"I enter my email (.*)")]
        public void ThenIEnterMyEmail(string email)
        {
            YourDetailsPage.EnterEmailAddress(email);
        }

        [Then(@"I accept the terms & conditions")]
        public void ThenIAcceptTheTermsConditions()
        {
            YourDetailsPage.AcceptTerms();
        }

        [When(@"I click go to prices at Your details")]
        public void WhenIClickGoToPricesAtYourDetails()
        {
            YourDetailsPage.ClickGoToPrices();
        }

        [Then(@"Your results page is displayed")]
        public void ThenYourResultsPageIsDisplayed()
        {
            Assert.That(YourResultsPage.IsResultsPageLoaded(), Is.True);
        }

    }
}
