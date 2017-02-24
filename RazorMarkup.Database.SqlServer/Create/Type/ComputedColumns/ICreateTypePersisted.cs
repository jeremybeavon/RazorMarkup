namespace RazorMarkup.Database.SqlServer.Create.Type.ComputedColumns
{
    public interface ICreateTypePersisted : ICreateTypeComputedColumnOption
    {
        ICreateTypePersistedNotNull Persisted();
    }
}
