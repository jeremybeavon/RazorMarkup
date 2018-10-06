using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace RazorMarkup.Powershell
{
    public abstract class AbstractPowershellCommand
    {
        protected AbstractPowershellCommand(string commandName)
        {
            CommandBuilder = new PowershellCommandBuilder(commandName);
        }

        public PowershellCommandBuilder CommandBuilder { get; private set; }

        public void AddParameter<T>(T value, [CallerMemberName]string parameterName = null)
        {
            CommandBuilder.Parameters.Add(PowershellParameterBuilder.Create(parameterName, value));
        }

        public void AddParameter<T>(Expression<T> expression, [CallerMemberName]string parameterName = null)
        {
            CommandBuilder.Parameters.Add(PowershellParameterBuilder.Create(parameterName, expression));
        }

        public void AddSwitchParameter([CallerMemberName]string parameterName = null)
        {
            CommandBuilder.Parameters.Add(PowershellParameterBuilder.CreateSwitch(parameterName));
        }

        public void AddImplicitParameter<T>(T value)
        {
            CommandBuilder.Parameters.Add(PowershellParameterBuilder.Create(null, value, true));
        }

        public void AddImplicitParameter<T>(Expression<T> value)
        {
            CommandBuilder.Parameters.Add(PowershellParameterBuilder.Create(null, value, true));
        }
    }
}
