using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    public interface IAnchorBinding<TModel> : IFluentHtmlString
    {
        void Click(Expression<Action<TModel>> bindingExpression);

        void Click(Expression<Action> bindingExpression);
    }
}
