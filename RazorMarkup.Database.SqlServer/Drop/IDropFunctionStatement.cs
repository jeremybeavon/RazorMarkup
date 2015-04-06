namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropFunctionStatement : ISqlString, IHideObjectMethods
    {
        IDropFunctionStatement And(FunctionName functionName);
    }
}
