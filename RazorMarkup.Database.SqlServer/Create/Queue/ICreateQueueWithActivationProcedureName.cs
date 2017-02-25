namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithActivationProcedureName : IHideObjectMethods
    {
        ICreateQueueWithActivationProcedureNameAnd ProcedureName(DatabaseName databaseName, SchemaName schemaName, ProcedureName procedureName);

        ICreateQueueWithActivationProcedureNameAnd ProcedureName(SchemaName schemaName, ProcedureName procedureName);

        ICreateQueueWithActivationProcedureNameAnd ProcedureName(DatabaseName databaseName, ProcedureName procedureName);

        ICreateQueueWithActivationProcedureNameAnd ProcedureName(ProcedureName procedureName);
    }
}
