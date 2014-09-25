using RazorMarkup.Database.SqlServer.Query.Select;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface ISubquery<TEndType> : IHideObjectMethods
    {
        ISelectClauseWithDistinct<IEndSubquery<TEndType>> Select();
    }
}
