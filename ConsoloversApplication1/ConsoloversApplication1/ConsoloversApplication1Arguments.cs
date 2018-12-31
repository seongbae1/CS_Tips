namespace ConsoloversApplication1
{
    using System.Diagnostics.CodeAnalysis;

    using ConsoLovers.ConsoleToolkit.Core.CommandLineArguments;

    using ConsoloversApplication1.Commands;

    /// <summary>The arguments for the <see cref="ConsoloversApplication1Application"/></summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    internal class ConsoloversApplication1Arguments
    {
        #region Public Properties

        [Command("Help", "?")]
        [HelpText("Command that displays this help")]
        public HelpCommand Help { get; set; }

        [Command("Run", "r", IsDefaultCommand = true)]
        [HelpText("Initial command that is executed by default")]
        public RunCommand Run { get; set; }

        [Option("WaitForKey", "wfk")]
        [HelpText("If this flag is set, the application waits for an ENTER before exiting")]
        public bool WaitForKey { get; set; }

        #endregion
    }
}