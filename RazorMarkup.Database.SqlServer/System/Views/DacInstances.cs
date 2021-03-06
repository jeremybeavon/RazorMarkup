﻿using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class DacInstances
    {
        public static readonly ViewName ViewName = new ViewName("dbo.sysdac_instances");

        public static readonly Column<SqlUniqueIdentifier> InstanceId = new Column<SqlUniqueIdentifier>("instance_id");

        public static readonly Column<SqlSysname> InstanceName = new Column<SqlSysname>("instance_name");

        public static readonly Column<SqlSysname> TypeName = new Column<SqlSysname>("type_name");

        public static readonly Column<SqlNVarchar> TypeVersion = new Column<SqlNVarchar>("type_version");

        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");

        public static readonly Column<SqlVarbinary> TypeStream = new Column<SqlVarbinary>("type_stream");

        public static readonly Column<SqlDateTime> DateCreated = new Column<SqlDateTime>("date_created");

        public static readonly Column<SqlSysname> CreatedBy = new Column<SqlSysname>("created_by");

        public static readonly Column<SqlSysname> DatabaseName = new Column<SqlSysname>("database_name");
    }
}
