using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    public interface IFormBinding<TModel> : IFluentHtmlString
    {
        IFormBinding<TModel> Submit(Expression<Action<TModel>> bindingExpression);

        IFormBinding<TModel> Submit(Expression<Action> bindingExpression);
    }
}
