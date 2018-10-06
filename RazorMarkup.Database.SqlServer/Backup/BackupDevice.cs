namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupDevice
    {
        public string DeviceType { get; set; }

        public string Name { get; set; }

        public VariableName Variable { get; set; }

        public bool IncludeQuotes { get; set; }

        public void ToSqlString(SqlBuilder sqlBuilder)
        {
            if (DeviceType != null)
            {
                sqlBuilder.Append(DeviceType);
                sqlBuilder.Append(" = ");
            }

            if (Name == null)
            {
                sqlBuilder.Append(Variable.ToSqlString());
            }
            else
            {
                if (IncludeQuotes)
                {
                    sqlBuilder.Append("'");
                }

                sqlBuilder.Append(Name);
                if (IncludeQuotes)
                {
                    sqlBuilder.Append("'");
                }
            }
        }
    }
}
