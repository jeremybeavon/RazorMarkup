namespace RazorMarkup.Database.SqlServer.Create.Type.TableConstraints
{
    public interface ICreateTypeColumnAnd : ICreateTypeEndColumn
    {
        ICreateTypeAscendingOrDescending And(ColumnName columnName);
    }
}
