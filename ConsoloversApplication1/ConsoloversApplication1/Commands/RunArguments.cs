// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RunArguments.cs" company="KUKA Roboter GmbH">
//   Copyright (c) KUKA Roboter GmbH 2006 - 2018
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ConsoloversApplication1.Commands
{
    using ConsoLovers.ConsoleToolkit.Core.CommandLineArguments;

    /// <summary>The arguments for the <see cref="RunCommand"/></summary>
    internal class RunArguments
    {
        #region Public Properties

        [Argument("UserName", "un")]
        public string UserName { get; set; }

        #endregion
    }
}