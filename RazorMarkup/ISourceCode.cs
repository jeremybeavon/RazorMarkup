using System.Collections.Generic;

namespace RazorMarkup
{
    public interface ISourceCode
    {
        ISet<string> Namespaces { get; }

        string Text { get; }
    }
}
