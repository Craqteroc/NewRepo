using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnitTestEasy;

namespace USqlCSharpUdoUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Sum_AandB_Res()
        {
            int a = 100;
            int b = 200;
            int res = 300;

            ClassSum s = new ClassSum();

            int act = s.Sum(a, b);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void Multiplication()
        {
            int a = 5;
            int b = 200;
            int res = 1000;

            ClassSum s = new ClassSum();

            int act = s.Multiplication(a, b);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void Division()
        {
            int a = 10;
            int b = 2;
            int res = 5;

            ClassSum s = new ClassSum();

            int act = s.Division(a, b);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void Multiplication_And_Sum()
        {
            int a = 10;
            int b = 2;
            int c = 5;
            int res = 20;

            ClassSum s = new ClassSum();

            int act = s.Mult_Sum(a, b, c);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void Multiplication_And_Division()
        {
            int a = 10;
            int b = 4;
            int c = 2;
            int res = 12;

            ClassSum s = new ClassSum();

            int act = s.Mult_Div(a, b, c);


            Assert.AreEqual(res, act);
        }

        [TestMethod]
        public void Subtraction()
        {
            int a = 10;
            int b = 2;
            
            int res = 8;

            ClassSum s = new ClassSum();

            int act = s.Subtraction(a, b);


            Assert.AreEqual(res, act);
        }
    }
}
