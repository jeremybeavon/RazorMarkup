namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithAdditionalTableHint : ICommonTableSelectionWithJoin
    {
        new ICommonTableHint And();
    }
}
