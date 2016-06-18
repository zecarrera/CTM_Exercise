using EnergyPage.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EnergyPage.Pages
{
    public class Base
    {
        public IWebDriver Driver;

        public IWebDriver GetDriver()
        {
            this.Driver = Utils.Driver.Instance;
            PageFactory.InitElements(Driver, this);
            return Driver;
        }
    }
}