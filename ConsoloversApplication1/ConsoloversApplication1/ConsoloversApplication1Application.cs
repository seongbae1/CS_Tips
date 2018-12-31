namespace ConsoloversApplication1
{
    using ConsoLovers.ConsoleToolkit.Core;
    using ConsoLovers.ConsoleToolkit.Core.CommandLineArguments;

    /// <summary>The application logic</summary>
    /// <seealso cref="ConsoLovers.ConsoleToolkit.Core.ConsoleApplication{ConsoloversApplication1}" />
    internal class ConsoloversApplication1Application : ConsoleApplication<ConsoloversApplication1Arguments>
    {
        public ConsoloversApplication1Application(ICommandLineEngine commandLineEngine)
            : base(commandLineEngine)
        {
        }

        public override void RunWith(ConsoloversApplication1Arguments arguments)
        {
            // Only used when no command is defined
        }
    }
}