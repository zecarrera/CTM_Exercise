using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyPage.Pages
{
    public class YourEnergyPage:Base
    {
        public YourEnergyPage(IWebDriver driver)
        {
            Driver = GetDriver(driver);
        }

        [FindsBy(How = How.ClassName, Using = "main-heading")]
        public IWebElement MainHeadingLabel { get; set; }

        [FindsBy(How = How.Id, Using = "goto-your-energy")]
        public IWebElement NextBtn { get; set; }

        [FindsBy(How = How.Id, Using = "electricity-usage")]
        public IWebElement ElectricityUsageTxt { get; set; }
        

        public string GetFormHeading()
        {
            WaitForElementToBeVisibleById(NextBtn);
            return MainHeadingLabel.Text;
        }


        public void ClickNextButton()
        {
            NextBtn.Click();
        }

        public void EnterElectricityUsage(int usage)
        {
            ElectricityUsageTxt.SendKeys(usage.ToString());
        }
    }
}