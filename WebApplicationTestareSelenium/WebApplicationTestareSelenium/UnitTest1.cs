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
        public void TeacherLoginWrongPassword()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Email")).SendKeys("profu@exemplu.com");
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
        public void AdministratorLoginWrongPassword()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Email")).SendKeys("admin@exemple.com");
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

        [TestMethod]
        public void LaunchChangePasswordPageFromTeacherAccount()
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
                driver.FindElement(By.PartialLinkText("Hello profu!")).Click();
                driver.FindElement(By.PartialLinkText("Change your password")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.Id("changePasswordButton")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void LaunchChangePasswordPageFromStudentAccount()
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
                driver.FindElement(By.PartialLinkText("Hello student!")).Click();
                driver.FindElement(By.PartialLinkText("Change your password")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.Id("changePasswordButton")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void LaunchChangePasswordPageFromAdministratorAccount()
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
                driver.FindElement(By.PartialLinkText("Hello admin!")).Click();
                driver.FindElement(By.PartialLinkText("Change your password")).Click();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.Id("changePasswordButton")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void ChangePasswordFunctionForAdministrator()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                
                driver.FindElement(By.Id("Email")).SendKeys("admin@exemple.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@123456");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.PartialLinkText("Hello admin!")).Click();
                driver.FindElement(By.PartialLinkText("Change your password")).Click();

                driver.FindElement(By.Id("OldPassword")).SendKeys("Admin@123456");
                driver.FindElement(By.Id("NewPassword")).SendKeys("Admin@12345");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Admin@12345");
                driver.FindElement(By.Id("changePasswordButton")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void ChangePasswordFunctionForTeacher()
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

                driver.FindElement(By.PartialLinkText("Hello profu!")).Click();
                driver.FindElement(By.PartialLinkText("Change your password")).Click();

                driver.FindElement(By.Id("OldPassword")).SendKeys("Parola_1");
                driver.FindElement(By.Id("NewPassword")).SendKeys("Parola_1");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Parola_2");
                driver.FindElement(By.Id("changePasswordButton")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void ChangePasswordFunctionForStudent()
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

                driver.FindElement(By.PartialLinkText("Hello student!")).Click();
                driver.FindElement(By.PartialLinkText("Change your password")).Click();

                driver.FindElement(By.Id("OldPassword")).SendKeys("Parola_1");
                driver.FindElement(By.Id("NewPassword")).SendKeys("Parola_1");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Parola_2");
                driver.FindElement(By.Id("changePasswordButton")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void AssignTeacherFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("admin@exemple.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@123456");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.PartialLinkText("UsersAdmin")).Click();
                driver.FindElement(By.PartialLinkText("Assign Teacher")).Click();

                driver.FindElement(By.Id("emailAssign")).SendKeys("account@example.com");
                driver.FindElement(By.Id("passwordAssign")).SendKeys("account@12345");
                driver.FindElement(By.Id("confirmPasswordAssign")).SendKeys("account@12345");
                driver.FindElement(By.Name("LaboratoriesAssign"));
                var selectElement = new SelectElement(LaboratoriesAssign);
                selectElement.SelectByValue("SA");
                driver.FindElement(By.Id("assignButton")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void EditTeacherFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("admin@exemple.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@123456");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("UsersAdmin")).Click();
                driver.FindElement(By.LinkText("Edit")).Click();

                driver.FindElement(By.Id("emailEdit")).SendKeys("accountt@example.com");
                driver.FindElement(By.Name("LaboratoriesAssign"));
                var selectElement = new SelectElement(LaboratoriesAssign);
                selectElement.SelectByValue("SA");
                driver.FindElement(By.ClassName("btn btn-default")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.LinkText("Edit")));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("C:/Users/radud/OneDrive/Documents/GitHub/Software-Engineering/Software-Engineering/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

    }

}
