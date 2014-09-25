using System;

namespace RazorMarkup.Database.SqlServer.Drop
{
    internal sealed class DropDatabaseStatement : SqlBuilder, IDropDatabaseStatement
    {
        public DropDatabaseStatement(DatabaseName databaseName)
            : this((ISqlString)databaseName)
        {
        }

        public DropDatabaseStatement(DatabaseSnapshotName databaseSnapshotName)
            : this((ISqlString)databaseSnapshotName)
        {
        }

        private DropDatabaseStatement(ISqlString name)
            : base(string.Format("DROP DATABASE {0}", name.ToSqlString()), () => Sql.Drop().Database((DatabaseName)null), name)
        {
        }

        public IDropDatabaseStatement And(DatabaseSnapshotName databaseSnapshotName)
        {
            Append(", ");
            Append(databaseSnapshotName.ToSqlString());
            Append((IDropDatabaseStatement input) => input.And(databaseSnapshotName), databaseSnapshotName);
            return this;
        }

        public IDropDatabaseStatement And(DatabaseName databaseName)
        {
            Append(", ");
            Append(databaseName.ToSqlString());
            Append((IDropDatabaseStatement input) => input.And(databaseName), databaseName);
            return this;
        }
    }
}
