using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebDataSource.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DemoService()
        {
            WebDataSource.MessageCenter s = new MessageCenter();
            String message = s.HelloWorld();

            Assert.AreEqual(message, "Hello World");
        }
    }
}
