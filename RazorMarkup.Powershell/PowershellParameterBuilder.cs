using System.Linq.Expressions;

namespace RazorMarkup.Powershell
{
    public sealed class PowershellParameterBuilder
    {
        private PowershellParameterBuilder(string parameterName, bool isImplicitParameter, string value)
        {
            ParameterName = parameterName;
            IsImplicitParameter = isImplicitParameter;
            Value = value;
        }

        private PowershellParameterBuilder(string parameterName, bool isImplicitParameter, Expression expression)
        {
            ParameterName = parameterName;
            IsImplicitParameter = isImplicitParameter;
            Expression = expression;
        }

        private PowershellParameterBuilder(string parameterName)
        {
            ParameterName = parameterName;
            IsSwitchValue = true;
        }

        public string ParameterName { get; private set; }

        public bool IsImplicitParameter { get; set; }

        public bool IsSwitchValue { get; private set; }

        public Expression Expression { get; private set; }

        public string Value { get; private set; }

        public static PowershellParameterBuilder Create<T>(
            string parameterName,
            T value,
            bool isImplicitParameter = false)
        {
            return new PowershellParameterBuilder(
                parameterName,
                isImplicitParameter,
                PowershellConverter.ToPowershellText(value));
        }

        public static PowershellParameterBuilder Create<T>(
            string parameterName,
            Expression<T> expression,
            bool isImplicitParameter = false)
        {
            return new PowershellParameterBuilder(
                parameterName,
                isImplicitParameter,
                expression);
        }

        public static PowershellParameterBuilder CreateSwitch(string parameterName)
        {
            return new PowershellParameterBuilder(parameterName);
        }
    }
}
