using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;

namespace UnitTestNoName
{
    [TestClass]
    public class UnitTestService
    {
        [TestMethod]
        public void TestMethodServiceOpen()
        {
            using (var host = new ServiceHost(typeof(NoName.NoName)))
            {
                host.Open();
            }

        }
    }
}
