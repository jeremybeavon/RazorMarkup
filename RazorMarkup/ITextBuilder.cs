using System;

namespace RazorMarkup
{
    public interface ITextBuilder
    {
        ITextBuilder Append(string text);

        ITextBuilder AppendIndent();

        IDisposable IncrementIndent();
    }
}
