using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace Selenium_MWC_53_57_HauNgoc
{
    [TestClass]
    public class TestClickToSocial_53_57_HauNgoc
    {
        // TC8: Click link đến trang facebook MWC
        // Click vào link facebook ở cuối trang, sau đó kiểm tra url của tab đó và ra kết quả testcase
        [TestMethod]
        public void TC8_TestClickToFacebook_53_57_HauNgoc()
        {
            // Mở trang web MWC
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/");
            // Khởi tạo đối tượng Actions để mô phỏng các hành động như rê chuột, kéo thả, click chuột,...
            Actions actions_53_57_HauNgoc = new Actions(driver_53_57_HauNgoc);
            // Tìm phần tử icon Facebook trong footer bằng cách dùng CSS Selector rất cụ thể
            IWebElement buttonToFB_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#sectionInfoFooter > div > div > div:nth-child(3) > ul.navbar-social > li:nth-child(1) > a > i"));
            // Sử dụng action để mô phỏng move chuột (hover) rồi sau đó click vào element
            actions_53_57_HauNgoc.MoveToElement(buttonToFB_53_57_HauNgoc).Perform();
            // Tạm ngưng 3 giây
            Thread.Sleep(3000);
            // Sau khi tạm ngưng thì click vào phần tử
            actions_53_57_HauNgoc.Click().Perform();


            // lưu list các tab vào biến tabs
            var tabs_53_57_HauNgoc = driver_53_57_HauNgoc.WindowHandles.ToList();
            // Đổi diver sang tab mới
            driver_53_57_HauNgoc.SwitchTo().Window(tabs_53_57_HauNgoc[1]);
            //Nếu tên miền (url) có chứa facebook.com -> TC: Pass
            if (driver_53_57_HauNgoc.Url.Contains("facebook.com"))
            {
                // In url để check
                Console.WriteLine(driver_53_57_HauNgoc.Url);
                Assert.IsTrue(true);
            }
            else
            {
                // In url để check
                Console.WriteLine(driver_53_57_HauNgoc.Url);
                Assert.IsTrue(false);
            }
        }

        // TC9: Click link đến trang youtube MWC
        // Click vào link youtube ở cuối trang, sau đó kiểm tra url của tab đó và ra kết quả testcase
        [TestMethod]
        public void TC9_TestClickToYoutube_53_57_HauNgoc()
        {
            // Mở trang web MWC
            IWebDriver driver_53_57_HauNgoc = new ChromeDriver();
            driver_53_57_HauNgoc.Navigate().GoToUrl("https://mwc.com.vn/");
            // Khởi tạo đối tượng Actions để mô phỏng các hành động như rê chuột, kéo thả, click chuột,...
            Actions actions_53_57_HauNgoc = new Actions(driver_53_57_HauNgoc);
            // Tìm phần tử icon Facebook trong footer bằng cách dùng CSS Selector rất cụ thể
            IWebElement buttonToYoutube_53_57_HauNgoc = driver_53_57_HauNgoc.FindElement(By.CssSelector("#sectionInfoFooter > div > div > div:nth-child(3) > ul.navbar-social > li:nth-child(3) > a"));
            // Sử dụng action để mô phỏng move chuột (hover)
            actions_53_57_HauNgoc.MoveToElement(buttonToYoutube_53_57_HauNgoc).Perform();
            // Tạm dừng 3 giây trước khi click
            Thread.Sleep(3000);
            // Click vào phần tử
            actions_53_57_HauNgoc.Click().Perform();

            // lưu list các tab vào biến tabs
            var tabs_53_57_HauNgoc = driver_53_57_HauNgoc.WindowHandles.ToList();
            // Đổi diver sang tab mới
            driver_53_57_HauNgoc.SwitchTo().Window(tabs_53_57_HauNgoc[1]);
            //Nếu tên miền (url) có chứa facebook.com -> TC: Pass
            if (driver_53_57_HauNgoc.Url.Contains("youtube.com"))
            {
                // In url để check
                Console.WriteLine(driver_53_57_HauNgoc.Url);
                Assert.IsTrue(true);
            }
            else
            {
                // In url để check
                Console.WriteLine(driver_53_57_HauNgoc.Url);
                Assert.IsTrue(false);
            }
        }
    }
}
