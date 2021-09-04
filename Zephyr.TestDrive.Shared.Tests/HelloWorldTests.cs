using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zephyr.TestDrive.Shared.Tests
{
    /// A raw attempt to write unit tests on codes in Shared Project.
    /// As you might have already seen, this approach can grow
    /// messy quickly for customized behaviours.
    [TestClass]
    public class HelloWorldTests : TestsBase
    {
        [TestMethod]
        public void GetMessage_ShouldReturnsExpectedMessage()
        {
#if Human
            const string ExpectedMessage = "Hello world, human!";
#elif Bot
            const string ExpectedMessage = "Hello world, bot!";
#else
            const string ExpectedMessage = "Hello world, Mr. Unknown!";
#endif
            string returnedMessage = HelloWorld.GetMessage();

            Assert.AreEqual(ExpectedMessage, returnedMessage);
        }
    }
}
