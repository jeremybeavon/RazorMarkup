namespace RazorMarkup.Database.SqlServer.Query.Option
{
    public interface IQueryHintOptimizeForAnd : IQueryHintAnd
    {
        IQueryHintOptimizeForVariable AndVariable(VariableName variableName);
    }
}
