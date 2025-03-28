using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GiaiPhuongTrinhBac2_53_57_HauNgoc;

namespace UnitTest_53_57_HauNgoc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TC1_PTVoNghiem_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(6, 1, 2);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "Phương trình vô nghiệm";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        [TestMethod]
        public void TC2_PTVoSoNghiem_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(0, 0, 0);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "Phương trình có vô số nghiệm";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        [TestMethod]
        public void TC3_NghiemKep_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -2, 1);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "Nghiệm kép x = 1.00";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        [TestMethod]
        public void TC4_2NghiemPB_53_57_HauNgoc_Pass()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -3, 2);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "x1 = 2.00, x2 = 1.00";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        [TestMethod]
        public void TC5_2NghiemPB_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(4, -2, 5);
            String actual_53_57_HauNgoc = ptbac2.Solve_53_57_HauNgoc();
            String expected_53_57_HauNgoc = "x1 = 3, x2 = 2.45";
            Assert.AreEqual(expected_53_57_HauNgoc, actual_53_57_HauNgoc);
        }

        [TestMethod]
        public void TC6_NghiemKep_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -4, 4);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "Nghiệm kép x = 3.00";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TC7_PTVoNghiem_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, 2, 1);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "Phương trình vô nghiệm";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TC8_PTVoSoNghiem_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(0, 0, 0);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "Phương trình có một nghiệm duy nhất";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TC9_2NghiemPB_53_57_HauNgoc_Fail()
        {
            PTBac2_53_57_HauNgoc ptbac2 = new PTBac2_53_57_HauNgoc(1, -5, 6);
            string actualResult = ptbac2.Solve_53_57_HauNgoc();
            string expectedResult = "x1 = 1.00, x2 = 2.00";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
