namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropProcedureStatement : ISqlString, IHideObjectMethods
    {
        IDropProcedureStatement And(ProcedureName procedureName);

        IDropProcedureStatement And(SchemaName schemaName, ProcedureName procedureName);
    }
}
