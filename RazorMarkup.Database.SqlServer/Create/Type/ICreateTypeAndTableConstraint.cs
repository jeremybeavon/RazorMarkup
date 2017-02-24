using RazorMarkup.Database.SqlServer.Create.Type.TableConstraints;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.Type
{
    public interface ICreateTypeAndTableConstraint : IHideObjectMethods
    {
        ICreateTypePrimaryKeyOrUnique PrimaryKey();

        ICreateTypePrimaryKeyOrUnique Unique();

        ICreateTypeColumnOption Check(Expression<Func<bool>> logicalExpression);
    }
}
