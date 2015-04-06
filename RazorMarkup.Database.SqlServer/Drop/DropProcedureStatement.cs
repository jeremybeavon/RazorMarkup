using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropProcedureStatement : SqlBuilder, IDropProcedureStatement
    {
        public DropProcedureStatement(ProcedureName procedureName)
            : base(string.Format("DROP PROCEDURE {0}", procedureName.ToSqlString()))
        {
            Initialize(() => Sql.Drop().Procedure(null), procedureName);
        }

        public IDropProcedureStatement And(ProcedureName procedureName)
        {
            Append(", ");
            Append(procedureName.ToSqlString());
            Append((IDropProcedureStatement input) => input.And(null), procedureName);
            return this;
        }
    }
}
