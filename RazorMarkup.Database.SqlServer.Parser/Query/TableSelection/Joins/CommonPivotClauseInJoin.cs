﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonPivotClauseInJoin<TJoinEndType, TCommonJoinEndType> :
        AbstractCommonPivotClause<
            IPivotClauseInJoin<TJoinEndType>,
            IPivotClauseInInJoin<TJoinEndType>,
            CommonPivotClauseInInJoin<TJoinEndType, TCommonJoinEndType>>
        where TCommonJoinEndType : ISource<TJoinEndType>, ICommonTableSelectionWithJoin, new()
    {
    }
}
