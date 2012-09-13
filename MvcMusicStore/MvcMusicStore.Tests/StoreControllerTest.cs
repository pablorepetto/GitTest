﻿using MvcMusicStore.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Tests
{
    
    
    /// <summary>
    ///This is a test class for StoreControllerTest and is intended
    ///to contain all StoreControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StoreControllerTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
        
        /// <summary>
        ///A test for Index
        ///</summary>
        [TestMethod()]
        public void IndexTest()
        {
            StoreController target = new StoreController();
            string expected = "Hello from Store.Index()";
            string actual;
            actual = target.Index();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GenreMenu
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void GenreMenuTest()
        {
            StoreController target = new StoreController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.GenreMenu();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Details
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void DetailsTest()
        {
            StoreController target = new StoreController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Details(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Browse
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        public void BrowseTest()
        {
            StoreController target = new StoreController(); // TODO: Initialize to an appropriate value
            string genre = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Browse(genre);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
