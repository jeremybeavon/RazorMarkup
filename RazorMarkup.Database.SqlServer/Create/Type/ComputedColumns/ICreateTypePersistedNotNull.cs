namespace RazorMarkup.Database.SqlServer.Create.Type.ComputedColumns
{
    public interface ICreateTypePersistedNotNull : ICreateTypeComputedColumnOption
    {
        ICreateTypeComputedColumnOption NotNull();
    }
}
