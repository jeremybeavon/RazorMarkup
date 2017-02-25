namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexOnColumnStatisticalSemantics : ICreateFullTextIndexOnColumnAnd
    {
        ICreateFullTextIndexOnColumnAnd StatisticalSemantics();
    }
}
