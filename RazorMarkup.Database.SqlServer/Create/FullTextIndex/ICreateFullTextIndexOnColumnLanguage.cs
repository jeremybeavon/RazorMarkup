namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexOnColumnLanguage : ICreateFullTextIndexOnColumnStatisticalSemantics
    {
        ICreateFullTextIndexOnColumnStatisticalSemantics Language(string languageTerm);
    }
}
