using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.AngularJs
{
    public interface IAnchorBinding<TModel> : IFluentHtmlString
    {
        void Click(Expression<Action<TModel>> bindingExpression);

        void Click(Expression<Action> bindingExpression);
    }
}
