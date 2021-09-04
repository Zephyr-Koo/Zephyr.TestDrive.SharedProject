using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zephyr.TestDrive.Shared;

namespace Zephyr.TestDrive.Bot.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void GetMessage_ShouldReturnsExpectedMessage()
        {
            const string ExpectedMessage = "Hello world, bot!";

            string returnedMessage = HelloWorld.GetMessage();

            Assert.AreEqual(ExpectedMessage, returnedMessage);
        }
    }
}
