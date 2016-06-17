using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyPage
{
    public class YourSupplierPage
    {
        [FindsBy(How = How.Id, Using = "your-postcode")]
        public static IWebElement PostCodeTxt { get; set; }

        [FindsBy(How = How.Id, Using = "find-postcode")]
        public static IWebElement PostCodeFindBtn { get; set; }

        [FindsBy(How = How.Id, Using = "have-bill")]
        public static IWebElement HaveBillRadio { get; set; }

        [FindsBy(How = How.Id, Using = "no-bill")]
        public static IWebElement DoesntHaveBillRadio { get; set; }

        [FindsBy(How = How.Id, Using= "compare-gas-label")]
        public static IWebElement GasOnlyRadio { get; set; }

        [FindsBy(How = How.Id, Using = "compare-electricity-label")]
        public static IWebElement ElectricityOnlyRadio { get; set; }

        [FindsBy(How = How.Id, Using = "compare-both-label")]
        public static IWebElement GasAndElectricityRadio { get; set; }

        [FindsBy(How = How.Id, Using = "goto-your-supplier-details")]
        public static IWebElement nextBtn { get; set; }

        public static void EnterPostCode(string postCode)
        {
            PostCodeTxt.SendKeys(postCode);
        }

        public static void ClickFindPostCode()
        {
            PostCodeFindBtn.Click();
        }

        public static void SelectBillHandy(bool isBillHandy)
        {
            if (isBillHandy)
                HaveBillRadio.Click();
            else
            {
                DoesntHaveBillRadio.Click();
            }
        }

        public static void SelectItemToCompare(string itemToCompare)
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

        public static void SelectElectricityProvider(string provider)
        {
            
        }

        public static void SelectGasProvider(string provider)
        {

        }

        public static void ClickNextButton()
        {
            nextBtn.Click();
        }
    }
}