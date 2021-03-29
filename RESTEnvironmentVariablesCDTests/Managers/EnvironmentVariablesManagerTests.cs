using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RESTEnvironmentVariablesCD.Models;

namespace RESTEnvironmentVariablesCD.Managers.Tests
{
    [TestClass]
    public class EnvironmentVariablesManagerTests
    {
        private readonly EnvironmentVariablesManager _manager = new EnvironmentVariablesManager();

        [TestMethod]
        public void GetTest()
        {
            List<EnvironmentVariable> all = _manager.GetAll();
            Assert.IsTrue(all.Exists(variable => variable.Key == "MY_NAME"));

            EnvironmentVariable one = _manager.GetByName("MY_NAME");
            Assert.IsNotNull(one);
            Assert.AreEqual("Anders", one.Value);
        }
    }
}