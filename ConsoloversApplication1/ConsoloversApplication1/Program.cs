namespace ConsoloversApplication1
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using ConsoLovers.ConsoleToolkit.Core;

    /// <summary>Entry point of the console application</summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class Programm
    {
        public static void Main(string[] args)
        {
            var application = ConsoleApplicationManager.For<ConsoloversApplication1Application>().Run(args);
            if (application.Arguments.WaitForKey)
                Console.ReadLine();
        }
    }
}
