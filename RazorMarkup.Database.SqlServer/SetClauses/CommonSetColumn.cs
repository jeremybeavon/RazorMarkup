using System;
using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.SetClauses
{
    internal abstract class CommonSetColumn<TSetClauseAnd, TSetFieldOrProperty> :
        CommonSetValue<TSetClauseAnd>,
        ICommonSetColumn<TSetClauseAnd, TSetFieldOrProperty>
    {
        private readonly Func<SetClauseBuilder, TSetClauseAnd> setClauseAndBuilder;
        private readonly Func<SetClauseBuilder, TSetFieldOrProperty> setFieldOrPropertyBuilder;

        protected CommonSetColumn(
            SetClauseBuilder statement,
            Func<SetClauseBuilder, TSetClauseAnd> setClauseAndBuilder,
            Func<SetClauseBuilder, TSetFieldOrProperty> setFieldOrPropertyBuilder)
            : base(statement, setClauseAndBuilder)
        {
            this.setClauseAndBuilder = setClauseAndBuilder;
            this.setFieldOrPropertyBuilder = setFieldOrPropertyBuilder;
        }

        public TSetFieldOrProperty Field(ClrFieldName fieldName)
        {
            Statement.CurrentSetClause.FieldOrPropertyName = fieldName.ToSqlString();
            Statement.Append((ICommonSetColumn<TSetClauseAnd, TSetFieldOrProperty> input) => input.Field(null), fieldName);
            return setFieldOrPropertyBuilder(Statement);
        }

        public TSetClauseAnd Method(ClrMethodName methodName, params Expression<Func<object>>[] parameters)
        {
            Statement.CurrentSetClause.MethodName = methodName.ToSqlString();
            ExpressionBuilder<object>[] parameterBuilders = parameters
                .Select(parameter => new ExpressionBuilder<object>(parameter))
                .ToArray();
            Statement.CurrentSetClause.MethodArguments.AddRange(parameterBuilders);
            SqlStringArray parameterExpressions = new(typeof(Expression<Func<object>>), parameterBuilders);
            Statement.Append(
                (ICommonSetColumn<TSetClauseAnd, TSetFieldOrProperty> input) => input.Method(null),
                methodName,
                parameterExpressions);
            return setClauseAndBuilder(Statement);
        }

        public TSetFieldOrProperty Property(ClrPropertyName propertyName)
        {
            Statement.CurrentSetClause.FieldOrPropertyName = propertyName.ToSqlString();
            Statement.Append((ICommonSetColumn<TSetClauseAnd, TSetFieldOrProperty> input) => input.Property(null), propertyName);
            return setFieldOrPropertyBuilder(Statement);
        }

        public TSetClauseAnd Write(Expression<Func<object>> expression, int offset, int length)
        {
            SetColumnOrVariableBuilder columnBuilder = Statement.CurrentSetClause;
            columnBuilder.WriteExpression = new ExpressionBuilder<object>(expression);
            columnBuilder.WriteOffset = offset.ToString();
            columnBuilder.WriteLength = length.ToString();
            Statement.Append(
                (ICommonSetColumn<TSetClauseAnd, TSetFieldOrProperty> input) => input.Write(null, 0, 0),
                new ExpressionBuilder<object>(expression),
                new RawStatementBuilder(offset.ToString()),
                new RawStatementBuilder(length.ToString()));
            return setClauseAndBuilder(Statement);
        }
    }
}
