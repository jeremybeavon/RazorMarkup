using System;
using System.Collections.Generic;

namespace RazorMarkup
{
    internal sealed class SourceCode : ISourceCode
    {
        public SourceCode(string text, ISet<string> namespaces)
        {
            Text = text;
            Namespaces = namespaces;
        }

        public string Text { get; private set; }

        public ISet<string> Namespaces { get; private set; }
    }
}
