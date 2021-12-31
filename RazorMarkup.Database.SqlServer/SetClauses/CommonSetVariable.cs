using System;

namespace RazorMarkup.Database.SqlServer.SetClauses
{
    internal abstract class CommonSetVariable<TSetClauseAnd, TSetValue> :
        CommonSetValue<TSetClauseAnd>,
        ICommonSetVariable<TSetClauseAnd, TSetValue>
    {
        private readonly Func<SetClauseBuilder, TSetValue> setValueBuilder;

        protected CommonSetVariable(
            SetClauseBuilder statement,
            Func<SetClauseBuilder, TSetClauseAnd> setClauseAndBuilder,
            Func<SetClauseBuilder, TSetValue> setValueBuilder)
            : base(statement, setClauseAndBuilder)
        {
            this.setValueBuilder = setValueBuilder;
        }

        public TSetValue Equals(ColumnName columnName)
        {
            Statement.CurrentSetClause.ColumnName = columnName.ToSqlString();
            Statement.Append((ICommonSetVariable<TSetClauseAnd, TSetValue> input) => input.Equals(null), columnName);
            return setValueBuilder(Statement);
        }
    }
}
