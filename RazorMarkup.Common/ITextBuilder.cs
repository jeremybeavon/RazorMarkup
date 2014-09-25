using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Common
{
    public interface ITextBuilder
    {
        ITextBuilder Append(string text);

        ITextBuilder AppendIndent();

        IDisposable IncrementIndent();
    }
}
