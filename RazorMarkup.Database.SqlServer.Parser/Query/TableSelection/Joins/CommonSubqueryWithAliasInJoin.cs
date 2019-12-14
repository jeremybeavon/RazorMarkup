﻿using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonSubqueryWithAliasInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonSubqueryWithAliasInJoin<
            TJoinEndType,
            ISubqueryWithAliasInJoin<TJoinEndType>,
            ITableSelectionWithJoinInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSelectionWithJoinInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
