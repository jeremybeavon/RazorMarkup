using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class ForClauseVisitor<TEndType> : AbstractSqlVisitor<IEndForClause<TEndType>>
    {
        private IForClause<TEndType> forClause;

        public ForClauseVisitor(IForClause<TEndType> forClause)
        {
            this.forClause = forClause;
        }

        public override void ExplicitVisit(BrowseForClause node)
        {
            Result = forClause.For().Browse();
        }

        public override void ExplicitVisit(XmlForClause node)
        {
            IForXml<TEndType> xmlClause = forClause.For().Xml();
            foreach (XmlForClauseOption option in node.Options)
            {
                /*if (option.OptionKind.HasFlag(XmlForClauseOptions.Auto))
                    xmlForAnd = xmlClause.Auto();*/
            }
        }
    }
}
