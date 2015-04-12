namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonJoinHint
    {
        ICommonTableSource Loop();

        ICommonTableSource Hash();

        ICommonTableSource Merge();

        ICommonTableSource Remote();
    }
}
