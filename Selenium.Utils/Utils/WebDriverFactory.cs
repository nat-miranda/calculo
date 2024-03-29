﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium.Utils
{

    //responsável por retornar as instâncias específicas
    //para interação com cada tipo de browser acessado durante os testes
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(
            Browser browser, string pathDriver)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Firefox:
                    FirefoxDriverService service =
                        FirefoxDriverService.CreateDefaultService(pathDriver);

                    webDriver = new FirefoxDriver(service);

                    break;
                case Browser.Chrome:
                    webDriver = new ChromeDriver(pathDriver);

                    break;
            }

            return webDriver;
        }
    }
}
