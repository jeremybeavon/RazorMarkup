using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyAnd : ICreateAssemblyWithPermissionSet
    {
        ICreateAssemblyAnd And(Expression<Func<SqlVarbinary>> assemblyBits);

        ICreateAssemblyAnd And(string location);
    }
}
