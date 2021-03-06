using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Zephyr.TestDrive.Shared.Tests
{
    [TestClass]
    public class TestsBase
    {
        [TestInitialize]
        public void Setup()
        {
            // Output current compilation symbol used for each test might be useful?
#if Human
            Console.WriteLine("Executing test in Human context...");
#elif Bot
            Console.WriteLine("Executing test in Bot context...");
#else
            Console.WriteLine("Executing test in Unknown context...");
#endif
        }
    }
}
