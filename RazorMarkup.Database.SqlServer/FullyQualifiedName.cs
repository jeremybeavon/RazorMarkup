using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer
{
    public abstract class FullyQualifiedName : SqlString
    {
        private readonly string name;
        private readonly ServerName serverName;
        private readonly DatabaseName databaseName;
        private readonly SchemaName schemaName;
        private readonly Options options;

        private enum Options
        {
            None,
            SchemaName,
            DatabaseName,
            DatabaseNameAndSchemaName,
            ServerNameAndDatabaseName,
            ServerNameAndDatabaseNameAndSchemaName
        }

        protected FullyQualifiedName(string name)
            : base(name)
        {
            this.name = name;
            options = Options.None;
        }

        protected FullyQualifiedName(SchemaName schemaName, string name)
            : base(name)
        {
            this.name = name;
            this.schemaName = schemaName;
            options = Options.SchemaName;
        }

        protected FullyQualifiedName(DatabaseName databaseName, string name)
            : base(name)
        {
            this.name = name;
            this.databaseName = databaseName;
            options = Options.DatabaseName;
        }

        protected FullyQualifiedName(DatabaseName databaseName, SchemaName schemaName, string name)
            : base(name)
        {
            this.name = name;
            this.databaseName = databaseName;
            this.schemaName = schemaName;
            options = Options.DatabaseNameAndSchemaName;
        }

        protected FullyQualifiedName(ServerName serverName, DatabaseName databaseName, string name)
            : base(name)
        {
            this.name = name;
            this.serverName = serverName;
            this.databaseName = databaseName;
            options = Options.ServerNameAndDatabaseName;
        }

        protected FullyQualifiedName(ServerName serverName, DatabaseName databaseName, SchemaName schemaName, string name)
            : base(name)
        {
            this.name = name;
            this.serverName = serverName;
            this.databaseName = databaseName;
            this.schemaName = schemaName;
            options = Options.ServerNameAndDatabaseNameAndSchemaName;
        }

        public override Expression ToExpression()
        {
            switch (options)
            {
                case Options.None:
                    return base.ToExpression();
                case Options.SchemaName:
                    return BuildExpression(schemaName);
                case Options.DatabaseName:
                    return BuildExpression(databaseName);
                case Options.DatabaseNameAndSchemaName:
                    return BuildExpression(databaseName, schemaName);
                case Options.ServerNameAndDatabaseName:
                    return BuildExpression(serverName, databaseName);
                case Options.ServerNameAndDatabaseNameAndSchemaName:
                    return BuildExpression(serverName, databaseName, schemaName);
            }

            throw new InvalidOperationException();
        }

        private Expression BuildExpression(params ISqlString[] extraParameters)
        {
            Type[] parameterTypes = extraParameters
                .Select(parameter => parameter.GetType())
                .Concat(new Type[] { typeof(string) })
                .ToArray();
            IEnumerable<Expression> parameterValues = extraParameters.Select(parameter => parameter.ToExpression());
            parameterValues = parameterValues.Concat(new Expression[] { Expression.Constant(name) });
            return Expression.New(GetType().GetConstructor(parameterTypes), parameterValues);
        }
    }
}
