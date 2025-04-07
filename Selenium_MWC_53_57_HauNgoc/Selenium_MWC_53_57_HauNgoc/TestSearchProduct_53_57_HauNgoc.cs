using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_MWC_53_57_HauNgoc
{
    [TestClass]
    public class TestSearchProduct_53_57_HauNgoc
    {
        // TC3: Tìm kiếm sản phẩm - Tìm thấy sản phẩm có chứa từ khoá
        // Nhập từ khoá cần tìm sẽ hiển thị các sản phẩm có tên chứa từ khoá
        // Từ khoá tìm kiếm là giày thể thao
        [TestMethod]
        public void TC3_TestSearchProduct_53_57_HauNgoc()
        {
            // Mở trang web MWC
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/");
            // Bắt element thanh tìm kiếm có class là searchInput
            IWebElement searchInput_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("searchInput"));
            searchInput_53_57_HauNgoc.Click();
            // Truyền từ khoá cần tìm kiếm vào thanh tìm kiếm
            searchInput_53_57_HauNgoc.SendKeys("Giày thể thao");
            Thread.Sleep(2000);
            // Nhấn enter sau khi nhập từ khoá để bắt đầu tìm kiếm
            searchInput_53_57_HauNgoc.SendKeys(Keys.Enter);
            try
            {
                IWebElement categoryTitle_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#main > section > div > div > div > div.col-12.col-lg-9 > div.category-product-list > div > div:nth-child(1)"));
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        // TC4: Tìm kiếm sản phẩm - Tìm không thấy sản phẩm có chứa từ khoá
        // Nhập từ khoá cần tìm và không hiển thị sản phẩm nào
        // Từ khoá tìm kiếm là abc
        [TestMethod]
        public void TC4_TestSearchProduct_53_57_HauNgoc()
        {
            // Mở trang web MWC
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/");
            // Bắt element thanh tìm kiếm có class là searchInput
            IWebElement searchInput_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("searchInput"));
            searchInput_53_57_HauNgoc.Click();
            // Truyền từ khoá cần tìm kiếm vào thanh tìm kiếm
            searchInput_53_57_HauNgoc.SendKeys("abc");
            Thread.Sleep(2000);
            // Nhấn enter sau khi nhập từ khoá để bắt đầu tìm kiếm
            searchInput_53_57_HauNgoc.SendKeys(Keys.Enter);
            try
            {
                // Kỳ vọng là không tìm thấy sản phẩm -> không bắt được element bên dưới 
                IWebElement categoryTitle_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#main > section > div > div > div > div.col-12.col-lg-9 > div.category-product-list > div > div:nth-child(1)"));
                // Bắt được element -> TC: Fail
                Assert.IsTrue(false);
            }
            catch (Exception)
            {
                // Không bắt được element -> TC: True
                Assert.IsTrue(true);
            }

        }
    }
}
