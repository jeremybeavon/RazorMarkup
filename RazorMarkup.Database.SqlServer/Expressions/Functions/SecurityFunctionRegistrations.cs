using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class SecurityFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(
                FunctionNames.CertificateEncoded,
                () => SecurityFunctions.CertificateEncoded(null));
            functionRegistrationManager.Register(
                FunctionNames.CertificatePrivateKey,
                () => SecurityFunctions.CertificatePrivateKey(null, null),
                () => SecurityFunctions.CertificatePrivateKey(null, null, null));
            functionRegistrationManager.RegisterRaw(FunctionNames.CurrentUser, () => SecurityFunctions.CurrentUser());
            functionRegistrationManager.Register(FunctionNames.HasDbAccess, () => SecurityFunctions.HasDbAccess(null));
            functionRegistrationManager.Register(
                FunctionNames.HasPermissionsByName,
                () => SecurityFunctions.HasPermissionsByName(null, null, null),
                () => SecurityFunctions.HasPermissionsByName(null, null, null, null),
                () => SecurityFunctions.HasPermissionsByName(null, null, null, null, null));
            functionRegistrationManager.Register(FunctionNames.IsMember, () => SecurityFunctions.IsMember(null));
            functionRegistrationManager.Register(
                FunctionNames.IsRoleMember,
                () => SecurityFunctions.IsRoleMember(null),
                () => SecurityFunctions.IsRoleMember(null, null));
            functionRegistrationManager.Register(
                FunctionNames.IsServerRoleMember,
                () => SecurityFunctions.IsServerRoleMember(null),
                () => SecurityFunctions.IsServerRoleMember(null, null));
            functionRegistrationManager.Register(
                FunctionNames.LoginProperty,
                () => SecurityFunctions.LoginProperty(null, null));
            functionRegistrationManager.Register(FunctionNames.OriginalLogin, () => SecurityFunctions.OriginalLogin());
            functionRegistrationManager.Register(
                FunctionNames.Permissions,
                () => SecurityFunctions.Permissions(),
                () => SecurityFunctions.Permissions(null),
                () => SecurityFunctions.Permissions(null, null));
            functionRegistrationManager.Register(
                FunctionNames.PasswordCompare,
                () => SecurityFunctions.PasswordCompare(null, null));
            functionRegistrationManager.Register(FunctionNames.PasswordEncrypt, () => SecurityFunctions.PasswordEncrypt(null));
            functionRegistrationManager.RegisterRaw(FunctionNames.SessionUser, () => SecurityFunctions.SessionUser());
            functionRegistrationManager.Register(FunctionNames.SessionProperty, () => SecurityFunctions.SessionProperty(null));
            functionRegistrationManager.Register(
                FunctionNames.ServerUserId,
                () => SecurityFunctions.ServerUserId(),
                () => SecurityFunctions.ServerUserId(null));
            functionRegistrationManager.Register(
                FunctionNames.ServerUserName,
                () => SecurityFunctions.ServerUserName(),
                () => SecurityFunctions.ServerUserName(null));
            functionRegistrationManager.Register(
                FunctionNames.ServerUserSid,
                () => SecurityFunctions.ServerUserSid(),
                () => SecurityFunctions.ServerUserSid(null),
                () => SecurityFunctions.ServerUserSid(null, null));
            functionRegistrationManager.Register(
                FunctionNames.ServerUserSidName,
                () => SecurityFunctions.ServerUserSidName(),
                () => SecurityFunctions.ServerUserSidName(null));
            functionRegistrationManager.RegisterRaw(FunctionNames.SystemUser, () => SecurityFunctions.SystemUser());
            functionRegistrationManager.RegisterRaw(FunctionNames.User, () => SecurityFunctions.User());
            functionRegistrationManager.Register(
                FunctionNames.UserName,
                () => SecurityFunctions.UserName(),
                () => SecurityFunctions.UserName(null));
        }
    }
}
