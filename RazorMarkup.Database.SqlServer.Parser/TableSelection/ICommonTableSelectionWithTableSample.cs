namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSelectionWithTableSample : ICommonTableSelectionWithTableHint
    {
        ICommonTableSampleWithSystem TableSample();
    }
}
