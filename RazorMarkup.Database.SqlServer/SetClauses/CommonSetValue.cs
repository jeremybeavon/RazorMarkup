using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.SetClauses
{
    internal abstract class CommonSetValue<TSetClauseAnd> :
        AbstractStatement<SetClauseBuilder>,
        ICommonSetValue<TSetClauseAnd>
    {
        private readonly Func<SetClauseBuilder, TSetClauseAnd> setClauseAndBuilder;

        protected CommonSetValue(
            SetClauseBuilder statement,
            Func<SetClauseBuilder, TSetClauseAnd> setClauseAndBuilder)
            : base(statement)
        {
            this.setClauseAndBuilder = setClauseAndBuilder;
        }

        public TSetClauseAnd BitwiseAndEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "&=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.BitwiseAndEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd BitwiseOrEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "|=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.BitwiseOrEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd BitwiseXorEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "^=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.BitwiseXorEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd DivideEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "/=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.DivideEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd Equals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.Equals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd MinusEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "-=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.MinusEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd ModuloEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "%=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.ModuloEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd MultiplyEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "*=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.MultiplyEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }

        public TSetClauseAnd PlusEquals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Operator = "+=";
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.PlusEquals(null), expression);
            return setClauseAndBuilder(Statement);
        }
    }
}
