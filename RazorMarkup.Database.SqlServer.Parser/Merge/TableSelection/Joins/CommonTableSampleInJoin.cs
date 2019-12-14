using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal class CommonTableSampleInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonTableSampleInJoin<
            TJoinEndType,
            ITableSampleInJoin<TJoinEndType>,
            ITableSelectionWithRepeatableInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSelectionWithRepeatableInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
