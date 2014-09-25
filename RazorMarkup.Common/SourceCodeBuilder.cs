using System.Linq.Expressions;

namespace RazorMarkup.Common
{
    public static class SourceCodeBuilder
    {
        public static ISourceCode ToSourceCode(SourceCodeBuilderSettings settings, Expression expression)
        {
            return SourceCodeExpressionBuilder.ToSourceCode(settings, expression);
        }
    }
}
