﻿namespace RazorMarkup.Web.RawHtml
{
    internal sealed class ParameterElement : AbstractHtmlElement<IParameterElement>, IParameterElement
    {
        public ParameterElement()
            : base("param", true)
        {
        }

        public IParameterElement WithName(string name)
        {
            return AddAttribute("name", name);
        }

        public IParameterElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
