using System;
using System.Collections.Generic;

namespace RazorMarkup.Common
{
    public interface ISourceCode
    {
        ISet<string> Namespaces { get; }

        string Text { get; }
    }
}
