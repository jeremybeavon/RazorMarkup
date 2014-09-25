using RazorMarkup.Common;

namespace RazorMarkup.Database
{
    public static class SqlStringExtensions
    {
        public static ISourceCode ToSourceCode(this ISqlString sqlString, SourceCodeBuilderSettings settings)
        {
            return SourceCodeBuilder.ToSourceCode(settings, sqlString.ToExpression());
        }

        public static ISourceCode ToSourceCode(this ISqlString sqlString)
        {
            return sqlString.ToSourceCode(null);
        }
    }
}
