using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    internal class CreateAssemblyPermissionSet : AbstractStatement<CreateAssemblyStatementBuilder>,
        ICreateAssemblyPermissionSet
    {
        public CreateAssemblyPermissionSet(CreateAssemblyStatementBuilder statement)
            : base(statement)
        {
        }

        public ISqlString ExternalAccess()
        {
            Statement.PermissionSet = "EXTERNAL_ACCESS";
            Statement.Append((ICreateAssemblyPermissionSet input) => input.ExternalAccess());
            return this;
        }

        public ISqlString Safe()
        {
            Statement.PermissionSet = "SAFE";
            Statement.Append((ICreateAssemblyPermissionSet input) => input.Safe());
            return this;
        }

        public ISqlString Unsafe()
        {
            Statement.PermissionSet = "UNSAFE";
            Statement.Append((ICreateAssemblyPermissionSet input) => input.Unsafe());
            return this;
        }
    }
}
