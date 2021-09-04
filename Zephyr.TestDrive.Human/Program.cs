using System;
using System.Reflection;
using Zephyr.TestDrive.Shared;

string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;

Console.WriteLine($"Executing logic in { assemblyName }...");
HelloWorld.Greet();

/*
 Output of top-level statements (C# 9.0 feature):
    Executing logic in Zephyr.TestDrive.Human...
    Hello world, human!
*/