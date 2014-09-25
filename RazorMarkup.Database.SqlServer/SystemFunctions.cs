using RazorMarkup.Database.SqlServer.Expressions.Functions;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class SystemFunctions
    {
        public static SqlInt Partition(PartitionFunctionName partitionFunctionName, object expression)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Partition(
            DatabaseName databaseName,
            PartitionFunctionName partitionFunctionName,
            object expression)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Error()
        {
            throw new NotInExpressionException();
        }

        public static SqlNumeric Identity()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt PackReceived()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt RowCount()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt TransactionCount()
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary BinaryChecksum(object expression, params object[] expressions)
        {
            throw new NotInExpressionException();
        }

        public static IChecksum<SqlVarbinary> BinaryChecksum()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Checksum(object expression, params object[] expressions)
        {
            throw new NotInExpressionException();
        }

        public static IChecksum<SqlInt> Checksum()
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant ConnectionProperty(Text property) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlBinary ContextInfo()
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallInt CurrentRequestId()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ErrorLine()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar ErrorMessage()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ErrorNumber()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar ErrorProcedure()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ErrorSeverity()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ErrorState()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar FormatMessage(SqlInt messageNumber, params object[] parameterValues)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt GetAnsiNull()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt GetAnsiNull(SqlNChar databaseName)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt GetAnsiNull(DatabaseName databaseName)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinaryMax GetFileStreamTransactionContext()
        {
            throw new NotInExpressionException();
        }

        public static SqlChar HostId()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar HostName()
        {
            throw new NotInExpressionException();
        }

        public static T IsNull<T>(T checkExpression, T replacementValue)
            where T : ISqlType
        {
            throw new NotInExpressionException();
        }

        public static SqlBit IsNumeric(object expression)
        {
            throw new NotInExpressionException();
        }

        public static SqlBinary MinActiveRowVersion()
        {
            throw new NotInExpressionException();
        }

        public static SqlUniqueIdentifier NewId()
        {
            throw new NotInExpressionException();
        }

        public static SqlUniqueIdentifier NewSequentialId()
        {
            throw new NotInExpressionException();
        }

        public static SqlBigInt RowCountBig()
        {
            throw new NotInExpressionException();
        }

        public static SqlSmallInt TransactionState()
        {
            throw new NotInExpressionException();
        }
    }
}
