namespace RazorMarkup.Database.SqlServer.Merge
{
    internal class MergeAsTableAlias : MergeUsing, IMergeAsTableAlias
    {
        public MergeAsTableAlias(MergeStatementBuilder statement)
            : base(statement)
        {
        }

        public IMergeUsing Alias(TableAlias tableAlias)
        {
            Statement.TableAlias = tableAlias.ToSqlString();
            Statement.Append((IMergeAsTableAlias input) => input.Alias(null), tableAlias);
            return this;
        }

        public IMergeUsing As(TableAlias tableAlias)
        {
            Statement.TableAlias = tableAlias.ToSqlString();
            Statement.TableAliasHasAsKeyword = true;
            Statement.Append((IMergeAsTableAlias input) => input.Alias(null), tableAlias);
            return this;
        }
    }
}
