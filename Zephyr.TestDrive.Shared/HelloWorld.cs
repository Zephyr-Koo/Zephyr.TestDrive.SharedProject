using System;

namespace Zephyr.TestDrive.Shared
{
    public static class HelloWorld
    {
        /// <summary>
        /// Greets user by writing hello world message into console.
        /// </summary>
        public static void Greet()
        {
            string message = GetMessage();

            Console.WriteLine(message);
        }

        /// <summary>
        ///     Returns hello world message.
        /// </summary>
        /// <remarks>
        ///     This method returns message conditionally based on
        ///     compilation symbols (DefineConstants) defined
        ///     in project file (.csproj).
        /// </remarks>
        /// <returns>A hello world message in string.</returns>
        public static string GetMessage()
        {
#if Human
            return "Hello world, human!";
#elif Bot
            return "Hello world, bot!";
#else
            return "Hello world, Mr. Unknown!";
#endif
        }
    }
}
