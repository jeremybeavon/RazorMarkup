using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    public static class SchemaObjectNameExtensions
    {
        public static AggregateName ToAggregateName(this SchemaObjectName name)
        {
            return new AggregateName(name.BaseIdentifier.Value);
        }

        public static AssemblyName ToAssemblyName(this SchemaObjectName name)
        {
            return new AssemblyName(name.BaseIdentifier.Value);
        }

        public static FunctionName ToFunctionName(this SchemaObjectName name)
        {
            return new FunctionName(name.BaseIdentifier.Value);
        }

        public static ProcedureName ToProcedureName(this SchemaObjectName name)
        {
            return new ProcedureName(name.BaseIdentifier.Value);
        }

        public static QueueName ToQueueName(this SchemaObjectName name)
        {
            return new QueueName(name.BaseIdentifier.Value);
        }

        public static SchemaName ToSchemaName(this SchemaObjectName name)
        {
            return new SchemaName(name.BaseIdentifier.Value);
        }

        public static SynonymName ToSynonymName(this SchemaObjectName name)
        {
            return new SynonymName(name.BaseIdentifier.Value);
        }

        public static TableName ToTableName(this SchemaObjectName name)
        {
            return new TableName(name.BaseIdentifier.Value);
        }

        public static TypeName ToTypeName(this SchemaObjectName name)
        {
            return new TypeName(name.BaseIdentifier.Value);
        }
    }
}
