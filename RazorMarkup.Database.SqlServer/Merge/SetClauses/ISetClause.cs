﻿using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge.SetClauses
{
    public interface ISetClause : ICommonSetClause<ISetColumn, ISetVariable>
    {
    }
}
