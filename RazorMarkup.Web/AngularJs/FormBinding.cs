﻿using System;
using System.Linq.Expressions;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class FormBinding<TModel> : AbstractFluentHtmlString, IFormBinding<TModel>
    {
        private readonly BindTo<TModel> binding;

        public FormBinding(BindTo<TModel> binding)
        {
            this.binding = binding;
        }

        public IFormBinding<TModel> Submit(Expression<Action<TModel>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Submit, bindingExpression);
            return this;
        }

        public IFormBinding<TModel> Submit(Expression<Action> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Submit, bindingExpression);
            return this;
        }

        public override string ToHtmlString()
        {
            return binding.ToHtmlString();
        }
    }
}
