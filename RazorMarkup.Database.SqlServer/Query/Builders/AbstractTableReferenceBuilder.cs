using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    public abstract class AbstractTableReferenceBuilder : AbstractStatementBuilder
    {
        protected AbstractTableReferenceBuilder(ExpressionBuilder expressionBuilder)
            : base(expressionBuilder)
        {
        }

        public bool IncludeComma { get; set; }
    }
}
