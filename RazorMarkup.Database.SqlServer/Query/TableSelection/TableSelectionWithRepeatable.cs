using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.TableSelection;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithRepeatable<TEndType> :
        CommonTableSelectionWithRepeatable<
            ITableSourceInJoin<ITableSelectionWithJoin<TEndType>>,
            ITableSource<TEndType>,
            IPivotClause<TEndType>,
            IUnpivotClause<TEndType>,
            ITableHint<TEndType>,
            ITableSelectionWithTableHint<TEndType>,
            ITableSelectionWithRepeatable<TEndType>>,
        ITableSelectionWithRepeatable<TEndType>
    {
        private readonly EndFromClause<TEndType> endFromClause;

        public TableSelectionWithRepeatable(FromClauseBuilder statement, TEndType endClosure)
            : this(statement, new TableSelectionFactory<TEndType>(endClosure))
        {
            endFromClause = new EndFromClause<TEndType>(statement, endClosure);
        }

        private TableSelectionWithRepeatable(FromClauseBuilder statement, TableSelectionFactory<TEndType> factory)
            : base(
                  statement,
                  factory.CreateTableSourceInJoin,
                  factory.CreateTableSource,
                  factory.CreatePivotClause,
                  factory.CreateUnpivotClause,
                  factory.CreateTableHint,
                  factory.CreateTableSelectionWithTableHint)
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
