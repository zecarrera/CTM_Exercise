﻿using EnergyPage;
using EnergyPage.Pages;
using EnergyPage.Utils;
using TechTalk.SpecFlow;

namespace EnergyJourneyTests.Utils
{
    public class BaseTest : Driver
    {
        public YourSupplierPage YourSupplierPage;
        public YourEnergyPage YourEnergyPage;

        [BeforeScenario]
        public void Setup()
        {
            Initialize();
            Instance.Navigate().GoToUrl(BaseAddress);
            YourSupplierPage = new YourSupplierPage(Instance);
            YourEnergyPage = new YourEnergyPage(Instance);
        }

        [AfterScenario]
        public void TearDown()
        {
            Close();
        }
    }
}