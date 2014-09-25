using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyAnd : ICreateAssemblyWithPermissionSet
    {
        ICreateAssemblyWithPermissionSet And(Expression<Func<SqlVarbinary>> assemblyBits);

        ICreateAssemblyWithPermissionSet And(string location);
    }
}
