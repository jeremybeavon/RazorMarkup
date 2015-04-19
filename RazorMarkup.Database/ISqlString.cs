using System.ComponentModel;
using System.Linq.Expressions;

namespace RazorMarkup.Database
{
    public interface ISqlString : IHideObjectMethods
    {
        string ToSqlString();

        [EditorBrowsable(EditorBrowsableState.Never)]
        Expression ToExpression();
    }
}
