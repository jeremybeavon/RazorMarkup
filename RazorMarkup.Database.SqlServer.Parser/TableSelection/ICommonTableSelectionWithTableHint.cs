namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithTableHint : ICommonTableSelectionWithJoin
    {
        ICommonTableHint WithHint();
    }
}
