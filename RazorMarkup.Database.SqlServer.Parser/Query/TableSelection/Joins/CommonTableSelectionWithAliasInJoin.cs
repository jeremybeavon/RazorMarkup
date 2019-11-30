﻿using System;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;

namespace RazorMarkup.Database.SqlServer.Parser.Query.TableSelection.Joins
{
    internal class CommonTableSelectionWithAliasInJoin<TEndType> :
        CommonTableSelectionWithTableSampleInJoin<TEndType>,
        ICommonTableSelectionWithAlias
    {
        private readonly ITableSelectionWithAliasInJoin<TEndType> tableSelectionWithAlias;

        public CommonTableSelectionWithAliasInJoin(
            ITableSelectionWithAliasInJoin<TEndType> tableSelectionWithAlias,
            Func<TEndType, ICommonTableSelectionWithJoin> endClosure)
            //: base(tableSelectionWithAlias, endClosure)
            : base(null, endClosure)
        {
            this.tableSelectionWithAlias = tableSelectionWithAlias;
        }

        public ICommonTableSelectionWithTableSample As(TableAlias tableAlias)
        {
            return new CommonTableSelectionWithTableSampleInJoin<TEndType>(tableSelectionWithAlias.As(tableAlias), EndClosure);
        }
    }
}
