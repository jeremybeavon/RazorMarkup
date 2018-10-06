using System.Collections.Generic;

namespace RazorMarkup.Powershell
{
    public sealed class PowershellCommandBuilder
    {
        public PowershellCommandBuilder(string commandName)
        {
            CommandName = commandName;
            Parameters = new List<PowershellParameterBuilder>();
        }

        public string CommandName { get; private set; }

        public IList<PowershellParameterBuilder> Parameters { get; private set; }
    }
}
