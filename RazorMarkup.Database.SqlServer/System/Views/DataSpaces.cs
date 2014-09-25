using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class DataSpaces
    {
        public static readonly ViewName ViewName = new ViewName("sys.data_spaces");

        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");

        public static readonly Column<SqlInt> DataSpaceId = new Column<SqlInt>("data_space_id");

        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");

        public static readonly Column<SqlChar, DataSpacesTypes> Type = new Column<SqlChar, DataSpacesTypes>("type");

        public static readonly Column<SqlChar, DataSpacesTypeDescriptions> TypeDescription =
            new Column<SqlChar, DataSpacesTypeDescriptions>("type_desc");

        public static readonly Column<SqlBit> IsDefault = new Column<SqlBit>("is_default");

        public static readonly Column<SqlBit> IsSystem = new Column<SqlBit>("is_system");
    }
}
