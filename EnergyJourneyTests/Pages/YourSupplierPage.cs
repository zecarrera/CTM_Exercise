using EnergyJourneyTests.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EnergyPage.Pages
{
    public class YourSupplierPage:Base
    {
        private readonly BrowserContext browserContext;
        public YourSupplierPage(BrowserContext bc)
        {
            browserContext = bc;
        }

        [FindsBy(How = How.Id, Using = "your-postcode")]
        public IWebElement PostCodeTxt { get; set; }

        [FindsBy(How = How.Id, Using = "find-postcode")]
        public IWebElement PostCodeFindBtn { get; set; }

        [FindsBy(How = How.Id, Using = "have-bill-label")]
        public IWebElement HaveBillRadio { get; set; }

        [FindsBy(How = How.Id, Using = "no-bill-label")]
        public IWebElement DoesntHaveBillRadio { get; set; }

        [FindsBy(How = How.Id, Using= "compare-gas-label")]
        public IWebElement GasOnlyRadio { get; set; }

        [FindsBy(How = How.Id, Using = "compare-electricity-label")]
        public IWebElement ElectricityOnlyRadio { get; set; }

        [FindsBy(How = How.Id, Using = "compare-both-label")]
        public IWebElement GasAndElectricityRadio { get; set; }

        [FindsBy(How = How.Id, Using = "goto-your-supplier-details")]
        public IWebElement NextBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.error.ng-binding")]
        public IWebElement PostCodeError { get; set; }

        [FindsBy(How = How.Id, Using = "gas-top-six-british-gas")]
        public IWebElement BritishGasSelector { get; set; }

        [FindsBy(How = How.Id, Using = "gas-top-six-npower")]
        public IWebElement NpowerSelector { get; set; }

        public void EnterPostCode(string postCode)
        {
            PostCodeTxt.SendKeys(postCode);
        }

        public  void ClickFindPostCode()
        {
            PostCodeFindBtn.Click();
        }

        public  void SelectBillHandy(bool isBillHandy)
        {
            WaitForElementToBeVisibleById(HaveBillRadio);
            if (isBillHandy)
                HaveBillRadio.Click();
            else
            {
                DoesntHaveBillRadio.Click();
            }
        }

        public  void SelectItemToCompare(string itemToCompare)
        {
            switch (itemToCompare.ToLower())
            {
                case "both":
                    GasAndElectricityRadio.Click();
                    break;
                case "gas only":
                    GasOnlyRadio.Click();
                    break;
                case "electricity only":
                    ElectricityOnlyRadio.Click();
                    break;
            }
        }

        public  void ClickNextButton()
        {
            WaitForElementToBeVisibleById(NextBtn);
            NextBtn.Click();
        }


        public bool IsPostCodeErrorDisplayed()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.error.ng-binding")));
            return PostCodeError.Displayed;
        }

      
    }
}