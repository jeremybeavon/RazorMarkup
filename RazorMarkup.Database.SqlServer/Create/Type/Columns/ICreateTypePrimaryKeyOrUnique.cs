namespace RazorMarkup.Database.SqlServer.Create.Type.Columns
{
    public interface ICreateTypePrimaryKeyOrUnique : ICreateTypeWith
    {
        ICreateTypeWith Clustered();

        ICreateTypeWith NonClustered();
    }
}
