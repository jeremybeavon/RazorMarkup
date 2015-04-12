namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal interface ICommonTableSampleWithSystem : ICommonTableSample
    {
        ICommonTableSample System();
    }
}
