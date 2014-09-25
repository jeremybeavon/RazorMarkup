using System;

namespace RazorMarkup.Database.SqlServer.Parser
{
    public sealed class ObsoleteException : Exception
    {
        public ObsoleteException(string message)
            : base(message)
        {
        }
    }
}
