﻿using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IEndGroupByClause<TEndType> : IHasEnd<TEndType>,
        IHavingClause<TEndType>,
        IQueryOperator<TEndType>,
        IOrderByClause<TEndType>,
        IOffsetClause<TEndType>,
        IForClause<TEndType>,
        IOptionClause<TEndType>
    {
    }
}
