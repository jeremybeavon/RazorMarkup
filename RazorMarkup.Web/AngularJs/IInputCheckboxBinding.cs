using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.AngularJs
{
    public interface IInputCheckboxBinding<TModel> : IFluentHtmlString
    {
        IInputCheckboxBinding<TModel> Value<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> Value<TResult>(Expression<Func<TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> Name<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> Name<TResult>(Expression<Func<TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> TrueValue<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> TrueValue<TResult>(Expression<Func<TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> FalseValue<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> FalseValue<TResult>(Expression<Func<TResult>> bindingExpression);

        IInputCheckboxBinding<TModel> Change(Expression<Action<TModel>> bindingExpression);

        IInputCheckboxBinding<TModel> Change(Expression<Action> bindingExpression);
    }
}
