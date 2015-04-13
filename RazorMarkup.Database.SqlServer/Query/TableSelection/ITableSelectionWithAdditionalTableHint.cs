﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    public interface ITableSelectionWithAdditionalTableHint<TEndType> : ITableSelectionWithJoin<TEndType>
    {
        new ITableHint<TEndType> And();
    }
}