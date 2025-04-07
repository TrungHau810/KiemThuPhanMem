using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_MWC_53_57_HauNgoc
{
    [TestClass]
    public class TestLogin_53_57_HauNgoc
    {
        [TestMethod]
        // TC1: Login thành công
        // Nhấn vào biểu tượng user -> Nhập tên đăng nhập và mật khẩu -> Ấn đăng nhập
        // Tên đăng nhập: tthau
        // Mật khẩu: trantrunghau
        public void TC1_TestLogin_53_57_HauNgoc()
        {
            // Mở trang web MWC
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/");

            // Bắt element có class là account-handle-icon (button đăng nhập)
            IWebElement login_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("account-handle-icon"));
            // Click button
            login_53_57_HauNgoc.Click();
            // Tìm ô nhập liệu tên đăng nhập
            IWebElement inputusername_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("UserName"));
            // Truyền tên đăng nhập lên
            inputusername_53_57_HauNgoc.SendKeys("tthau");
            // Tìm ô nhập liệu mật khẩu
            IWebElement inputpassword_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("Password"));
            // Truyền mật khẩu lên
            inputpassword_53_57_HauNgoc.SendKeys("trantrunghau");
            // Bắt element button đăng nhập
            IWebElement buttonLogin_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#form_login > input[type=submit]:nth-child(7)"));
            // Click đăng nhập
            buttonLogin_53_57_HauNgoc.Click();
            // Bắt element icon profile -> TC Pass/Fail
            try
            {
                IWebElement profile_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#account-handle > a"));
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        // TC2: Login không thành công do sai mật khẩu
        // Nhấn vào biểu tượng user -> Nhập tên đăng nhập và mật khẩu -> Ấn đăng nhập
        // Tên đăng nhập: tthau
        // Mật khẩu: lethiyenngoc
        public void TC2_TestLogin_53_57_HauNgoc()
        {
            // Mở trang web MWC
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/");

            // Bắt element có class là account-handle-icon (button đăng nhập)
            IWebElement login_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("account-handle-icon"));
            // Click button
            login_53_57_HauNgoc.Click();
            // Tìm ô nhập liệu tên đăng nhập
            IWebElement inputusername_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("UserName"));
            // Truyền tên đăng nhập lên
            inputusername_53_57_HauNgoc.SendKeys("tthau");
            // Tìm ô nhập liệu mật khẩu
            IWebElement inputpassword_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("Password"));
            // Truyền mật khẩu lên
            inputpassword_53_57_HauNgoc.SendKeys("lethiyenngoc");
            // Bắt element button đăng nhập
            IWebElement buttonLogin_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#form_login > input[type=submit]:nth-child(7)"));
            // Click đăng nhập
            buttonLogin_53_57_HauNgoc.Click();
            // Bắt element alert thông báo đăng nhập thất bại
            try
            {
                IWebElement profile_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("alert-danger"));
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }
    }
}
