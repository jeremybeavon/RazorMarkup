using SystemType = System.Type;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    public interface ICreateAggregateReturns
    {
        ICreateAggregateExternalName Returns(SystemType parameterType);

        ICreateAggregateExternalName Returns(TypeName typeName);
    }
}
