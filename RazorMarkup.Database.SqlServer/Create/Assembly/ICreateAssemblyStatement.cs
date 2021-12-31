using RazorMarkup.Database.SqlServer.Types;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Assembly
{
    public interface ICreateAssemblyStatement : IHideObjectMethods
    {
        ICreateAssemblyAnd From(Expression<Func<SqlVarbinary>> assemblyBits);

        ICreateAssemblyAnd From(string location);
    }
}
