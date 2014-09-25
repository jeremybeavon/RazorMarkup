﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Hints
{
    public interface IAdditionalTableHint<TEndType> : IHideObjectMethods
    {
        ITableHint<TEndType> And();
    }
}
