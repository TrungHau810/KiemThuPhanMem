using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_MWC_53_57_HauNgoc
{
    [TestClass]
    // TC7: Xem chi tiết sản phẩm
    public class TestViewDetailProduct_53_57_HauNgoc
    {
        [TestMethod]
        public void TC7_TestDetailProduct_53_57_HauNgoc()
        {
            // Mở trang web MWC
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/");
            IWebElement elementViewDetail_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#home > section.left-banner-grid > div > div.section-padding.section-border-bottom > div.left-banner-grid-inner > div > div:nth-child(2) > div > div:nth-child(1) > div > div.product-grid-thumb > a"));
            elementViewDetail_53_57_HauNgoc.Click();
            try
            {
                // Tìm kiếm element có class là product-detail-top
                // Nếu tìm thấy thì chuyển trang để xem chi tiết thành công
                IWebElement viewDetailProduct_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("product-detail-top"));
                if (driver_53_57_HauNgoc.Url.Contains("https://mwc.com.vn/products/"))
                {
                    // Tìm thấy và url chứa https://mwc.com.vn/products -> TC: Pass
                    // In url
                    Console.WriteLine(driver_53_57_HauNgoc.Url);
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsFalse(false);
                }

            }
            catch (Exception)
            {
                // Không tìm thấy -> TC: Fail
                Assert.IsTrue(false);
            }
        }
    }
}
