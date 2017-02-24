namespace RazorMarkup.Database.SqlServer.Create.Type.ComputedColumns
{
    public interface ICreateTypePrimaryKeyOrUnique : ICreateTypeWith
    {
        ICreateTypeWith Clustered();

        ICreateTypeWith NonClustered();
    }
}
