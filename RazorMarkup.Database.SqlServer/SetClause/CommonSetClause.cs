using System;

namespace RazorMarkup.Database.SqlServer.SetClause
{
    internal abstract class CommonSetClause<TSetColumn, TSetVariable> :
        AbstractStatement<SetClauseBuilder>, 
        ICommonSetClause<TSetColumn, TSetVariable>
    {
        private readonly Func<SetClauseBuilder, TSetColumn> setColumnBuilder;
        private readonly Func<SetClauseBuilder, TSetVariable> setVariableBuilder;

        protected CommonSetClause(
            SetClauseBuilder statement,
            Func<SetClauseBuilder, TSetColumn> setColumnBuilder,
            Func<SetClauseBuilder, TSetVariable> setVariableBuilder)
            : base(statement)
        {
            this.setColumnBuilder = setColumnBuilder;
            this.setVariableBuilder = setVariableBuilder;
        }

        public TSetColumn Set(ColumnName columnName)
        {
            Statement.SetClauses.Add(new SetColumnOrVariableBuilder(ExpressionBuilder));
            Statement.CurrentSetClause.ColumnName = columnName.ToSqlString();
            Statement.Append((ICommonSetClause<TSetColumn, TSetColumn> input) => input.Set((ColumnName)null), columnName);
            return setColumnBuilder(Statement);
        }

        public TSetVariable Set(VariableName variableName)
        {
            Statement.SetClauses.Add(new SetColumnOrVariableBuilder(ExpressionBuilder));
            Statement.CurrentSetClause.VariableName = variableName.ToSqlString();
            Statement.Append((ICommonSetClause<TSetColumn, TSetColumn> input) => input.Set((VariableName)null), variableName);
            return setVariableBuilder(Statement);
        }
    }
}
