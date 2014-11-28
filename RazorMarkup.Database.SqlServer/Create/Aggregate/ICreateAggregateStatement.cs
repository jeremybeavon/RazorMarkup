using System;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    public interface ICreateAggregateStatement
    {
        ICreateAggregateAnd WithParameter(ParameterName parameterName, Type parameterType);

        /*ICreateAggregateStatement WithParameter<T>(ParameterName parameterName)
        		where T : ISqlScalarType;*/

        ICreateAggregateAnd WithParameter(ParameterName parameterName, TypeName typeName);
    }
}
