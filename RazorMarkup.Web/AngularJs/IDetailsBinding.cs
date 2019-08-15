using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    public interface IDetailsBinding<TModel> : IFluentHtmlString
    {
        IDetailsBinding<TModel> Open<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IDetailsBinding<TModel> Open<TResult>(Expression<Func<TResult>> bindingExpression);
    }
}
