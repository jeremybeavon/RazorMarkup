using System;

namespace RazorMarkup
{
    public sealed class CompilationException : Exception
    {
        public CompilationException(string message)
            : base(message)
        {
        }
    }
}
