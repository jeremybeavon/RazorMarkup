using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.Builders
{
    public abstract class AbstractTableReferenceBuilder : AbstractStatementBuilder
    {
        public bool IncludeComma { get; set; }
    }
}
