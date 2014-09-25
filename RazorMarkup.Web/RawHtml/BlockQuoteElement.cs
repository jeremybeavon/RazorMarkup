﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class BlockQuoteElement : AbstractHtmlElement<IBlockQuoteElement>, IBlockQuoteElement
    {
        public BlockQuoteElement()
            : base("blockquote", false)
        {
        }

        public IBlockQuoteElement WithCite(string source)
        {
            return AddAttribute("cite", source);
        }
    }
}
