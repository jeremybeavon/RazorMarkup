using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonPivotClause<
        TPivotClause,
        TPivotClauseIn,
        TCommonPivotClauseIn> : AbstractSource<TPivotClause>, ICommonPivotClause
        where TPivotClause : ICommonPivotClause<TPivotClauseIn>
        where TCommonPivotClauseIn : ISource<TPivotClauseIn>, ICommonPivotClauseIn, new()
    {
        public ICommonPivotClauseIn For(ColumnName columnName)
        {
            return new TCommonPivotClauseIn()
            {
                Source = Source.For(columnName)
            };
        }
    }
}
