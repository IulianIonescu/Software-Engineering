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
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
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
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
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
                
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@12345");
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
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
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
                
                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
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
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
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
                driver.FindElement(By.Id("NewPassword")).SendKeys("Parola_2");
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
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
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
                driver.FindElement(By.Id("NewPassword")).SendKeys("Parola_2");
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
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplication1/test.png", ScreenshotImageFormat.Png);
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

                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@123456");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.PartialLinkText("UsersAdmin")).Click();
                driver.FindElement(By.PartialLinkText("Assign Teacher")).Click();

                driver.FindElement(By.Id("Email")).SendKeys("ceva4@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Parola_1");
                SelectElement selectElement =  new SelectElement(driver.FindElement(By.Name("Laboratories"))) ;         
                selectElement.SelectByText("SA");
                driver.FindElement(By.Id("assignButton")).Click();
                driver.FindElement(By.XPath("//td[text()='ceva4@example.com']"));
                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplicationTestareSelenium/test.png", ScreenshotImageFormat.Png);
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
                string button2 = "//input[@value='Save']";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@123456");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("UsersAdmin")).Click();
                driver.FindElement(By.LinkText("Edit")).Click();

                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys("userEdited@example.com");
                SelectElement selectElement = new SelectElement(driver.FindElement(By.Name("SelectedLaboratoryId")));
                selectElement.SelectByText("Micro");

                driver.FindElement(By.XPath(button2)).Click();
                driver.FindElement(By.XPath("//td[contains(.,'userEdited@example.com')]"));

                driver.Close();
                driver.Dispose();
            }
            catch
            {
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile("E:/GitHub/Software-Engineering/WebApplicationTestareSelenium/test.png", ScreenshotImageFormat.Png);
                driver.Quit();
            }
        }

        [TestMethod]
        public void TeacherDetailsFunction()
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
                driver.FindElement(By.LinkText("Details")).Click();
                driver.FindElement(By.LinkText("Back to List")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.LinkText("Details")));
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
        public void TeacherEditFromDetailsFunction()
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
                driver.FindElement(By.LinkText("Details")).Click();
                driver.FindElement(By.LinkText("Edit")).Click();

                driver.FindElement(By.Id("emailEdit")).SendKeys("accountt@example.com");
               var element = driver.FindElement(By.Name("LaboratoriesAssign"));
                var selectElement = new SelectElement(element);
                selectElement.SelectByValue("SA");
                driver.FindElement(By.ClassName("btn btn-default")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.LinkText("Details")));
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
        public void DeleteTeacherFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@12345");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("UsersAdmin")).Click();
                driver.FindElement(By.LinkText("Delete")).Click();
                driver.FindElement(By.Id("deleteButtonT")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
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
        public void CheckAboutPage()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@12345");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("About")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("aboutText")));
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
        public void CheckContactPage()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@12345");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("Contact")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.LinkText("Support@example.com")));
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
        public void AssignStudentFunction()
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

                driver.FindElement(By.LinkText("Manage Students")).Click();
                driver.FindElement(By.LinkText("Assign Student")).Click();
                driver.FindElement(By.Id("Email")).SendKeys("account@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Parola_1");
                SelectElement selectElement = new SelectElement(driver.FindElement(By.Name("Groups")));
                selectElement.SelectByText("CEN31");

                driver.FindElement(By.XPath("//input[@value='Assign']")).Click();


                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
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
        public void EditStudentFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string button2 = "//input[@value='Save']";
                string url = "http://localhost:54175/Account/Login";
               
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("profu@exemplu.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("Manage Students")).Click();
                driver.FindElement(By.LinkText("Edit")).Click();


                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys("userEdited@example.com");
                SelectElement selectElement = new SelectElement(driver.FindElement(By.Name("SelectedGroupId")));
                selectElement.SelectByText("CEN3");

                driver.FindElement(By.XPath(button2)).Click();
                driver.FindElement(By.XPath("//td[contains(.,'userEdited@example.com')]"));

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
        public void StudentDetailsFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";

                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("profu@exemplu.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("Manage Students")).Click();
                driver.FindElement(By.LinkText("Details")).Click();
                driver.FindElement(By.LinkText("Back to List")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.LinkText("Details")));
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
        public void StudentEditFromDetailsFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string button2 = "//input[@value='Save']";
                string url = "http://localhost:54175/Account/Login";

                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("profu@exemplu.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("Manage Students")).Click();
                driver.FindElement(By.LinkText("Details")).Click();
                driver.FindElement(By.LinkText("Edit")).Click();

                driver.FindElement(By.Id("Email")).Clear();
                driver.FindElement(By.Id("Email")).SendKeys("userEdited@example.com");
                SelectElement selectElement = new SelectElement(driver.FindElement(By.Name("SelectedGroupId")));
                selectElement.SelectByText("CEN3");

                driver.FindElement(By.XPath(button2)).Click();
                driver.FindElement(By.XPath("//td[contains(.,'userEdited@example.com')]"));


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
        public void DeleteStudentFunction()
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

                driver.FindElement(By.LinkText("Manage Students")).Click(); 
                driver.FindElement(By.LinkText("Delete")).Click();
                driver.FindElement(By.Id("deleteButtons")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
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
        public void AddStudentGradeFunction()
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

                driver.FindElement(By.LinkText("Manage Students")).Click();
                driver.FindElement(By.LinkText("Add Grade")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.ClassName("text-success")));
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
        public void AssignLaboratoryForTeacherFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";

                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("admin@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Admin@12345");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.PartialLinkText("UsersAdmin")).Click();
                driver.FindElement(By.PartialLinkText("Assign Teacher")).Click();

                driver.FindElement(By.Id("Email")).SendKeys("account@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Parola_1");
                SelectElement selectElement = new SelectElement(driver.FindElement(By.Name("Laboratories")));
                selectElement.SelectByText("Micro");

                driver.FindElement(By.XPath("//input[@value='Assign']")).Click();


                //var element = driver.FindElement(By.XPath("//td[contains(.,'Micro')]"));
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("//td[contains(.,'Micro')]")));

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
        public void AssignGroupForStudentFunction()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "http://localhost:54175/Account/Login";

                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();

                driver.FindElement(By.Id("Email")).SendKeys("profu@exemplu.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("btnLogin")).Click();

                driver.FindElement(By.LinkText("Manage Students")).Click();
                driver.FindElement(By.LinkText("Assign Student")).Click();

                driver.FindElement(By.Id("Email")).SendKeys("account@example.com");
                driver.FindElement(By.Id("Password")).SendKeys("Parola_1");
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Parola_1");
                SelectElement selectElement = new SelectElement(driver.FindElement(By.Name("Groups")));
                selectElement.SelectByText("CEN31");

                driver.FindElement(By.XPath("//input[@value='Assign']")).Click();

                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                wait.Until(wt => wt.FindElement(By.XPath("//td[contains(.,'CEN31')]")));

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
