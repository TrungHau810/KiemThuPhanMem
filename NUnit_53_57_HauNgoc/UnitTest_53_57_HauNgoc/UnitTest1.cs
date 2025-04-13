using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GiaiPhuongTrinhBac2_53_57_HauNgoc;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest_53_57_HauNgoc
{
    [TestClass]
    public class UnitTest1
    {
        // Tạo đối tượng TestContext
        // TestContext cho phép test sử dụng dữ liệu từ bên ngoài như CSV, Excel
        public TestContext TestContext { get; set; }

        //====================== CÁC TEST CASE PASS =======================

        // Trở thành PT bậc nhất: a khác 0
        // TC1: a = 0, b ≠ 0 => phương trình bậc nhất có nghiệm -> TC: Pass
        [TestMethod]
        public void TC1_PTBacNhatCoNghiem_53_57_HauNgoc_Pass()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 0, b = 2, c = -4
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(0, 2, -4);
            // Gọi hàm giải đê có kết quả thực tế
            String actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            string expected_53_57_HauNgoc = "x = 2";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC2: a = 0, b = 0, c ≠ 0 => Phương trình bậc nhất
        // => Phương trình vô nghiệm -> TC: Pass
        [TestMethod]
        public void TC2_PTBacNhatVN_53_57_HauNgoc_Pass()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 0, b = 0, c = 5
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(0, 0, 5);
            // Gọi hàm giải đê có kết quả thực tế
            String actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            String expected_53_57_HauNgoc = "Phuong trinh vo nghiem";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC3: a = 0, b = 0, c = 0 => Phương trình bậc nhất
        // => Phương trình có vô số nghiệm -> TC: Pass
        [TestMethod]
        public void TC3_PTBacNhatVSN_53_57_HauNgoc_Pass()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 0, b = 0, c = 0
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(0, 0, 0);
            // Gọi hàm giải đê có kết quả thực tế
            String actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            String expected_53_57_HauNgoc = "Phuong trinh co vo so nghiem";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        //Phương trình bậc 2: a khác 0
        // TC4: Phương trình bậc 2 có delta < 0 -> Phương trình vô nghiệm -> TC: Pass
        [TestMethod]
        public void TC4_PTB2VoNghiem_53_57_HauNgoc_Pass()
        {
            // // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 6, b = 1, c = 2
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(6, 1, 2);
            // Gọi hàm giải để có kết quả thực tế
            String actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Kết quả mong đợi
            String expected_53_57_HauNgoc = "Phuong trinh vo nghiem";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC5: Phương trình bậc 2 có delta = 0 -> Phương trình có nghiệm kép -> TC: Pass
        [TestMethod]
        public void TC5_PTB2NghiemKep_53_57_HauNgoc_Pass()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 1, b = -2, c = 1
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(1, -2, 1);
            // Gọi hàm giải đê có kết quả thực tế
            String actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            String expected_53_57_HauNgoc = "Nghiem kep x = 1";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC6: Phương trình bậc 2 có delta > 0 -> Phương trình có 2 nghiệm phân biệt -> TC: Pass 
        [TestMethod]
        public void TC6_PTB22NghiemPB_53_57_HauNgoc_Pass()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 1, b = -3, c = 2
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(1, -3, 2);
            // Gọi hàm giải đê có kết quả thực tế
            String actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            String expected_53_57_HauNgoc = "x1 = 2, x2 = 1";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        //====================== CÁC TEST CASE FAIL =======================
        // TC7: Phương trình có 2 nghiệm phân biệt -> TC: Fail
        // Kết quả mong đợi là 2 nghiệm x1 và x2, nhưng kết quả thực tế khác với kq mong đợi -> TC: Fail
        [TestMethod]
        public void TC7_2NghiemPB_53_57_HauNgoc_Fail()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 4, b = -2, c = 5
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(4, -2, 5);
            // Gọi hàm giải đê có kết quả thực tế
            String actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            String expected_53_57_HauNgoc = "x1 = 3, x2 = 2.45";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC8:Phương trình có ngiệm kép -> Fail
        // Kết quả mong đợi là nghiệm kép, nhưng kết quả thực tế khác với kq mong đợi -> TC: Fail
        [TestMethod]
        public void TC8_NghiemKep_53_57_HauNgoc_Fail()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 1, b = -4, c = 4
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(1, -4, 4);
            // Gọi hàm giải đê có kết quả thực tế
            string actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            string expected_53_57_HauNgoc = "Nghiem kep x = 3";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC9: Phương trình vô nghiệm -> Fail
        // Kết quả mong đợi là phương trình vô nghiệm, nhưng kết quả thực tế khác với kq mong đợi -> TC: Fail
        [TestMethod]
        public void TC9_PTVoNghiem_53_57_HauNgoc_Fail()
        {
            // Tạo đối tượng phương trình bậc 2
            // Truyền giá trị vào a = 1, b = 2, c = 1
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(1, 2, 1);
            // Gọi hàm giải đê có kết quả thực tế
            string actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            // Tạo biến chứa kết quả mong đợi
            string expected_53_57_HauNgoc = "Phuong trinh vo nghiem";
            // So sánh 2 kết quả
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC10: Phương trình bậc 1: Phương trình vô nghiệm -> Fail
        // Kết quả mong đợi là phương trình vô nghiệm, nhưng kết quả thực tế khác với kq mong đợi -> TC: Fail
        [TestMethod]
        public void TC10_PTBacNhatVN_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(0, 5, 2);
            string actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            string expected_53_57_HauNgoc = "Phuong trinh vo nghiem";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC11:Phương trình bậc 1: vô nghiệm .... -> Fail
        // Kết quả mong đợi là phương trình vô nghiệm, nhưng kết quả thực tế khác với kq mong đợi
        [TestMethod]
        public void TC11_PTBacNhatCoNghiem_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(0, 14, 5);
            string actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            string expected_53_57_HauNgoc = "x = 10";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC12:Phương trình bậc 1: có vô số nghiệm -> Fail
        // Kết quả mong đợi là có vô số nghiệm, nhưng kết quả thực tế khác với kq mong đợi
        [TestMethod]
        public void TC12_PTBacNhatVSN_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(0, 7, 10);
            string actual_53_57_HauNgoc = ptbac2_53_57_HauNgoc.Solve_53_57_HauNgoc();
            string expected_53_57_HauNgoc = "Phuong trinh co vo so nghiem";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        //==================================================================

        // Data drive: Đọc file CSV
        // Đọc file CSV
        [DeploymentItem(@"Data_53_57_HauNgoc\DataTest_53_57_HauNgoc.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    @"|DataDirectory|\Data_53_57_HauNgoc\DataTest_53_57_HauNgoc.csv",
    "DataTest_53_57_HauNgoc#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TC13_53_57_HauNgoc_TestWithDataSource()
        {
            // Đọc giá trị a, b, c từ CSV
            int a_53_57_HauNgoc = int.Parse(TestContext.DataRow[0].ToString());
            int b_53_57_HauNgoc = int.Parse(TestContext.DataRow[1].ToString());
            int c_53_57_HauNgoc = int.Parse(TestContext.DataRow[2].ToString());
            string expected_53_57_HauNgoc = TestContext.DataRow[3].ToString();
            // Kiểm tra cột thứ 4 còn kí tự nào không? (Trường hợp có 2 nghiệm x1 = ..., x2 = ...)
            // Nếu có thì cộng chuỗi để đạt được kết quả mong đợi đầy đủ là x1 = ..., x2 = ...
            if (!string.IsNullOrEmpty(TestContext.DataRow[4].ToString()))
            {
                expected_53_57_HauNgoc = expected_53_57_HauNgoc + ", " + TestContext.DataRow[4].ToString();
            }

            Console.WriteLine(expected_53_57_HauNgoc);

            // Giải phương trình với a, b, c
            PTBac2_53_57_HauNgoc ptb2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(a_53_57_HauNgoc, b_53_57_HauNgoc, c_53_57_HauNgoc);
            // Giải pt để có kết quả đạt được
            string actual_53_57_HauNgoc = ptb2_53_57_HauNgoc.Solve_53_57_HauNgoc();


            Console.WriteLine($"Expected: {expected_53_57_HauNgoc}, Actual: {actual_53_57_HauNgoc}");
            // So sánh 2 kết quả với nhau
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // Đọc file excel
        // Nếu file excel không được add vào project thì chỉnh path lại (DBQ). Ví dụ: DBQ=D:\\DataDriver_53_57_HauNgoc.xlsx;
        [DataSource(
            "System.Data.Odbc",
            "Driver={Microsoft Excel Driver (*.xls, *.xlsx, *.xlsm, *.xlsb)};DBQ=|DataDirectory|\\Data_53_57_HauNgoc\\DataDriver_53_57_HauNgoc.xlsx;",
            "Sheet1$",
            DataAccessMethod.Sequential)]

        [TestMethod]
        public void TC14_TestWithExcel_53_57_HauNgoc()
        {
            // Đọc giá trị a, b, c
            int a_53_57_HauNgoc = int.Parse(TestContext.DataRow[0].ToString());
            int b_53_57_HauNgoc = int.Parse(TestContext.DataRow[1].ToString());
            int c_53_57_HauNgoc = int.Parse(TestContext.DataRow[2].ToString());

            // Giải phương trình với a, b, c
            PTBac2_53_57_HauNgoc ptb2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(a_53_57_HauNgoc, b_53_57_HauNgoc, c_53_57_HauNgoc);
            string actual_53_57_HauNgoc = ptb2_53_57_HauNgoc.Solve_53_57_HauNgoc();

            // Đọc kết quả mong muốn từ Excel
            string expected_53_Hau = TestContext.DataRow[3].ToString();

            Console.WriteLine($"Expected: {expected_53_Hau}, Actual: {actual_53_57_HauNgoc}");
            // So sánh 2 kết quả: kq mong đợi và kết quả đạt được
            Assert.AreEqual(expected_53_Hau, actual_53_57_HauNgoc);
        }
    }
}
