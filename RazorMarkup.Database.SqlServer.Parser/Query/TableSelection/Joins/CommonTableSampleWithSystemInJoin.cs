using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSampleWithSystemInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonTableSampleWithSystemInJoin<
            TJoinEndType,
            ITableSampleWithSystemInJoin<TJoinEndType>,
            ITableSelectionWithRepeatableInJoin<TJoinEndType>,
            ITableSampleInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSelectionWithRepeatableInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonTableSampleInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }

}
