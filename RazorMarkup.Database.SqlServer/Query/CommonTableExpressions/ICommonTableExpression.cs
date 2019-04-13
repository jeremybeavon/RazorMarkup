using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query.CommonTableExpressions
{
    public interface ICommonTableExpression<TEndType> : IHideObjectMethods
    {
        IQueryOperand<TEndType> As();
    }
}
