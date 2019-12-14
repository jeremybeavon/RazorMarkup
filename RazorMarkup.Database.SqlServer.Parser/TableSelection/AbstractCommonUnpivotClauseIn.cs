using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonUnpivotClauseIn<
        TUnpivotClauseIn,
        TUnpivotClauseAlias,
        TCommonUnpivotClauseAlias> : AbstractSource<TUnpivotClauseIn>, ICommonUnpivotClauseIn
        where TUnpivotClauseIn : ICommonUnpivotClauseIn<TUnpivotClauseAlias>
        where TCommonUnpivotClauseAlias : ISource<TUnpivotClauseAlias>, ICommonUnpivotClauseAlias, new()
    {
        public ICommonUnpivotClauseAlias In(params ColumnName[] columnNames)
        {
            return new TCommonUnpivotClauseAlias()
            {
                Source = Source.In(columnNames)
            };
        }
    }
}
