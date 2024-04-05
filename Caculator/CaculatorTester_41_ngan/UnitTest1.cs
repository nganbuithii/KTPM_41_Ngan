using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Caculator;
namespace CaculatorTester_41_ngan
{
    [TestClass]
    public class UnitTest1
    {
        private Caculation_41_ngan c;

        //bai2
        public TestContext TestContext { get; set; }

        [TestInitialize] // Thiet lap du lieu dung chung cho TestCase
        public void SetUp()
        {
            c = new Caculation_41_ngan(10, 5);
        }
        [TestMethod]// TESTCASE 1: a =10 b= 5 kq=15
        public void Test_Cong_41_ngan()
        {
            int expected, actual;

            expected = 15;
            actual = c.Excute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]// TESTCASE 1: a =10 b= 5 kq=5
        public void Test_Tru_41_ngan()
        {
            int expected, actual;

            expected = 5;
            actual = c.Excute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]// TESTCASE 1: a =10 b= 5 kq=50
        public void Test_Nhan_41_ngan()
        {
            int expected, actual;

            expected = 50;
            actual = c.Excute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]// TESTCASE 1: a =10 b= 5 kq=2
        public void Test_Chia_41_ngan()
        {
            int expected, actual;

            expected = 2;
            actual = c.Excute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Caculation_41_ngan(10, 0);
            c.Excute("/");
        }

        //Liên kết Test Data với project
       [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        public void TestCongWithDatasource()
        {
            int expected, actual, a, b;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());

            expected = int.Parse(TestContext.DataRow[2].ToString());

            c = new Caculation_41_ngan(a, b);
            actual = c.Excute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataToanTu.csv", "TestDataToanTu#csv", DataAccessMethod.Sequential)]
        public void TestToanTuWithDatasource()
        {
            int expected, a, b, actual;
            string operation;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());

            operation = TestContext.DataRow[2].ToString();
            operation = operation.Remove(0, 1);

            expected = int.Parse(TestContext.DataRow[3].ToString());

            c = new Caculation_41_ngan(a, b);
            actual = c.Excute(operation);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataPower.csv", "TestDataPower#csv", DataAccessMethod.Sequential)]
        public void TestPower()
        {
            int n;
            double x,  actual, expected;
            //n = 0;
            //x = 2;

            //x = 2;
            //n = 3; 
            //expected = 1;
            n = int.Parse(TestContext.DataRow[1].ToString());
            x = double.Parse(TestContext.DataRow[0].ToString());

            expected = double.Parse(TestContext.DataRow[2].ToString());

           
            //mong muon
            actual = Caculation_41_ngan.Power(x, n);

            Assert.AreEqual(expected, actual);
        }
    }
}
