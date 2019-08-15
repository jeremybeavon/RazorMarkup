using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser.Query.GroupBy
{
    internal abstract class AbstractGroupBy : ICommonGroupBy
    {
        private readonly object groupBy;

        public AbstractGroupBy(object groupBy)
        {
            this.groupBy = groupBy;
        }

        public virtual ICommonGroupBy GroupBy(Expression<Func<object>> expression)
        {
            throw new NotSupportedException();
        }

        public virtual ICommonGroupBy Group(IList<GroupingSpecification> arguments)
        {
            throw new NotSupportedException();
        }

        public virtual ICommonGroupBy Cube(IList<GroupingSpecification> arguments)
        {
            throw new NotSupportedException();
        }

        public virtual ICommonGroupBy Rollup(IList<GroupingSpecification> arguments)
        {
            throw new NotSupportedException();
        }

        public virtual ICommonGroupBy GrandTotal()
        {
            throw new NotSupportedException();
        }

        public virtual ICommonGroupBy GroupingSet(IList<GroupingSpecification> arguments)
        {
            throw new NotSupportedException();
        }

        public TEndType End<TEndType>()
        {
            return (TEndType)groupBy;
        }
    }
}
