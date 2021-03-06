﻿using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Parser.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Merge.TableSelection.Joins
{
    internal class CommonTableSourceInJoin<TJoinEndType, TCommonJoinEndType> : 
        AbstractCommonTableSourceInJoin<
            TJoinEndType,
            ITableSourceInJoin<TJoinEndType>,
            ITableSelectionWithAliasInJoin<TJoinEndType>,
            ISubqueryWithAliasInJoin<TJoinEndType>,
            IDerivedTableWithAliasInJoin<TJoinEndType>,
            TCommonJoinEndType,
            CommonTableSelectionWithAliasInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonSubqueryWithAliasInJoin<TJoinEndType, TCommonJoinEndType>,
            CommonDerivedTableWithAliasInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }

}
