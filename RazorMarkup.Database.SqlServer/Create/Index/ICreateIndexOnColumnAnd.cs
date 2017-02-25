namespace RazorMarkup.Database.SqlServer.Create.Index
{
    public interface ICreateIndexOnColumnAnd : ICreateIndexInclude
    {
        ICreateIndexOnColumnAscendingOrDescending And(ColumnName columnName);
    }
}
