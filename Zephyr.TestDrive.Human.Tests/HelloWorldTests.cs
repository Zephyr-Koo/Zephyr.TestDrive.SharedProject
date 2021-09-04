using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zephyr.TestDrive.Shared;

namespace Zephyr.TestDrive.Human.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void GetMessage_ShouldReturnsExpectedMessage()
        {
            const string ExpectedMessage = "Hello world, human!";

            string returnedMessage = HelloWorld.GetMessage();

            Assert.AreEqual(ExpectedMessage, returnedMessage);
        }
    }
}
