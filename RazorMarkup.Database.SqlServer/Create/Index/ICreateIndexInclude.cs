namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexInclude : ICreateIndexWhere
    {
        ICreateIndexIncludeAnd Include(ColumnName columnName);
    }
}
