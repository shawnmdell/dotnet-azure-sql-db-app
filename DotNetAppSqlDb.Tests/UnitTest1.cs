using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetAppSqlDb.Controllers;
using System.Web.Mvc;
using System.Diagnostics;
using DotNetAppSqlDb.Models;

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
            var thisTodo = (Todo)result.ViewData.Model;
            Assert.AreEqual(1, thisTodo.ID);
        //    Trace.WriteLine(result);
        }
    }
}
