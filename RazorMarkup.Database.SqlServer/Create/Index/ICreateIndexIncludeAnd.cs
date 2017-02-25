namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexIncludeAnd : ICreateIndexWhere
    {
        ICreateIndexIncludeAnd And(ColumnName columnName);
    }
}
