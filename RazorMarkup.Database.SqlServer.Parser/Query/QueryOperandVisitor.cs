using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Query.Select;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class QueryOperandVisitor<TEndType> : AbstractSqlVisitor<IHasEnd<TEndType>>
    {
        private readonly IQueryOperand<TEndType> operand;
        private readonly SelectStatement selectStatement;

        public QueryOperandVisitor(IQueryOperand<TEndType> operand)
        {
            this.operand = operand;
        }

        public QueryOperandVisitor(IQueryOperand<TEndType> operand, SelectStatement selectStatement)
            : this(operand)
        {
            this.selectStatement = selectStatement;
        }

        public override void ExplicitVisit(QueryParenthesisExpression node)
        {
            Result = operand.OperatorGroup(node.QueryExpression);
        }

        public override void ExplicitVisit(BinaryQueryExpression node)
        {
            IHasEnd<TEndType> firstOperand = node.FirstQueryExpression.AcceptWithResult(new QueryOperandVisitor<TEndType>(operand));
            IQueryOperator<TEndType> queryOperator = (IQueryOperator<TEndType>)firstOperand;
            IQueryOperand<TEndType> binaryQuery = null;
            switch (node.BinaryQueryExpressionType)
            {
                case BinaryQueryExpressionType.Union:
                    binaryQuery = node.All ? queryOperator.UnionAll() : queryOperator.Union();
                    break;
                case BinaryQueryExpressionType.Except:
                    binaryQuery = queryOperator.Except();
                    break;
                case BinaryQueryExpressionType.Intersect:
                    binaryQuery = queryOperator.Intersect();
                    break;
            }

            Result = node.SecondQueryExpression.AcceptWithResult(new QueryOperandVisitor<TEndType>(binaryQuery));
        }

        public override void ExplicitVisit(QuerySpecification node)
        {
            ISelectClauseWithDistinct<TEndType> selectClauseWithDistinct = operand.Select();
            ISelectClauseWithTop<TEndType> selectClauseWithTop = BuildSelectClauseWithDistinct(selectClauseWithDistinct, node);
            ISelectClause<TEndType> selectClause = BuildSelectClauseWithTop(selectClauseWithTop, node);
            ISelectClauseWithInto<TEndType> selectClauseWithInto = BuildSelectClause(selectClause, node);
            ISelectClauseWithFrom<TEndType> selectClauseWithFrom = BuildSelectClauseWithInto(selectClauseWithInto);
            IEndFromClause<TEndType> endFormClause = BuildFromClause(selectClauseWithFrom, node);
            IEndWhereClause<TEndType> endWhereClause = BuildWhereClause(endFormClause, node);
            IEndGroupByClause<TEndType> endGroupByClause = BuildGroupByClause(endWhereClause, node);
            IEndHavingClause<TEndType> endHavingClause = BuildHavingClause(endGroupByClause, node);
            IEndOrderByClause<TEndType> endOrderByClause = BuildOrderByClause(endHavingClause, node);
            IEndOffsetClause<TEndType> endOffsetClause = BuildOffsetClause(endOrderByClause, node);
            IEndForClause<TEndType> endForClause = BuildForClause(endOffsetClause, node);
            Result = BuildOptionClause(endForClause, node);
        }

        private ISelectClauseWithTop<TEndType> BuildSelectClauseWithDistinct(
            ISelectClauseWithDistinct<TEndType> select,
            QuerySpecification node)
        {
            switch (node.UniqueRowFilter)
            {
                case UniqueRowFilter.All:
                    return select.All();
                case UniqueRowFilter.Distinct:
                    return select.Distinct();
                default:
                    return select;
            }
        }

        private ISelectClause<TEndType> BuildSelectClauseWithTop(
            ISelectClauseWithTop<TEndType> select,
            QuerySpecification node)
        {
            TopRowFilter topRowFilter = node.TopRowFilter;
            if (topRowFilter == null)
            {
                return select;
            }

            ISelectClauseWithPercent<TEndType> selectWithPercent = select.Top(topRowFilter.Expression.ToExpression<Integer>());
            ISelectClauseWithTies<TEndType> selectWithTies = selectWithPercent;
            if (topRowFilter.Percent)
            {
                selectWithTies = selectWithPercent.Percent();
            }

            return topRowFilter.WithTies ? selectWithTies.WithTies() : selectWithTies;
        }

        private ISelectClauseWithInto<TEndType> BuildSelectClause(
            ISelectClause<TEndType> select,
            QuerySpecification node)
        {
            ISelectClauseAnd<TEndType> selectColumn =
                node.SelectElements[0].AcceptWithResult(new SelectClauseVisitor<TEndType>(select));
            foreach (SelectElement selectElement in node.SelectElements.Skip(1))
            {
                selectColumn = selectElement.AcceptWithResult(new SelectClauseVisitor<TEndType>(selectColumn.And()));
            }

            return selectColumn;
        }

        private ISelectClauseWithFrom<TEndType> BuildSelectClauseWithInto(ISelectClauseWithInto<TEndType> select)
        {
            return selectStatement != null && selectStatement.Into != null ? select.Into(selectStatement.Into.ToTableName()) : select;
        }

        private IEndFromClause<TEndType> BuildFromClause(
            ISelectClauseWithFrom<TEndType> selectClauseWithFrom,
            QuerySpecification node)
        {
            return node.FromClause == null ?
                new EmptyFromClause<TEndType>(selectClauseWithFrom) :
                node.FromClause.AcceptWithResult(new FromClauseVisitor<TEndType>(selectClauseWithFrom.From()));
        }

        private IEndWhereClause<TEndType> BuildWhereClause(
            IEndFromClause<TEndType> whereClause,
            QuerySpecification node)
        {
            return node.WhereClause == null ?
                new EmptyWhereClause<TEndType>(whereClause) :
                whereClause.Where(node.WhereClause.SearchCondition.ToExpression());
        }

        private IEndGroupByClause<TEndType> BuildGroupByClause(
            IEndWhereClause<TEndType> groupByClause,
            QuerySpecification node)
        {
            if (node.GroupByClause == null)
            {
                return new EmptyGroupByClause<TEndType>(groupByClause);
            }

            ICommonGroupBy groupBy = node.GroupByClause.GroupingSpecifications.AcceptWithResult(
                new GroupByClause<TEndType>(groupByClause));
            return groupBy.End<IEndGroupByClause<TEndType>>();
        }

        private IEndHavingClause<TEndType> BuildHavingClause(
            IEndGroupByClause<TEndType> havingClause,
            QuerySpecification node)
        {
            return node.HavingClause == null ?
                new EmptyHavingClause<TEndType>(havingClause) :
                havingClause.Having(node.HavingClause.SearchCondition.ToExpression());
        }

        private IEndOrderByClause<TEndType> BuildOrderByClause(
            IEndHavingClause<TEndType> orderByClause,
            QuerySpecification node)
        {
            if (node.OrderByClause == null)
            {
                return new EmptyOrderByClause<TEndType>(orderByClause);
            }

            IOrderByAnd<TEndType> and = null;
            foreach (ExpressionWithSortOrder element in node.OrderByClause.OrderByElements)
            {
                Expression<Func<object>> expression = element.Expression.ToExpression<object>();
                IOrderByCollate<TEndType> orderByCollate = and == null ? orderByClause.OrderBy(expression) : and.And(expression);
                PrimaryExpression expressionWithCollate = element.Expression as PrimaryExpression;
                IOrderByAscendingOrDescending<TEndType> orderBy =
                    expressionWithCollate != null && expressionWithCollate.Collation != null ?
                    orderByCollate.Collate(new CollationName(expressionWithCollate.Collation.Value)) :
                    orderByCollate;
                switch (element.SortOrder)
                {
                    case SortOrder.NotSpecified:
                        and = orderBy;
                        break;
                    case SortOrder.Ascending:
                        and = orderBy.Ascending();
                        break;
                    case SortOrder.Descending:
                        and = orderBy.Descending();
                        break;
                }
            }

            return and;
        }

        private IEndOffsetClause<TEndType> BuildOffsetClause(
            IEndOrderByClause<TEndType> offsetClause,
            QuerySpecification node)
        {
            if (node.OffsetClause == null)
            {
                return new EmptyOffsetClause<TEndType>(offsetClause);
            }

            OffsetClause offsetNode = node.OffsetClause;
            IOffsetRow<TEndType> row = offsetClause.Offset(offsetNode.OffsetExpression.ToExpression<Integer>());
            string token = offsetNode.GetNextIdentifier(offsetNode.OffsetExpression.LastTokenIndex + 1);
            IOffsetFetch<TEndType> fetch = token.Equals("ROW", StringComparison.OrdinalIgnoreCase) ? row.Row() : row.Rows();
            if (offsetNode.FetchExpression == null)
            {
                return fetch;
            }

            token = offsetNode.GetPreviousIdentifier(offsetNode.FetchExpression.FirstTokenIndex - 1);
            Expression<Func<Integer>> fetchExpression = offsetNode.FetchExpression.ToExpression<Integer>();
            IOffsetFetchRow<TEndType> fetchRow =
                token.Equals("FIRST", StringComparison.OrdinalIgnoreCase) ?
                fetch.FetchFirst(fetchExpression) :
                fetch.FetchNext(fetchExpression);
            token = offsetNode.GetNextIdentifier(offsetNode.FetchExpression.LastTokenIndex + 1);
            return token.Equals("ROW", StringComparison.OrdinalIgnoreCase) ? fetchRow.Row().Only() : fetchRow.Rows().Only();
        }

        private IEndForClause<TEndType> BuildForClause(
            IEndOffsetClause<TEndType> forClause,
            QuerySpecification node)
        {
            return new EmptyForClause<TEndType>(forClause);
        }

        private IHasEnd<TEndType> BuildOptionClause(
            IEndForClause<TEndType> optionClause,
            QuerySpecification node)
        {
            return optionClause;
        }
    }
}
