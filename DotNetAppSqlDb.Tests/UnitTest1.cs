using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetAppSqlDb.Controllers;
using System.Web.Mvc;

namespace DotNetAppSqlDb.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new TodosController();
            var result = controller.Details(1) as ViewResult;
            Assert.AreEqual("Details", result.ViewBag.Title);
        }
    }
}
