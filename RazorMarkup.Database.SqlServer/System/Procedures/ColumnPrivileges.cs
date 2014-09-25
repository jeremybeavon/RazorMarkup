using System.Collections.Generic;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Procedures
{
    public abstract class ColumnPrivileges
    {
        public static readonly ProcedureName ProcedureName = new ProcedureName("sp_column_privileges");
    }
}
