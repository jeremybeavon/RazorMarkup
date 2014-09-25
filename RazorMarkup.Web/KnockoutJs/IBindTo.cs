using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.KnockoutJs
{
    public interface IBindTo<TModel>
    {
        IBindTo<TModel> Text<TResult>(Expression<Func<TModel, KnockoutObservable<TResult>>> bindingExpression);

        IBindTo<TModel> Text<TResult>(Expression<Func<KnockoutObservable<TResult>>> bindingExpression);

        IBindTo<TModel> Foreach<TResult>(Expression<Func<TModel, KnockoutObservableArray<TResult>>> bindingExpression);

        IBindTo<TModel> Foreach<TResult>(Expression<Func<KnockoutObservableArray<TResult>>> bindingExpression);

        IBindTo<TModel> Visible(Expression<Func<TModel, KnockoutObservable<bool>>> bindingExpression);

        IBindTo<TModel> Visible(Expression<Func<KnockoutObservable<bool>>> bindingExpression);

        IBindTo<TModel> Html(Expression<Func<TModel, KnockoutObservable<string>>> bindingExpression);

        IBindTo<TModel> Html(Expression<Func<KnockoutObservable<string>>> bindingExpression);
    }
}
