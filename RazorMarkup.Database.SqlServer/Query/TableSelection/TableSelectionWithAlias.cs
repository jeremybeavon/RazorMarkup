﻿using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithAlias<TEndType> :
        CommonTableSelectionWithAlias<
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            ITableHint<TEndType>,
            ITableSampleWithSystem<TEndType>,
            ITableSelectionWithTableSample<TEndType>,
            ITableSelectionWithAlias<TEndType>>,
        ITableSelectionWithAlias<TEndType>
    {
        private readonly EndFromClause<TEndType> endFromClause;

        public TableSelectionWithAlias(FromClauseBuilder statement, TEndType endClosure)
            : this(statement, new TableSelectionFactory<TEndType>(endClosure))
        {
            endFromClause = new EndFromClause<TEndType>(statement, endClosure);
        }

        private TableSelectionWithAlias(FromClauseBuilder statement, TableSelectionFactory<TEndType> factory)
            : base(
                  statement,
                  factory.CreateTableSourceInJoin,
                  factory.CreateTableSource,
                  factory.CreatePivotClause,
                  factory.CreateUnpivotClause,
                  factory.CreateTableHint,
                  factory.CreateTableSampleWithSystem,
                  factory.CreateTableSelectionWithTableSample)
        {
        }

        public TEndType End()
        {
            return endFromClause.End();
        }

        public IQueryOperand<TEndType> Except()
        {
            return endFromClause.Except();
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return endFromClause.For();
        }

        public IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression)
        {
            return endFromClause.GroupBy(groupingExpression);
        }

        public IGroupByFunction<TEndType> GroupBy()
        {
            return endFromClause.GroupBy();
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return endFromClause.Intersect();
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            return endFromClause.OrderBy(expression);
        }

        public IQueryOperand<TEndType> Union()
        {
            return endFromClause.Union();
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return endFromClause.UnionAll();
        }

        public IEndWhereClause<TEndType> Where(Expression<Func<bool>> searchCondition)
        {
            return endFromClause.Where(searchCondition);
        }
    }
}
