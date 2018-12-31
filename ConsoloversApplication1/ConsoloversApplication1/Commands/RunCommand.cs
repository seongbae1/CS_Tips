// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RunCommand.cs" company="KUKA Roboter GmbH">
//   Copyright (c) KUKA Roboter GmbH 2006 - 2018
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ConsoloversApplication1.Commands
{
    using System;

    using ConsoLovers.ConsoleToolkit.Core.CommandLineArguments;

    /// <summary>The command class</summary>
    /// <seealso cref="ConsoLovers.ConsoleToolkit.Core.CommandLineArguments.ICommand{RunArguments}" />
    internal class RunCommand : ICommand<RunArguments>
    {
        #region ICommand Members

        /// <summary>The logic of the <see cref="RunCommand"/></summary>
        public void Execute()
        {
            Console.WriteLine("Running for user " + Arguments.UserName);
        }

        #endregion

        #region ICommand<RunArguments> Members

        /// <summary>Gets or sets the arguments.</summary>
        public RunArguments Arguments { get; set; }

        #endregion
    }
}