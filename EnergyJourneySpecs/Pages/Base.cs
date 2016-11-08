using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EnergyPage.Pages
{
    public class Base
    {
        public WebDriverWait Wait;

        public void WaitForElementToBeVisibleById(IWebElement element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element.GetAttribute("id"))));
        }

 }
}