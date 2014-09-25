﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class DetailsBinding<TModel> : AbstractFluentHtmlString, IDetailsBinding<TModel>
    {
        private readonly BindTo<TModel> binding;

        public DetailsBinding(BindTo<TModel> binding)
        {
            this.binding = binding;
        }

        public IDetailsBinding<TModel> Open<TResult>(Expression<Func<TModel, TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Open, bindingExpression);
            return this;
        }

        public IDetailsBinding<TModel> Open<TResult>(Expression<Func<TResult>> bindingExpression)
        {
            binding.AddAttribute(AngularJsAttributes.Open, bindingExpression);
            return this;
        }

        public override string ToHtmlString()
        {
            return binding.ToHtmlString();
        }
    }
}
