﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.AngularJs
{
    internal sealed class InputBinding<TModel> : AbstractFluentHtmlString, IInputBinding<TModel>
    {
        private readonly BindTo<TModel> binding;

        public InputBinding(BindTo<TModel> binding)
        {
            this.binding = binding;
        }

        public IInputCheckboxBinding<TModel> Checkbox()
        {
            return new InputCheckboxBinding<TModel>(binding);
        }

        public override string ToHtmlString()
        {
            return binding.ToHtmlString();
        }
    }
}
