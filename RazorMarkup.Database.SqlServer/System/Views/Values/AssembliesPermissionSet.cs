namespace RazorMarkup.Database.SqlServer.System.Views.Values
{
    // Up to: https://msdn.microsoft.com/en-us/library/bb630369.aspx
    public sealed class AssembliesPermissionSet
    {
        public const int SafeAccess = 1;

        public const int ExternalAccess = 2;

        public const int UnsafeAccess = 3;

        private AssembliesPermissionSet()
        {
        }
    }
}
