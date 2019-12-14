using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Parser.TableSelection
{
    internal abstract class AbstractCommonPivotClauseIn<
        TPivotClauseIn,
        TPivotClauseAlias,
        TCommonPivotClauseAlias> : AbstractSource<TPivotClauseIn>, ICommonPivotClauseIn
        where TPivotClauseIn : ICommonPivotClauseIn<TPivotClauseAlias>
        where TCommonPivotClauseAlias : ISource<TPivotClauseAlias>, ICommonPivotClauseAlias, new()
    {
        public ICommonPivotClauseAlias In(params ColumnName[] columns)
        {
            return new TCommonPivotClauseAlias()
            {
                Source = Source.In(columns)
            };
        }
    }
}
