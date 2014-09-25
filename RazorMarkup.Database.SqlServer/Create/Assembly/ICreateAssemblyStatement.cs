using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyStatement : IHideObjectMethods
    {
        ICreateAssemblyAnd From(Expression<Func<SqlVarbinary>> assemblyBits);

        ICreateAssemblyAnd From(string location);
    }
}
