using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class InputCheckboxBinding<TModel> : AbstractFluentHtmlString, IInputCheckboxBinding<TModel>
    {
        private readonly BindTo<TModel> binding;

        public InputCheckboxBinding(BindTo<TModel> binding)
        {
            this.binding = binding;
        }

        public IInputCheckboxBinding<TModel> Value<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Value, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> Value<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Value, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> Name<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Name, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> Name<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Name, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> TrueValue<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.TrueValue, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> TrueValue<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.TrueValue, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> FalseValue<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.FalseValue, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> FalseValue<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.FalseValue, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> Change(Expression<Action<TModel>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Change, bindingExpression);
            return this;
        }

        public IInputCheckboxBinding<TModel> Change(Expression<Action> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Change, bindingExpression);
            return this;
        }

        public override string ToHtmlString()
        {
            return binding.ToHtmlString();
        }
    }
}
