﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EnergyPage.Pages
{
    public class Base
    {
        public IWebDriver Driver;
        public WebDriverWait Wait;

        public IWebDriver GetDriver(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return Driver;
        }

        public void WaitForElementToBeVisibleById(IWebElement element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(element.GetAttribute("id"))));
        }

 }
}