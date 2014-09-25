namespace RazorMarkup.Database.SqlServer.Query.Option
{
    public interface IQueryHintOptimizeFor : IHideObjectMethods
    {
        IQueryHintAnd Unknown();

        IQueryHintOptimizeForVariable Variable(VariableName variableName);
    }
}
