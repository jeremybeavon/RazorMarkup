using SystemType = System.Type;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    public interface ICreateAggregateStatement
    {
        ICreateAggregateAnd WithParameter(ParameterName parameterName, SystemType parameterType);

        /*ICreateAggregateStatement WithParameter<T>(ParameterName parameterName)
        		where T : ISqlScalarType;*/

        ICreateAggregateAnd WithParameter(ParameterName parameterName, TypeName typeName);
    }
}
