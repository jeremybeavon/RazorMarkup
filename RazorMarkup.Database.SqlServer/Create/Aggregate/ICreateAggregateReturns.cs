using System;

namespace RazorMarkup.Database.SqlServer.Create.Aggregate
{
    public interface ICreateAggregateReturns
    {
        ICreateAggregateExternalName Returns(Type parameterType);

        ICreateAggregateExternalName Returns(TypeName typeName);
    }
}
