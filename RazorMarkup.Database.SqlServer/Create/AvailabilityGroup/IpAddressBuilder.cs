namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class IpAddressBuilder : AbstractStatementTextBuilder
    {
        public IpAddressBuilder(string ipv6Address)
        {
            Ipv6Address = ipv6Address;
        }

        public IpAddressBuilder(string ipv4Address, string ipv4Mask)
        {
            Ipv4Address = ipv4Address;
            Ipv4Mask = ipv4Mask;
        }

        public string Ipv4Address { get; private set; }

        public string Ipv4Mask { get; private set; }

        public string Ipv6Address { get; private set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("( ");
            if (Ipv4Address == null)
            {
                sqlBuilder.Append("'");
                sqlBuilder.Append(Ipv6Address);
                sqlBuilder.Append("'");
            }
            else
            {
                sqlBuilder.Append("'");
                sqlBuilder.Append(Ipv4Address);
                sqlBuilder.Append("', '");
                sqlBuilder.Append(Ipv4Mask);
                sqlBuilder.Append("'");
            }

            sqlBuilder.Append(" )");
        }
    }
}
