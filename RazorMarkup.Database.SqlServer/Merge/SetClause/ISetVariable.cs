﻿using RazorMarkup.Database.SqlServer.SetClause;

namespace RazorMarkup.Database.SqlServer.Merge.SetClause
{
    public interface ISetVariable : ICommonSetVariable<ISetClauseAnd, ISetValue>
    {
    }
}