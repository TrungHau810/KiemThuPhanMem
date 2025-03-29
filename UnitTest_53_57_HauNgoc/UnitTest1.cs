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
        public TestContext TestContext { get; set; }


        // Các test case pass
        // TC1: Phương trình vô nghiệm
        [TestMethod]
        public void TC1_PTVoNghiem_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(6, 1, 2);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            // Kết quả mong đợi
            String expected_53_57_HauNgoc = "Phương trình vô nghiệm";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC2: Phương trình vô số nghiệm
        [TestMethod]
        public void TC2_PTVoSoNghiem_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(0, 0, 0);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "Phương trình có vô số nghiệm";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC3: Phương trình có nghiệm kép
        [TestMethod]
        public void TC3_NghiemKep_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -2, 1);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "Nghiệm kép x = 1.00";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC4: Phương trình có 2 nghiệm phân biệt
        [TestMethod]
        public void TC4_2NghiemPB_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -3, 2);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "x1 = 2.00, x2 = 1.00";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // Các test case fail
        // TC5: Phương trình có 2 nghiệm phân biệt -> Fail
        [TestMethod]
        public void TC5_2NghiemPB_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(4, -2, 5);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "x1 = 3, x2 = 2.45";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        // TC6:Phương trình có ngiệm kép -> Fail
        [TestMethod]
        public void TC6_NghiemKep_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -4, 4);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "Nghiệm kép x = 3.00";
            Assert.AreEqual(expectedResult, actualResult);
        }

        // TC7: Phương trình vô nghiệm -> Fail
        [TestMethod]
        public void TC7_PTVoNghiem_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, 2, 1);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "Phương trình vô nghiệm";
            Assert.AreEqual(expectedResult, actualResult);
        }

        // TC8: Phương trình có vô số nghiệm -> Fail
        [TestMethod]
        public void TC8_PTVoSoNghiem_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(0, 0, 0);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "Phương trình có một nghiệm duy nhất";
            Assert.AreEqual(expectedResult, actualResult);
        }

        // TC9: Phương trình có 2 nghiệm phân biệt -> Fail
        [TestMethod]
        public void TC9_2NghiemPB_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -5, 6);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "x1 = 1.00, x2 = 2.00";
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Data drive: Đọc file CSV
        // Đọc file CSV
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_53_57_HauNgoc\DataTest_53_57_HauNgoc.csv", "DataTest_53_57_HauNgoc#csv",
            DataAccessMethod.Sequential)]

        [TestMethod]

        public void TC10_53_57_HauNgoc_TestWithDataSource()
        {
            //Đọc giá trị a (cột 1)
            int a_53_57_HauNgoc = int.Parse(TestContext.DataRow[0].ToString());
            //Đọc giá trị b (cột 2)
            int b_53_57_HauNgoc = int.Parse(TestContext.DataRow[1].ToString());
            // Đọc giá trị c (cột 3)
            int c_53_57_HauNgoc = int.Parse(TestContext.DataRow[2].ToString());

            // Giải phương trình với a, b, c
            PTBac2_53_57_HauNgoc ptb2_53_57_HauNgoc = new PTBac2_53_57_HauNgoc(a_53_57_HauNgoc,b_53_57_HauNgoc,c_53_57_HauNgoc);
            string actual_53_57_HauNgoc = ptb2_53_57_HauNgoc.Solve_53_57_HauNgoc();


            // Đọc kết quả mong muốn từ CSV
            string expected_53_Hau = TestContext.DataRow[3].ToString().Trim();

            // Nếu nghiệm có dấu phẩy (nghĩa là có 2 nghiệm phân biệt)
            if (expected_53_Hau.Contains(","))
            {
                var expectedSet = new HashSet<string>(expected_53_Hau.Split(',').Select(x => x.Trim()));
                var actualSet = new HashSet<string>(actual_53_57_HauNgoc.Split(',').Select(x => x.Trim()));

                CollectionAssert.AreEquivalent(expectedSet.ToList(), actualSet.ToList());
            }
            else
            {
                Assert.AreEqual(expected_53_Hau, actual_53_57_HauNgoc);
            }


            //// Xử lý expected
            //if (expected_53_Hau.Contains("|")){
            //    // Tách | trong chuỗi
            //    string[] temp_53_57_HauNgoc = expected_53_Hau.Split('|');
            //    //
            //    string x1_53_57_HauNgoc = temp_53_57_HauNgoc[0].Trim();
            //    string x2_53_57_HauNgoc = temp_53_57_HauNgoc[1].Trim();
            //    expected_53_Hau = $"x1 = {x1_53_57_HauNgoc}, x2 = {x2_53_57_HauNgoc}";
            //}
            //// Kiểm tra kết quả mong muốn và kết quả đạt được
            //Assert.AreEqual(expected_53_Hau, actual_53_57_HauNgoc);
        }


    }
}
