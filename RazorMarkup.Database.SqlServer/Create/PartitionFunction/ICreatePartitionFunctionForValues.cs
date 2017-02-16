using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.PartitionFunction
{
    public interface ICreatePartitionFunctionForValues : IHideObjectMethods
    {
        ISqlString ForValues();

        ICreatePartitionFunctionForValuesAnd ForValues(Expression<Func<object>> boundaryValue);
    }
}
