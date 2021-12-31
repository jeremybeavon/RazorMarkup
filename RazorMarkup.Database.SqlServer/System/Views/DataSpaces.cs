using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class DataSpaces
    {
        public static readonly ViewName ViewName = new("sys.data_spaces");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> DataSpaceId = new("data_space_id");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlChar, DataSpacesTypes> Type = new("type");

        public static readonly Column<SqlChar, DataSpacesTypeDescriptions> TypeDescription =
            new("type_desc");

        public static readonly Column<SqlBit> IsDefault = new("is_default");

        public static readonly Column<SqlBit> IsSystem = new("is_system");
    }
}
