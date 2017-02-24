using SystemType = System.Type;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    public interface ICreateAggregateAnd : ICreateAggregateReturns
    {
        ICreateAggregateAnd And(ParameterName parameterName, SystemType parameterType);

        //ICreateAggregateStatement And<T>(ParameterName parameterName)
        //		where T : ISqlScalarType;

        ICreateAggregateAnd And(ParameterName parameterName, TypeName typeName);
    }
}
