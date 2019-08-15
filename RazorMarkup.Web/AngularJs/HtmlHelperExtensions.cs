using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace RazorMarkup.Web.AngularJs
{
    public static class HtmlHelperExtensions
    {
        public static IBindTo<TModel> BindTo<TModel>(this HtmlHelper<TModel> html)
        {
            return new BindTo<TModel>(html);
        }

        public static string BindTo<TModel, TResult>(
            this HtmlHelper<TModel> html,
            Expression<Func<TModel, TResult>> bindingExpression)
        {
            return string.Concat("{{", bindingExpression.ToHtmlString(), "}}");
        }

        public static string BindTo<TModel, TResult>(
            this HtmlHelper<TModel> html,
            Expression<Func<TResult>> bindingExpression)
        {
            return string.Concat("{{", bindingExpression.ToHtmlString(), "}}");
        }
    }
}
