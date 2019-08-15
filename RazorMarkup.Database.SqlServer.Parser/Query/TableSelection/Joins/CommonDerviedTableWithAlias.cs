using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal sealed class CommonDerviedTableWithAliasInJoin<TEndType> : AbstractJoinStatement<TEndType>, ICommonDerivedTableWithAlias
    {
        private readonly IDerviedTableWithAliasInJoin<TEndType> derivedTableWithAlias;

        public CommonDerviedTableWithAliasInJoin(
            IDerviedTableWithAliasInJoin<TEndType> derivedTableWithAlias,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            : base(endClosure)
        {
            this.derivedTableWithAlias = derivedTableWithAlias;
        }

        public ICommonTableSelectionWithJoin As(TableAlias tableAlias, params ColumnAlias[] columnAlias)
        {
            return new CommonTableSelectionWithJoinInJoin<TEndType>(derivedTableWithAlias.As(tableAlias, columnAlias), EndClosure);
        }
    }
}
