namespace RazorMarkup.Database.SqlServer.Create.Type.TableConstraints
{
    public interface ICreateTypePrimaryKeyOrUnique : ICreateTypeColumn
    {
        ICreateTypeColumn Clustered();

        ICreateTypeColumn NonClustered();
    }
}
