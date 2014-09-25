using System;

namespace RazorMarkup.Database
{
    public sealed class NotInExpressionException : Exception
    {
        public NotInExpressionException()
            : base("This can only be called inside a lambda expression.")
        {
        }
    }
}
