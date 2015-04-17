using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplSchemas
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_repl_schemas");
        
        public static readonly Column<SqlVarbinary> ArtcacheSchemaAddress = new Column<SqlVarbinary>("artcache_schema_address");
        
        public static readonly Column<SqlSmallInt> Cctabname = new Column<SqlSmallInt>("ccTabname");
        
        public static readonly Column<SqlSmallInt> Cctabschema = new Column<SqlSmallInt>("ccTabschema");
        
        public static readonly Column<SqlInt> Idsch = new Column<SqlInt>("idSch");
        
        public static readonly Column<SqlSmallInt> Indexid = new Column<SqlSmallInt>("indexid");
        
        public static readonly Column<SqlInt> NumPkCols = new Column<SqlInt>("num_pk_cols");
        
        public static readonly Column<SqlVarbinary> Pcitee = new Column<SqlVarbinary>("pcitee");
        
        public static readonly Column<SqlNVarchar> ReAwcname = new Column<SqlNVarchar>("re_awcName");
        
        public static readonly Column<SqlTinyInt> ReBitpos = new Column<SqlTinyInt>("re_bitpos");
        
        public static readonly Column<SqlSmallInt> ReCcname = new Column<SqlSmallInt>("re_ccName");
        
        public static readonly Column<SqlSmallInt> ReColattr = new Column<SqlSmallInt>("re_colattr");
        
        public static readonly Column<SqlInt> ReColid = new Column<SqlInt>("re_colid");
        
        public static readonly Column<SqlInt> ReCollatid = new Column<SqlInt>("re_collatid");
        
        public static readonly Column<SqlInt> ReComputed = new Column<SqlInt>("re_computed");
        
        public static readonly Column<SqlTinyInt> ReFansitrim = new Column<SqlTinyInt>("re_fAnsiTrim");
        
        public static readonly Column<SqlTinyInt> ReFnullable = new Column<SqlTinyInt>("re_fNullable");
        
        public static readonly Column<SqlSmallInt> ReMaxlen = new Column<SqlSmallInt>("re_maxlen");
        
        public static readonly Column<SqlInt> ReNumcols = new Column<SqlInt>("re_numcols");
        
        public static readonly Column<SqlInt> ReNumtextcols = new Column<SqlInt>("re_numtextcols");
        
        public static readonly Column<SqlInt> ReOffset = new Column<SqlInt>("re_offset");
        
        public static readonly Column<SqlTinyInt> RePrec = new Column<SqlTinyInt>("re_prec");
        
        public static readonly Column<SqlTinyInt> ReScale = new Column<SqlTinyInt>("re_scale");
        
        public static readonly Column<SqlNVarchar> ReSchemaLsnBegin = new Column<SqlNVarchar>("re_schema_lsn_begin");
        
        public static readonly Column<SqlNVarchar> ReSchemaLsnEnd = new Column<SqlNVarchar>("re_schema_lsn_end");
        
        public static readonly Column<SqlTinyInt> ReXvtype = new Column<SqlTinyInt>("re_xvtype");
        
        public static readonly Column<SqlBigInt> RowsetidDelete = new Column<SqlBigInt>("rowsetid_delete");
        
        public static readonly Column<SqlBigInt> RowsetidInsert = new Column<SqlBigInt>("rowsetid_insert");
        
        public static readonly Column<SqlTinyInt> SeBitpos = new Column<SqlTinyInt>("se_bitpos");
        
        public static readonly Column<SqlInt> SeColid = new Column<SqlInt>("se_colid");
        
        public static readonly Column<SqlInt> SeCollatid = new Column<SqlInt>("se_collatid");
        
        public static readonly Column<SqlTinyInt> SeComputed = new Column<SqlTinyInt>("se_computed");
        
        public static readonly Column<SqlTinyInt> SeFansitrim = new Column<SqlTinyInt>("se_fAnsiTrim");
        
        public static readonly Column<SqlTinyInt> SeFnullable = new Column<SqlTinyInt>("se_fNullable");
        
        public static readonly Column<SqlSmallInt> SeMaxlen = new Column<SqlSmallInt>("se_maxlen");
        
        public static readonly Column<SqlSmallInt> SeNullbitinleafrows = new Column<SqlSmallInt>("se_nullBitInLeafRows");
        
        public static readonly Column<SqlInt> SeNumcols = new Column<SqlInt>("se_numcols");
        
        public static readonly Column<SqlInt> SeOffset = new Column<SqlInt>("se_offset");
        
        public static readonly Column<SqlTinyInt> SePrec = new Column<SqlTinyInt>("se_prec");
        
        public static readonly Column<SqlBigInt> SeRowsetid = new Column<SqlBigInt>("se_rowsetid");
        
        public static readonly Column<SqlTinyInt> SeScale = new Column<SqlTinyInt>("se_scale");
        
        public static readonly Column<SqlNVarchar> SeSchemaLsnBegin = new Column<SqlNVarchar>("se_schema_lsn_begin");
        
        public static readonly Column<SqlNVarchar> SeSchemaLsnEnd = new Column<SqlNVarchar>("se_schema_lsn_end");
        
        public static readonly Column<SqlTinyInt> SeXvtype = new Column<SqlTinyInt>("se_xvtype");
        
        public static readonly Column<SqlInt> Tabid = new Column<SqlInt>("tabid");
        
        public static readonly Column<SqlNVarchar> Tabname = new Column<SqlNVarchar>("tabname");
        
        public static readonly Column<SqlNVarchar> Tabschema = new Column<SqlNVarchar>("tabschema");
    }
}
