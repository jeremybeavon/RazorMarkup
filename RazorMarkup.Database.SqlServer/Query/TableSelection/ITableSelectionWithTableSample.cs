﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Samples;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithTableSample<TEndType> : ITableSelectionWithTableHint<TEndType>
    {
        ITableSample<TEndType> WithTableSample();
    }
}
