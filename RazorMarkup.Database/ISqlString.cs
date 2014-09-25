using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public interface ISqlString
    {
        string ToSqlString();

        Expression ToExpression();
    }
}
