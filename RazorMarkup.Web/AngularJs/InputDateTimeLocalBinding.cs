using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class InputDateTimeLocalBinding<TModel> : AbstractFluentHtmlString, IInputDateTimeLocalBinding<TModel>
    {
        private readonly BindTo<TModel> binding;

        public InputDateTimeLocalBinding(BindTo<TModel> binding)
        {
            this.binding = binding;
        }

        public IInputDateTimeLocalBinding<TModel> Value<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Value, bindingExpression);
            return this;
        }

        public IInputDateTimeLocalBinding<TModel> Value<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Value, bindingExpression);
            return this;
        }

        public IInputDateTimeLocalBinding<TModel> Name<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Name, bindingExpression);
            return this;
        }

        public IInputDateTimeLocalBinding<TModel> Name<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Name, bindingExpression);
            return this;
        }

        public IInputDateTimeLocalBinding<TModel> Min(DateTime date)
        {
            binding.AddAttribute(AngularJsAttributes.Min, date.ToHtmlString());
            return this;
        }

        public IInputDateTimeLocalBinding<TModel> Max(DateTime date)
        {
            binding.AddAttribute(AngularJsAttributes.Max, date.ToHtmlString());
            return this;
        }

        public IInputDateTimeLocalBinding<TModel> Change(Expression<Action<TModel>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Change, bindingExpression);
            return this;
        }

        public IInputDateTimeLocalBinding<TModel> Change(Expression<Action> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Change, bindingExpression);
            return this;
        }

        public override string ToHtmlString()
        {
            return binding.ToHtmlString();
        }


        public IInputDateTimeLocalBinding<TModel> Required()
        {
            throw new NotImplementedException();
        }

        public IInputDateTimeLocalBinding<TModel> Required(Expression<Func<TModel, bool>> bindingExpression)
        {
            throw new NotImplementedException();
        }

        public IInputDateTimeLocalBinding<TModel> Required(Expression<Func<bool>> bindingExpression)
        {
            throw new NotImplementedException();
        }
    }
}
