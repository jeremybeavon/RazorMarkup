using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface ICommonTableExpression : IHideObjectMethods
    {
        IQueryOperand<ICommonTableExpressionEnd> As();
    }
}
