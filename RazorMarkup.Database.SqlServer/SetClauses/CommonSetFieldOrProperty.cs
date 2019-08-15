using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.SetClauses
{
    internal abstract class CommonSetFieldOrProperty<TSetClauseAnd> :
        AbstractStatement<SetClauseBuilder>,
        ICommonSetFieldOrProperty<TSetClauseAnd>
    {
        private readonly Func<SetClauseBuilder, TSetClauseAnd> setClauseAndBuilder;

        protected CommonSetFieldOrProperty(
            SetClauseBuilder statement,
            Func<SetClauseBuilder, TSetClauseAnd> setClauseAndBuilder)
            : base(statement)
        {
            this.setClauseAndBuilder = setClauseAndBuilder;
        }

        public TSetClauseAnd Equals(Expression<Func<object>> expression)
        {
            Statement.CurrentSetClause.Expression = new ExpressionBuilder<object>(expression);
            Statement.Append((ICommonSetValue<TSetClauseAnd> input) => input.Equals(null), expression);
            return setClauseAndBuilder(Statement);
        }
    }
}
