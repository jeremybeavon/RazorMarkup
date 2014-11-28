using System;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    public interface ICreateAggregateReturns
    {
        ICreateAggregateExternalName Returns(ParameterName parameterName, Type parameterType);

        //ICreateAggregateStatement Returns<T>(ParameterName parameterName)
        //		where T : ISqlScalarType;

        ICreateAggregateExternalName Returns(ParameterName parameterName, TypeName typeName);
    }
}
