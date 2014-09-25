using System;

namespace RazorMarkup.Common
{
    public sealed class CompilationException : Exception
    {
        public CompilationException(string message)
            : base(message)
        {
        }
    }
}
