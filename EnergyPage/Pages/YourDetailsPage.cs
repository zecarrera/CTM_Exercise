using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyPage.Pages
{
    public class YourDetailsPage:Base
    {
        public YourDetailsPage(IWebDriver driver)
        {
            GetDriver(driver);
        }
        

        [FindsBy(How = How.ClassName, Using = "main-heading")]
        public IWebElement MainHeadingLabel { get; set; }

        [FindsBy(How = How.Id, Using = "email-submit")]
        public IWebElement GoToPricesBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label.fixed-rate")]
        public IWebElement FixedRateSelector { get; set; }

        [FindsBy(How = How.CssSelector, Using = "label.payment-monthly")]
        public IWebElement MonthlyPaymentSelector { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@id='terms-label']/span[2]")]
        public IWebElement TermsBox { get; set; }

        
        public string GetFormHeading()
        {
            WaitForElementToBeVisibleById(GoToPricesBtn);
            return MainHeadingLabel.Text;
        }

        public void SelectTariffType()
        {
            FixedRateSelector.Click();
        }

        public void SelectPaymentType()
        {
            MonthlyPaymentSelector.Click();
        }

        public void EnterEmailAddress(string email)
        {
            EmailTxt.SendKeys(email);
        }

        public void AcceptTerms()
        {
            TermsBox.Click();
        }

        public void ClickGoToPrices()
        {
            GoToPricesBtn.Click();
        }
    }
}