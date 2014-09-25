namespace RazorMarkup.Database.SqlServer.Query.Option
{
    public interface IQueryHintOptimizeForVariable : IHideObjectMethods
    {
        IQueryHintOptimizeForAnd Unknown();

        IQueryHintOptimizeForAnd Equal(object literal);
    }
}
