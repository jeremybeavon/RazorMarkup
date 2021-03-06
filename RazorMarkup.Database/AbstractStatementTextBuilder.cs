﻿namespace RazorMarkup.Database
{
    public abstract class AbstractStatementTextBuilder
    {
        public string ToSqlString()
        {
            SqlBuilder sqlBuilder = new SqlBuilder();
            ToSqlString(sqlBuilder);
            return sqlBuilder.ToSqlString();
        }

        public abstract void ToSqlString(SqlBuilder sqlBuilder);
    }
}
