using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplArticles
    {
        public static readonly ViewName ViewName = new("sys.dm_repl_articles");

        public static readonly Column<SqlVarbinary> ArtcacheArticleAddress = new("artcache_article_address");

        public static readonly Column<SqlVarbinary> ArtcacheDbAddress = new("artcache_db_address");

        public static readonly Column<SqlVarbinary> ArtcacheSchemaAddress = new("artcache_schema_address");

        public static readonly Column<SqlVarbinary> ArtcacheTableAddress = new("artcache_table_address");

        public static readonly Column<SqlTinyInt> Artcmdtype = new("artcmdtype");

        public static readonly Column<SqlInt> Artfilter = new("artfilter");

        public static readonly Column<SqlNVarchar> Artgendel2cmd = new("artgendel2cmd");

        public static readonly Column<SqlNVarchar> Artgendelcmd = new("artgendelcmd");

        public static readonly Column<SqlNVarchar> Artgenins2cmd = new("artgenins2cmd");

        public static readonly Column<SqlNVarchar> Artgeninscmd = new("artgeninscmd");

        public static readonly Column<SqlNVarchar> Artgenupdcmd = new("artgenupdcmd");

        public static readonly Column<SqlInt> Artid = new("artid");

        public static readonly Column<SqlInt> Artobjid = new("artobjid");

        public static readonly Column<SqlNVarchar> Artpartialupdcmd = new("artpartialupdcmd");

        public static readonly Column<SqlInt> Artpubid = new("artpubid");

        public static readonly Column<SqlTinyInt> Artstatus = new("artstatus");

        public static readonly Column<SqlTinyInt> Arttype = new("arttype");

        public static readonly Column<SqlNVarchar> Artupdtxtcmd = new("artupdtxtcmd");

        public static readonly Column<SqlInt> Cmdtypedel = new("cmdTypeDel");

        public static readonly Column<SqlInt> Cmdtypeins = new("cmdTypeIns");

        public static readonly Column<SqlInt> Cmdtypepartialupd = new("cmdTypePartialUpd");

        public static readonly Column<SqlInt> Cmdtypeupd = new("cmdTypeUpd");

        public static readonly Column<SqlTinyInt> Finreconcile = new("fInReconcile");

        public static readonly Column<SqlTinyInt> Fpuballowupdate = new("fPubAllowUpdate");

        public static readonly Column<SqlInt> Intpublicationoptions = new("intPublicationOptions");

        public static readonly Column<SqlInt> Numcol = new("numcol");

        public static readonly Column<SqlNVarchar> Wszartdelcmd = new("wszArtdelcmd");

        public static readonly Column<SqlNVarchar> Wszartdesttable = new("wszArtdesttable");

        public static readonly Column<SqlNVarchar> Wszartdesttableowner = new("wszArtdesttableowner");

        public static readonly Column<SqlNVarchar> Wszartinscmd = new("wszArtinscmd");

        public static readonly Column<SqlNVarchar> Wszartpartialupdcmd = new("wszArtpartialupdcmd");

        public static readonly Column<SqlNVarchar> Wszartupdcmd = new("wszArtupdcmd");
    }
}
