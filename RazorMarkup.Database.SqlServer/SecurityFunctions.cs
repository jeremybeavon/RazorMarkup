using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class SecurityFunctions
    {
        public static SqlVarbinary CertificateEncoded(SqlInt certificateId)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary CertificatePrivateKey(SqlInt certificateId, Text encryptionPassword)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary CertificatePrivateKey(
            SqlInt certificateId,
            Text encryptionPassword,
            Text decryptionPassword)
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname CurrentUser()
        {
            throw new NotInExpressionException();
        }

        public static SqlBit HasDbAccess(SqlSysname databaseName)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit HasPermissionsByName(
            SqlSysname securable,
            SqlNVarchar securableClass,
            SqlSysname permission)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit HasPermissionsByName(
            SqlSysname securable,
            SqlNVarchar securableClass,
            SqlSysname permission,
            SqlSysname subSecurable)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit HasPermissionsByName(
            SqlSysname securable,
            SqlNVarchar securableClass,
            SqlSysname permission,
            SqlSysname subSecurable,
            SqlNVarchar subSecurableClass)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit IsMember(SqlSysname groupOrRole)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit IsRoleMember(SqlSysname roleName)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit IsRoleMember(SqlSysname roleName, SqlSysname databasePrincipal)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit IsServerRoleMember(SqlSysname role) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlBit IsServerRoleMember(SqlSysname role, SqlSysname login) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant LoginProperty(Text loginName, Text propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlSysname OriginalLogin()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Permissions()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Permissions(SqlInt objectId)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt Permissions(SqlInt objectId, Text column)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary PasswordEncrypt(SqlSysname password)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit PasswordCompare(SqlSysname clearTextPassword, SqlVarbinary passwordHash)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar SessionUser()
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant SessionProperty(Text option) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ServerUserId()
        {
            throw new NotInExpressionException();
        }

        public static SqlInt ServerUserId(SqlNChar login)
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar ServerUserName()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar ServerUserName(SqlInt serverUserId)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary ServerUserSid()
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary ServerUserSid(SqlSysname login)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary ServerUserSid(SqlSysname login, SqlInt param2)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar ServerUserSidName()
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar ServerUserSidName(SqlVarbinary serverUserSid)
        {
            throw new NotInExpressionException();
        }

        public static SqlNChar SystemUser()
        {
            throw new NotInExpressionException();
        }

        public static SqlChar User()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar UserName()
        {
            throw new NotInExpressionException();
        }

        public static SqlNVarchar UserName(SqlInt userId)
        {
            throw new NotInExpressionException();
        }
    }
}
