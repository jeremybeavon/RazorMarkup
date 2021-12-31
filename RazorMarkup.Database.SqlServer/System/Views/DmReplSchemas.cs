using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplSchemas
    {
        public static readonly ViewName ViewName = new("sys.dm_repl_schemas");

        public static readonly Column<SqlVarbinary> ArtcacheSchemaAddress = new("artcache_schema_address");

        public static readonly Column<SqlSmallInt> Cctabname = new("ccTabname");

        public static readonly Column<SqlSmallInt> Cctabschema = new("ccTabschema");

        public static readonly Column<SqlInt> Idsch = new("idSch");

        public static readonly Column<SqlSmallInt> Indexid = new("indexid");

        public static readonly Column<SqlInt> NumPkCols = new("num_pk_cols");

        public static readonly Column<SqlVarbinary> Pcitee = new("pcitee");

        public static readonly Column<SqlNVarchar> ReAwcname = new("re_awcName");

        public static readonly Column<SqlTinyInt> ReBitpos = new("re_bitpos");

        public static readonly Column<SqlSmallInt> ReCcname = new("re_ccName");

        public static readonly Column<SqlSmallInt> ReColattr = new("re_colattr");

        public static readonly Column<SqlInt> ReColid = new("re_colid");

        public static readonly Column<SqlInt> ReCollatid = new("re_collatid");

        public static readonly Column<SqlInt> ReComputed = new("re_computed");

        public static readonly Column<SqlTinyInt> ReFansitrim = new("re_fAnsiTrim");

        public static readonly Column<SqlTinyInt> ReFnullable = new("re_fNullable");

        public static readonly Column<SqlSmallInt> ReMaxlen = new("re_maxlen");

        public static readonly Column<SqlInt> ReNumcols = new("re_numcols");

        public static readonly Column<SqlInt> ReNumtextcols = new("re_numtextcols");

        public static readonly Column<SqlInt> ReOffset = new("re_offset");

        public static readonly Column<SqlTinyInt> RePrec = new("re_prec");

        public static readonly Column<SqlTinyInt> ReScale = new("re_scale");

        public static readonly Column<SqlNVarchar> ReSchemaLsnBegin = new("re_schema_lsn_begin");

        public static readonly Column<SqlNVarchar> ReSchemaLsnEnd = new("re_schema_lsn_end");

        public static readonly Column<SqlTinyInt> ReXvtype = new("re_xvtype");

        public static readonly Column<SqlBigInt> RowsetidDelete = new("rowsetid_delete");

        public static readonly Column<SqlBigInt> RowsetidInsert = new("rowsetid_insert");

        public static readonly Column<SqlTinyInt> SeBitpos = new("se_bitpos");

        public static readonly Column<SqlInt> SeColid = new("se_colid");

        public static readonly Column<SqlInt> SeCollatid = new("se_collatid");

        public static readonly Column<SqlTinyInt> SeComputed = new("se_computed");

        public static readonly Column<SqlTinyInt> SeFansitrim = new("se_fAnsiTrim");

        public static readonly Column<SqlTinyInt> SeFnullable = new("se_fNullable");

        public static readonly Column<SqlSmallInt> SeMaxlen = new("se_maxlen");

        public static readonly Column<SqlSmallInt> SeNullbitinleafrows = new("se_nullBitInLeafRows");

        public static readonly Column<SqlInt> SeNumcols = new("se_numcols");

        public static readonly Column<SqlInt> SeOffset = new("se_offset");

        public static readonly Column<SqlTinyInt> SePrec = new("se_prec");

        public static readonly Column<SqlBigInt> SeRowsetid = new("se_rowsetid");

        public static readonly Column<SqlTinyInt> SeScale = new("se_scale");

        public static readonly Column<SqlNVarchar> SeSchemaLsnBegin = new("se_schema_lsn_begin");

        public static readonly Column<SqlNVarchar> SeSchemaLsnEnd = new("se_schema_lsn_end");

        public static readonly Column<SqlTinyInt> SeXvtype = new("se_xvtype");

        public static readonly Column<SqlInt> Tabid = new("tabid");

        public static readonly Column<SqlNVarchar> Tabname = new("tabname");

        public static readonly Column<SqlNVarchar> Tabschema = new("tabschema");
    }
}
