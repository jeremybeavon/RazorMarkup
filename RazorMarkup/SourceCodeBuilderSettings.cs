using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace RazorMarkup
{
    public sealed class SourceCodeBuilderSettings
    {
        private string initialIndent;

        public SourceCodeBuilderSettings()
        {
            MethodsOnNewLine = new Dictionary<MethodInfo, IndentChange>();
            initialIndent = string.Empty;
        }

        public string InitialIndent
        {
            get => initialIndent;
            set => initialIndent = value ?? string.Empty;
        }

        public IDictionary<MethodInfo, IndentChange> MethodsOnNewLine { get; private set; }

        public void AddMethodOnNewLine<TObject>(Expression<Func<TObject, object>> method, IndentChange indentChange)
        {
            MethodCallExpression methodCall = method.Body as MethodCallExpression;
            if (methodCall == null)
            {
                throw new ArgumentException("expression must be method call", nameof(method));
            }
        }
    }
}
