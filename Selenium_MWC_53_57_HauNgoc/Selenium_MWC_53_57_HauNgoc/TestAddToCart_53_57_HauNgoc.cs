using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_MWC_53_57_HauNgoc
{
    [TestClass]
    public class TestAddToCart_53_57_HauNgoc
    {
        // TC5: Thêm sản phẩm vào giỏ hàng thành công
        // Mở trang chứa sp cần thêm vào giỏ hàng -> ấn button thêm vào giỏ hàng -> Pass
        [TestMethod]
        public void TC5_TestAddToCart_53_57_HauNgoc()
        {
            // Mở trang web chứa sản phẩm cần thêm
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/products/dep-nu-mwc-nude--8347?c=nau");
            // Bắt nút thêm vào giỏ hàng có class là add-to-cart-link
            IWebElement buttonAddToCart_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("add-to-cart-link"));
            // Click nút thêm vào giỏ hàng
            buttonAddToCart_53_57_HauNgoc.Click();
            try
            {
                // Bắt thanh side bar giỏ hàng có class sidebar-cart
                IWebElement sidebarCart_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("sidebar-cart"));
                // Nếu bắt được -> TC: Pass
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                // Không bắt đươc thanh sidebar -> TC: Fail
                Assert.IsTrue(false);
            }
        }

        // TC6: Thêm sản phẩm vào giỏ hàng không thành công (Không có nút thêm vào giỏ hàng)
        // Mở trang chứa sp cần thêm vào giỏ hàng -> ấn button thêm vào giỏ hàng -> Không bắt được thanh sidebar -> Pass
        [TestMethod]
        public void TC6_TestAddToCart_53_57_HauNgoc()
        {
            // Mở trang web chứa sản phẩm cần thêm
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/products/giay-cao-got-mwc-nucg--s124?&c=den");
            try
            {
                // Bắt nút thêm vào giỏ hàng có class là add-to-cart-link
                IWebElement buttonAddToCart_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("add-to-cart-link"));
                // Click nút thêm vào giỏ hàng
                buttonAddToCart_53_57_HauNgoc.Click();

                // Bắt thanh side bar giỏ hàng có class sidebar-cart
                IWebElement sidebarCart_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("sidebar-cart"));
                // Nếu bắt được -> TC: Fail
                Assert.IsTrue(false);
            }
            catch (Exception)
            {
                // Không bắt được -> TC: Pass
                Assert.IsTrue(true);
            }
        }
    }
}