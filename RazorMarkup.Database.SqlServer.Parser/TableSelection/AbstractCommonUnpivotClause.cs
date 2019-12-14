using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonUnpivotClause<
        TUnpivotClause,
        TUnpivotClauseIn,
        TCommonPivotClauseIn> : AbstractSource<TUnpivotClause>, ICommonUnpivotClause
        where TUnpivotClause : ICommonUnpivotClause<TUnpivotClauseIn>
        where TCommonPivotClauseIn : ISource<TUnpivotClauseIn>, ICommonUnpivotClauseIn, new()
    {
        public ICommonUnpivotClauseIn For(ColumnName columnName)
        {
            return new TCommonPivotClauseIn()
            {
                Source = Source.For(columnName)
            };
        }
    }
}
