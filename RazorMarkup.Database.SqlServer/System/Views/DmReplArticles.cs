using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplArticles
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_repl_articles");
        
        public static readonly Column<SqlVarbinary> ArtcacheArticleAddress = new Column<SqlVarbinary>("artcache_article_address");
        
        public static readonly Column<SqlVarbinary> ArtcacheDbAddress = new Column<SqlVarbinary>("artcache_db_address");
        
        public static readonly Column<SqlVarbinary> ArtcacheSchemaAddress = new Column<SqlVarbinary>("artcache_schema_address");
        
        public static readonly Column<SqlVarbinary> ArtcacheTableAddress = new Column<SqlVarbinary>("artcache_table_address");
        
        public static readonly Column<SqlTinyInt> Artcmdtype = new Column<SqlTinyInt>("artcmdtype");
        
        public static readonly Column<SqlInt> Artfilter = new Column<SqlInt>("artfilter");
        
        public static readonly Column<SqlNVarchar> Artgendel2cmd = new Column<SqlNVarchar>("artgendel2cmd");
        
        public static readonly Column<SqlNVarchar> Artgendelcmd = new Column<SqlNVarchar>("artgendelcmd");
        
        public static readonly Column<SqlNVarchar> Artgenins2cmd = new Column<SqlNVarchar>("artgenins2cmd");
        
        public static readonly Column<SqlNVarchar> Artgeninscmd = new Column<SqlNVarchar>("artgeninscmd");
        
        public static readonly Column<SqlNVarchar> Artgenupdcmd = new Column<SqlNVarchar>("artgenupdcmd");
        
        public static readonly Column<SqlInt> Artid = new Column<SqlInt>("artid");
        
        public static readonly Column<SqlInt> Artobjid = new Column<SqlInt>("artobjid");
        
        public static readonly Column<SqlNVarchar> Artpartialupdcmd = new Column<SqlNVarchar>("artpartialupdcmd");
        
        public static readonly Column<SqlInt> Artpubid = new Column<SqlInt>("artpubid");
        
        public static readonly Column<SqlTinyInt> Artstatus = new Column<SqlTinyInt>("artstatus");
        
        public static readonly Column<SqlTinyInt> Arttype = new Column<SqlTinyInt>("arttype");
        
        public static readonly Column<SqlNVarchar> Artupdtxtcmd = new Column<SqlNVarchar>("artupdtxtcmd");
        
        public static readonly Column<SqlInt> Cmdtypedel = new Column<SqlInt>("cmdTypeDel");
        
        public static readonly Column<SqlInt> Cmdtypeins = new Column<SqlInt>("cmdTypeIns");
        
        public static readonly Column<SqlInt> Cmdtypepartialupd = new Column<SqlInt>("cmdTypePartialUpd");
        
        public static readonly Column<SqlInt> Cmdtypeupd = new Column<SqlInt>("cmdTypeUpd");
        
        public static readonly Column<SqlTinyInt> Finreconcile = new Column<SqlTinyInt>("fInReconcile");
        
        public static readonly Column<SqlTinyInt> Fpuballowupdate = new Column<SqlTinyInt>("fPubAllowUpdate");
        
        public static readonly Column<SqlInt> Intpublicationoptions = new Column<SqlInt>("intPublicationOptions");
        
        public static readonly Column<SqlInt> Numcol = new Column<SqlInt>("numcol");
        
        public static readonly Column<SqlNVarchar> Wszartdelcmd = new Column<SqlNVarchar>("wszArtdelcmd");
        
        public static readonly Column<SqlNVarchar> Wszartdesttable = new Column<SqlNVarchar>("wszArtdesttable");
        
        public static readonly Column<SqlNVarchar> Wszartdesttableowner = new Column<SqlNVarchar>("wszArtdesttableowner");
        
        public static readonly Column<SqlNVarchar> Wszartinscmd = new Column<SqlNVarchar>("wszArtinscmd");
        
        public static readonly Column<SqlNVarchar> Wszartpartialupdcmd = new Column<SqlNVarchar>("wszArtpartialupdcmd");
        
        public static readonly Column<SqlNVarchar> Wszartupdcmd = new Column<SqlNVarchar>("wszArtupdcmd");
    }
}
