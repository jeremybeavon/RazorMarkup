using RazorMarkup.Database.SqlServer.Create.Type.ComputedColumns;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeComputedColumnOption : ICreateTypeAnd
    {
        ICreateTypePrimaryKeyOrUnique PrimaryKey();

        ICreateTypePrimaryKeyOrUnique Unique();

        ICreateTypeAnd Check(Expression<Func<bool>> logicalExpression);
    }
}
