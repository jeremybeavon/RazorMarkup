namespace RazorMarkup.Database.SqlServer.Create.Type.TableConstraints
{
    public interface ICreateTypeColumn : IHideObjectMethods
    {
        ICreateTypeAscendingOrDescending Column(ColumnName columnName);
    }
}
