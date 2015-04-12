namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSourceWithJoinHint : ICommonTableSource
    {
        ICommonJoinHint WithHint();
    }
}
