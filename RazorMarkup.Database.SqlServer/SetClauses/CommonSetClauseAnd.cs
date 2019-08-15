using System;

namespace RazorMarkup.Database.SqlServer.SetClauses
{
    internal abstract class CommonSetClauseAnd<TSetColumn, TSetVariable> :
        AbstractStatement<SetClauseBuilder>, 
        ICommonSetClauseAnd<TSetColumn, TSetVariable>
    {
        private readonly Func<SetClauseBuilder, TSetColumn> setColumnBuilder;
        private readonly Func<SetClauseBuilder, TSetVariable> setVariableBuilder;

        protected CommonSetClauseAnd(
            SetClauseBuilder statement,
            Func<SetClauseBuilder, TSetColumn> setColumnBuilder,
            Func<SetClauseBuilder, TSetVariable> setVariableBuilder)
            : base(statement)
        {
            this.setColumnBuilder = setColumnBuilder;
            this.setVariableBuilder = setVariableBuilder;
        }

        public TSetColumn And(ColumnName columnName)
        {
            Statement.SetClauses.Add(new SetColumnOrVariableBuilder(ExpressionBuilder));
            Statement.CurrentSetClause.ColumnName = columnName.ToSqlString();
            Statement.Append((ICommonSetClauseAnd<TSetColumn, TSetColumn> input) => input.And((ColumnName)null), columnName);
            return setColumnBuilder(Statement);
        }

        public TSetVariable And(VariableName variableName)
        {
            Statement.SetClauses.Add(new SetColumnOrVariableBuilder(ExpressionBuilder));
            Statement.CurrentSetClause.VariableName = variableName.ToSqlString();
            Statement.Append((ICommonSetClauseAnd<TSetColumn, TSetColumn> input) => input.And((VariableName)null), variableName);
            return setVariableBuilder(Statement);
        }
    }
}
