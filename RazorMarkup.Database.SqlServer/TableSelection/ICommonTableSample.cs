﻿using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.TableSelection
{
    public interface ICommonTableSample<TTableSelectionWithRepeatable> : IHideObjectMethods
    {
        TTableSelectionWithRepeatable Percent(Expression<Func<Float>> sampleNumber);

        TTableSelectionWithRepeatable Rows(Expression<Func<Integer>> sampleNumber);

        TTableSelectionWithRepeatable Sample(Expression<Func<Integer>> sampleNumber);
    }
}
