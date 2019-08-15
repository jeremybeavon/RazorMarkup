using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class AnchorBinding<TModel> : AbstractFluentHtmlString, IAnchorBinding<TModel>
    {
        private readonly BindTo<TModel> binding;

        public AnchorBinding(BindTo<TModel> binding)
        {
            this.binding = binding;
        }

        public void Click(Expression<Action<TModel>> bindingExpression)
        {
            binding.AddAttribute("href", string.Empty);
            binding.Click(bindingExpression);
        }

        public void Click(Expression<Action> bindingExpression)
        {
            binding.AddAttribute("href", string.Empty);
            binding.Click(bindingExpression);
        }

        public override string ToHtmlString()
        {
            return binding.ToHtmlString();
        }
    }
}
