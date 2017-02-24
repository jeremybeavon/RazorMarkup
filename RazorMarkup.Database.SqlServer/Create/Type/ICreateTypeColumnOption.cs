using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Create.Type.Columns;

namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeColumnOption : ICreateTypeAnd
    {
        ICreateTypeColumnOption Collate(CollationName collationName);

        ICreateTypeColumnOption Null();

        ICreateTypeColumnOption NotNull();

        ICreateTypeColumnOption Default(object expression);

        ICreateTypeColumnOption Identity();

        ICreateTypeColumnOption Identity(int seed, int increment);

        ICreateTypeColumnOption RowGuidCol();

        ICreateTypePrimaryKeyOrUnique PrimaryKey();

        ICreateTypePrimaryKeyOrUnique Unique();

        ICreateTypeColumnOption Check(Expression<Func<bool>> logicalExpression);
    }
}
