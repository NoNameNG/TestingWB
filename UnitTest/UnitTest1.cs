using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        // Тестирование мозилы
        [TestMethod]
        public void Test_OpeningHomePageUsingIE()
        {
            // Инициализация драйвера
            IWebDriver driver = new FirefoxDriver();

            //Переход на сайт
            driver.Navigate().GoToUrl("https://www.wildberries.ru/");

            //Навигация по сайту
            IWebElement myLink = driver.FindElement(By.LinkText("Адреса"));
            myLink.Click();

            //Выход
            driver.Quit();

            
         }


        // Тестирование гугл хрома
        [TestMethod]
        public void Test_OpeningHomePageUsingChrome()
        {
            // Инициализация веб драйвера
            IWebDriver driver = new ChromeDriver(); ;

            //Переход на сайт
            driver.Navigate().GoToUrl("https://www.wildberries.ru/");

            //Поиск товара по сайту
            var Search = driver.FindElement(By.Id("tbSrch"));
            Search.SendKeys("levis");
            driver.FindElement(By.Id("btnSrch")).Click();

            //Выбор товара на сайте
            driver.FindElement(By.XPath("//img[@class='thumbnail']")).Click();

            //Добавление в корзину
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//label[@data-size-name='29/32']")).Click();

            driver.FindElement(By.XPath("//button[@class='c-btn-main-lg-v1 j-add-to-card']")).Click();

            //Выход
            driver.Quit();

            
         } 

    }
}
