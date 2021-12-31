using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ExtendedProperties
    {
        public static readonly ViewName ViewName = new("sys.extended_properties");

        public static readonly Column<SqlTinyInt> Class = new("class");

        public static readonly Column<SqlNVarchar> ClassDesc = new("class_desc");

        public static readonly Column<SqlInt> MajorId = new("major_id");

        public static readonly Column<SqlInt> MinorId = new("minor_id");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlVariant> Value = new("value");
    }
}
