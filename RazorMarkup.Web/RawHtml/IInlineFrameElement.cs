﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInlineFrameElement : IHtmlElement<IInlineFrameElement>
    {
        IInlineFrameElement WithHeight(int pixels);

        IInlineFrameElement WithName(string name);

        IInlineFrameElement WithUrl(string url);

        IInlineFrameElement WithWidth(int pixels);
    }
}
