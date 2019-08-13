using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.TableSelection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class AdditionalTableHint<TEndType> :
        AdditionalCommonTableHint<
            ITableSelectionWithAlias<TEndType>,
            ISubqueryWithAlias<TEndType>,
            IDerivedTableWithAlias<TEndType>,
            ITableSelectionWithAdditionalTableHint<TEndType>,
            IAdditionalTableHint<TEndType>>,
        IAdditionalTableHint<TEndType>
    {
        public AdditionalTableHint(FromClauseBuilder statement, TEndType endClosure)
            : this(statement, new TableSelectionFactory<TEndType>(endClosure))
        {
        }

        private AdditionalTableHint(FromClauseBuilder statement, TableSelectionFactory<TEndType> factory)
            : base(
                  statement,
                  factory.CreateTableSelectionWithAlias,
                  factory.CreateSubqueryWithAlias,
                  factory.CreateDerivedTableWithAlias,
                  factory.CreateTableSelectionWithAdditionalTableHint)
        {
        }
    }
}
