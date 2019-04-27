using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Drop.Index
{
    internal sealed class DropIndexWithOptions : AbstractStatement<DropIndexStatementBuilder>, IDropIndexWithOptions
    {
        public DropIndexWithOptions(DropIndexStatementBuilder statement)
            : base(statement)
        {
        }

        public IDropIndexWithAnd MaxDegreeOfParallelism(Expression<Func<Integer>> maxDegreeOfParallelism)
        {
            Statement.CurrentIndex.MaxDegreeOfParallelism = maxDegreeOfParallelism;
            Statement.Append(
                (IDropIndexWithOptions input) => input.MaxDegreeOfParallelism(null),
                maxDegreeOfParallelism.ToExpressionBuilder());
            return new DropIndexWithAnd(Statement);
        }

        public IDropIndexWithOnline Online()
        {
            Statement.Append((IDropIndexWithOptions input) => input.Online());
            return new DropIndexWithOnline(Statement);
        }

        public IDropIndexWithAnd MoveTo(PartitionSchemeName partitionSchemeName, ColumnName columnName)
        {
            Statement.CurrentIndex.MoveTo = string.Format("{0}({1})", partitionSchemeName.ToSqlString(), columnName.ToSqlString());
            Statement.Append((IDropIndexWithOptions input) => input.MoveTo(null, null), partitionSchemeName, columnName);
            return new DropIndexWithAnd(Statement);
        }

        public IDropIndexWithAnd MoveTo(FileGroupName fileGroupName)
        {
            Statement.CurrentIndex.MoveTo = fileGroupName.ToSqlString();
            Statement.Append((IDropIndexWithOptions input) => input.MoveTo(null), fileGroupName);
            return new DropIndexWithAnd(Statement);
        }

        public IDropIndexWithAnd MoveToDefault()
        {
            Statement.CurrentIndex.MoveTo = "\"default\"";
            Statement.Append((IDropIndexWithOptions input) => input.MoveToDefault());
            return new DropIndexWithAnd(Statement);
        }

        public IDropIndexWithAnd FilestreamOn(PartitionSchemeName partitionSchemeName)
        {
            Statement.CurrentIndex.FilestreamOn = partitionSchemeName.ToSqlString();
            Statement.Append((IDropIndexWithOptions input) => input.FilestreamOn((PartitionSchemeName)null), partitionSchemeName);
            return new DropIndexWithAnd(Statement);
        }

        public IDropIndexWithAnd FilestreamOn(FileGroupName fileGroupName)
        {
            Statement.CurrentIndex.FilestreamOn = fileGroupName.ToSqlString();
            Statement.Append((IDropIndexWithOptions input) => input.FilestreamOn((FileGroupName)null), fileGroupName);
            return new DropIndexWithAnd(Statement);
        }

        public IDropIndexWithAnd FilestreamOnDefault()
        {
            Statement.CurrentIndex.FilestreamOn = "\"default\"";
            Statement.Append((IDropIndexWithOptions input) => input.FilestreamOnDefault());
            return new DropIndexWithAnd(Statement);
        }
    }
}
