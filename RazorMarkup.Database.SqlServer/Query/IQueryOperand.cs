using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IQueryOperand<TEndType> : IHideObjectMethods
    {
        ISelectClauseWithDistinct<TEndType> Select();

        IQueryOperand<IQueryOperatorGroupEnd<TEndType>> BeginOperatorGroup();
    }
}
