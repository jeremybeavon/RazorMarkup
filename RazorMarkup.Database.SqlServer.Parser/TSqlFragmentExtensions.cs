using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal static class TSqlFragmentExtensions
    {
        public static TResult AcceptWithResult<TResult>(this TSqlFragment node, AbstractSqlVisitor<TResult> visitor)
        {
            node.Accept(visitor);
            return visitor.Result;
        }

        public static string GetNextIdentifier(this TSqlFragment node, int position)
        {
            while (position <= node.LastTokenIndex && node.ScriptTokenStream[position].TokenType != TSqlTokenType.Identifier)
            {
                position++;
            }

            return position <= node.LastTokenIndex ? node.ScriptTokenStream[position].Text : string.Empty;
        }

        public static string GetPreviousIdentifier(this TSqlFragment node, int position)
        {
            while (position >= node.FirstTokenIndex && node.ScriptTokenStream[position].TokenType != TSqlTokenType.Identifier)
            {
                position--;
            }

            return position >= node.FirstTokenIndex ? node.ScriptTokenStream[position].Text : string.Empty;
        }
    }
}
