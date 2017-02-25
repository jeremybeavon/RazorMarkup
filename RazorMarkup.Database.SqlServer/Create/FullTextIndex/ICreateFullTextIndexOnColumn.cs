namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexOnColumn : ICreateFullTextIndexOnColumnLanguage
    {
        ICreateFullTextIndexOnColumnLanguage TypeColumn(string typeColumnName);
    }
}
