using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FiletableSystemDefinedObjects
    {
        public static readonly ViewName ViewName = new("sys.filetable_system_defined_objects");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ParentObjectId = new("parent_object_id");
    }
}
