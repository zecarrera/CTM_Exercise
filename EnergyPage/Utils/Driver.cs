﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EnergyPage.Utils
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return ConstantUtils.Url; }
        }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            Instance.Manage().Window.Maximize();
            
        }


        public static void Close()
        {
            //Instance.Close();
            Instance.Quit();
        }

        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }
    }
}