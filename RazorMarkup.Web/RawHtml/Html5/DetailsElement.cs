﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class DetailsElement : AbstractHtmlElement<IDetailsElement>, IDetailsElement
    {
        public DetailsElement()
            : base("details", false)
        {
        }

        public IDetailsElement WithOpen()
        {
            return AddAttribute("open", "open");
        }
    }
}
