using System.Linq.Expressions;

namespace RazorMarkup
{
    public static class SourceCodeBuilder
    {
        public static ISourceCode ToSourceCode(SourceCodeBuilderSettings settings, Expression expression)
        {
            return SourceCodeExpressionBuilder.ToSourceCode(settings, expression);
        }
    }
}
