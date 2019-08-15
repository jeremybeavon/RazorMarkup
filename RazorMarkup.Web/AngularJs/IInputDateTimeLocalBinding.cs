using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    public interface IInputDateTimeLocalBinding<TModel> : IFluentHtmlString
    {
        IInputDateTimeLocalBinding<TModel> Value<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IInputDateTimeLocalBinding<TModel> Value<TResult>(Expression<Func<TResult>> bindingExpression);

        IInputDateTimeLocalBinding<TModel> Name<TResult>(Expression<Func<TModel, TResult>> bindingExpression);

        IInputDateTimeLocalBinding<TModel> Name<TResult>(Expression<Func<TResult>> bindingExpression);

        IInputDateTimeLocalBinding<TModel> Required();

        IInputDateTimeLocalBinding<TModel> Required(Expression<Func<TModel, bool>> bindingExpression);

        IInputDateTimeLocalBinding<TModel> Required(Expression<Func<bool>> bindingExpression);

        IInputDateTimeLocalBinding<TModel> Min(DateTime date);

        IInputDateTimeLocalBinding<TModel> Max(DateTime date);

        IInputDateTimeLocalBinding<TModel> Change(Expression<Action<TModel>> bindingExpression);

        IInputDateTimeLocalBinding<TModel> Change(Expression<Action> bindingExpression);
    }
}
