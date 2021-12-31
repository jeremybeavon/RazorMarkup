using RazorMarkup.Database.SqlServer.Types;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyAnd : ICreateAssemblyWithPermissionSet
    {
        ICreateAssemblyAnd And(Expression<Func<SqlVarbinary>> assemblyBits);

        ICreateAssemblyAnd And(string location);
    }
}
