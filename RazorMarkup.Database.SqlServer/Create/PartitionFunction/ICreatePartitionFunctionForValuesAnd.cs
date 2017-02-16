using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.PartitionFunction
{
    public interface ICreatePartitionFunctionForValuesAnd : ISqlString
    {
        ICreatePartitionFunctionForValuesAnd And(Expression<Func<object>> boundaryValue);
    }
}
