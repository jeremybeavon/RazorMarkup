using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class CreateAvailabilityGroupStatementBuilder : AbstractStatementBuilder
    {
        public CreateAvailabilityGroupStatementBuilder(AvailabilityGroupName availabilityGroupName)
            : base(new ExpressionBuilder())
        {
        }

        public AvailabilityGroupName Name { get; private set; }

        public IList<OptionBuilder> Options { get; } = new List<OptionBuilder>();

        public IList<string> DatabaseNames { get; } = new List<string>();

        public IList<ReplicaBuilder> Replicas { get; } = new List<ReplicaBuilder>();

        public string ListenerDnsName { get; set; }

        public bool UseDhcp { get; set; }

        public string DhcpIpv4Address { get; set; }

        public string DhcpIpc4Mask { get; set; }

        public IList<IpAddressBuilder> IpAddresses { get; } = new List<IpAddressBuilder>();

        public ushort? IpPort { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("CREATE AVAILABILITY GROUP ");
            sqlBuilder.Append(Name.ToSqlString());
            using (sqlBuilder.IncrementIndent())
            {
                ToOptionsSqlString(sqlBuilder);
                sqlBuilder.AppendIndent().Append("FOR ");
                if (DatabaseNames.Count != 0)
                {
                    sqlBuilder.Append("DATABASE ");
                    sqlBuilder.Append(string.Join(", ", DatabaseNames));
                    sqlBuilder.AppendIndent();
                }

                sqlBuilder.Append("REPLICA ON");
                ToReplicaSqlString(sqlBuilder);
            }
        }

        private void ToOptionsSqlString(SqlBuilder sqlBuilder)
        {
            if (Options.Count != 0)
            {
                sqlBuilder.AppendIndent().Append("WITH (");
                using (sqlBuilder.IncrementIndent())
                {
                    Options[0].ToSqlString(sqlBuilder);
                    foreach (OptionBuilder option in Options.Skip(1))
                    {
                        sqlBuilder.Append(",");
                        option.ToSqlString(sqlBuilder);
                    }
                }

                sqlBuilder.AppendIndent().Append(")");
            }
        }

        private void ToReplicaSqlString(SqlBuilder sqlBuilder)
        {
            using (sqlBuilder.IncrementIndent())
            {
                Replicas[0].ToSqlString(sqlBuilder);
                foreach (ReplicaBuilder replica in Replicas.Skip(1))
                {
                    sqlBuilder.Append(",");
                    replica.ToSqlString(sqlBuilder);
                }
            }
        }

        private void ToListenerSqlString(SqlBuilder sqlBuilder)
        {
            if (ListenerDnsName != null)
            {
                sqlBuilder.AppendIndent().Append("LISTENER '");
                sqlBuilder.Append(ListenerDnsName);
                sqlBuilder.Append("' ( WITH ");
                if (UseDhcp)
                {
                    sqlBuilder.Append("DHCP");
                    if (DhcpIpv4Address != null)
                    {
                        sqlBuilder.Append(" ON ( '");
                        sqlBuilder.Append(DhcpIpv4Address);
                        sqlBuilder.Append("', '");
                        sqlBuilder.Append(DhcpIpc4Mask);
                        sqlBuilder.Append("') ");
                    }
                }
                else
                {
                    IpAddresses[0].ToSqlString(sqlBuilder);
                    foreach (IpAddressBuilder ipAddress in IpAddresses.Skip(1))
                    {
                        sqlBuilder.Append(",").AppendIndent();
                        ipAddress.ToSqlString(sqlBuilder);
                    }

                    if (IpPort != null)
                    {
                        sqlBuilder.Append(", PORT = ");
                        sqlBuilder.Append(IpPort.Value.ToString());
                    }
                }

                sqlBuilder.Append(")");
            }
        }
    }
}
