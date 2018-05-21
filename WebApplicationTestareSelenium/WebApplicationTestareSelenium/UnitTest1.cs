using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebApplicationTestareSelenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdminLogin()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@123456");
                driver.FindElement(By.Id("btnLogin")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
                wait.Until(wt => wt.FindElement(By.Id("logoutForm")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication/test.png",ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void TeacherLogin()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Email")).SendKeys("profu@exemplu.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("btnLogin")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
                wait.Until(wt => wt.FindElement(By.Id("logoutForm")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void StudentLogin()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Email")).SendKeys("student@yahoo.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("btnLogin")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.Id("logoutForm")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
        [TestMethod]
        public void StudentLoginWrongPassword()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Email")).SendKeys("student@yahoo.com");
                driver.FindElement(By.Id("Password")).SendKeys("ParolaIncorecta");
                driver.FindElement(By.Id("btnLogin")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
                wait.Until(wt => wt.FindElement(By.ClassName("validation-summary-errors text-danger")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void LaunchForgotPasswordPage()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
               // driver.FindElement(By.Id("ForgotPasswordClass")).Click();
                driver.FindElement(By.PartialLinkText("Forgot your password?")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
                wait.Until(wt => wt.FindElement(By.Id("EmailLink")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }
    }
}
