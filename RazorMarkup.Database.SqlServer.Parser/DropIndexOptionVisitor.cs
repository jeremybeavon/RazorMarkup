using System;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Drop.Index;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed class DropIndexOptionVisitor : AbstractSqlVisitor<IDropIndexWithAnd>
    {
        private readonly IDropIndexWith with;

        public DropIndexOptionVisitor(IDropIndexWith with)
        {
            this.with = with;
        }

        private IDropIndexWithOptions Options
        {
            get { return Result == null ? with.With() : Result.And(); }
        }

        public override void ExplicitVisit(IndexExpressionOption node)
        {
            if (node.OptionKind != IndexOptionKind.MaxDop)
            {
                throw new NotSupportedException();
            }

            Result = Options.MaxDegreeOfParallelism(node.Expression.ToExpression<Integer>());
        }

        public override void ExplicitVisit(OnlineIndexOption node)
        {
            if (node.OptionKind != IndexOptionKind.Online)
            {
                throw new NotSupportedException();
            }

            switch (node.OptionState)
            {
                case OptionState.Off:
                    Result = Options.Online().Off();
                    break;
                case OptionState.On:
                    Result = Options.Online().On();
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        public override void ExplicitVisit(MoveToDropIndexOption node)
        {
            FileGroupOrPartitionScheme moveTo = node.MoveTo;
            if (moveTo.PartitionSchemeColumns.Count != 0)
            {
                Result = Options.MoveTo(
                    new PartitionSchemeName(moveTo.Name.Identifier.Value),
                    new ColumnName(moveTo.PartitionSchemeColumns[0].Value));
            }
            else if (moveTo.Name.Identifier != null)
            {
                Result = Options.MoveTo(new FileGroupName(moveTo.Name.Identifier.Value));
            }
            else
            {
                Result = Options.MoveToDefault();
            }
        }

        public override void ExplicitVisit(FileStreamOnDropIndexOption node)
        {
            if (node.FileStreamOn.Identifier != null)
            {
                Result = Options.FilestreamOn(new FileGroupName(node.FileStreamOn.Identifier.Value));
            }
            else
            {
                Result = Options.FilestreamOnDefault();
            }
        }
    }
}
