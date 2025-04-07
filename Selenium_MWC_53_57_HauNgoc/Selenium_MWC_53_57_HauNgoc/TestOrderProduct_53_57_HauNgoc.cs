using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Selenium_MWC_53_57_HauNgoc
{
    [TestClass]
    public class TestOrderProduct_53_57_HauNgoc
    {
        [TestMethod]
        // TC10: Đặt hàng thành công
        // Thêm sản phẩm vào giỏ hàng, sau đó tiến hành đặt hàng (do test nên không để đặt hàng thật)
        public void TC10_TestOrderProduct_53_57_HauNgoc()
        {
            // Mô phỏng giai đoạn thêm sản phẩm vào giỏ hàng
            // Mở trang web chứa sản phẩm cần thêm
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/products/dep-nu-mwc-nude--8347?c=nau");
            // Bắt nút thêm vào giỏ hàng có class là add-to-cart-link
            IWebElement buttonAddToCart_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("add-to-cart-link"));
            // Click nút thêm vào giỏ hàng
            buttonAddToCart_53_57_HauNgoc.Click();
            // Tạm ngưng 3 giây để có thể bắt được element tiếp theo
            Thread.Sleep(3000);
            // Sau đó click vào button xem giỏ hàng để mở giỏ hàng và tiến hàng đặt hàng
            // Button xem giỏ hàng có class là elementor-button
            IWebElement buttonViewCart_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("elementor-button"));
            // Click vào button xem giỏ hàng
            buttonViewCart_53_57_HauNgoc.Click();
            // Tạm dừng 5 giây
            Thread.Sleep(5000);
            // Khởi tạo đối tượng Actions để mô phỏng các hành động như rê chuột, kéo thả, click chuột,...
            Actions actions_53_57_HauNgoc = new Actions(driver_53_57_HauNgoc);
            IWebElement buttonOrder_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("btnDatHang"));
            // Sử dụng action để mô phỏng move chuột (hover)
            actions_53_57_HauNgoc.MoveToElement(buttonOrder_53_57_HauNgoc).Perform();
            Thread.Sleep(3000);
            actions_53_57_HauNgoc.Click().Perform();
            try
            {
                //Bắt pop-up có class là swal2-popup để chứng minh đặt hàng thành công -> TC: Pass
                IWebElement popup_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("swal2-popup"));
                // Bắt element nội dung của pop-up
                IWebElement textPopUp_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("swal2-html-container"));
                //Lấy text ra so sánh để trả về kết quả testcase
                if (textPopUp_53_57_HauNgoc.Text.Equals("Bạn chưa nhập thông tin nhận hàng!"))
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception)
            {
                // Không bắt được pop-up -> TC: Fail
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        // TC11: Đặt hàng không thành công do chưa có thể sản phẩm vào giỏ hàng
        // Truy cập trang giỏ hàng (mặc định chưa có sản phẩm) -> nhấn đặt hàng -> Hiển thị pop-up giỏ hàng trống -> TC Pass
        public void TC11_TestOrderProduct_53_57_HauNgoc()
        {
            // Mở trang giỏ hàng
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/cart");
            // Tạm dừng 5 giây
            Thread.Sleep(5000);
            // Khởi tạo đối tượng Actions để mô phỏng các hành động như rê chuột, kéo thả, click chuột,...
            Actions actions_53_57_HauNgoc = new Actions(driver_53_57_HauNgoc);
            IWebElement buttonOrder_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("btnDatHang"));
            // Sử dụng action để mô phỏng move chuột (hover)
            actions_53_57_HauNgoc.MoveToElement(buttonOrder_53_57_HauNgoc).Perform();
            Thread.Sleep(3000);
            actions_53_57_HauNgoc.Click().Perform();
            try
            {
                //Bắt pop-up có class là swal2-popup để chứng minh giỏ hàng trống, không thể đặt hàng -> TC: Pass
                IWebElement popup_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.ClassName("swal2-popup"));
                IWebElement textPopUp_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.Id("swal2-html-container"));
                //Lấy text ra so sánh để trả về kết quả testcase
                if (textPopUp_53_57_HauNgoc.Text.Equals("Giỏ hàng trống!"))
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
            }
            catch (Exception)
            {
                // Không bắt được pop-up -> TC: Fail
                Assert.IsTrue(false);
            }
        }
    }
}
