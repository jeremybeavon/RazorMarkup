﻿using RazorMarkup.Database.SqlServer.SetClauses;

namespace RazorMarkup.Database.SqlServer.Merge.SetClauses
{
    public interface ISetVariable : ICommonSetVariable<ISetClauseAnd, ISetValue>
    {
    }
}
