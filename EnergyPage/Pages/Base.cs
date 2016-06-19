﻿using System;
using EnergyPage.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace EnergyPage.Pages
{
    public class Base
    {
        public IWebDriver Driver;
        public WebDriverWait Wait;

        public IWebDriver GetDriver()
        {
            Driver = Utils.Driver.Instance;
            PageFactory.InitElements(Driver, this);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            return Driver;
        }

  }
}