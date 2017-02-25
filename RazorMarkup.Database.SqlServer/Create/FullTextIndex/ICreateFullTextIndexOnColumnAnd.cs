namespace RazorMarkup.Database.SqlServer.Create.FullTextIndex
{
    public interface ICreateFullTextIndexOnColumnAnd : ICreateFullTextIndexKeyIndex
    {
        ICreateFullTextIndexOnColumn And(ColumnName columnName);
    }
}
