using RazorMarkup.Database.SqlServer.Parser;

namespace RazorMarkup.Harness
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            SqlSourceCodeBuilder.ToSqlString(@"
CREATE AVAILABILITY GROUP MyAg 
   WITH (
      AUTOMATED_BACKUP_PREFERENCE = SECONDARY,
      FAILURE_CONDITION_LEVEL  =  3, 
      HEALTH_CHECK_TIMEOUT = 600000
       )
   
   FOR 
      DATABASE  ThisDatabase, ThatDatabase 
   REPLICA ON 
      'COMPUTER01' WITH 
         (
         ENDPOINT_URL = 'TCP://COMPUTER01:5022',
         AVAILABILITY_MODE = SYNCHRONOUS_COMMIT,
         FAILOVER_MODE = AUTOMATIC,
         BACKUP_PRIORITY = 30,
         SECONDARY_ROLE (ALLOW_CONNECTIONS = NO, 
            READ_ONLY_ROUTING_LIST = (COMPUTER03) ), 
         PRIMARY_ROLE (ALLOW_CONNECTIONS = READ_WRITE, 
            READ_ONLY_ROUTING_LIST = (COMPUTER03) ),
         SESSION_TIMEOUT = 10
         ), 
         
      'COMPUTER02' WITH 
         (
         ENDPOINT_URL = 'TCP://COMPUTER02:5022',
         AVAILABILITY_MODE = SYNCHRONOUS_COMMIT,
         FAILOVER_MODE = AUTOMATIC,
         BACKUP_PRIORITY = 30,
         SECONDARY_ROLE (ALLOW_CONNECTIONS = NO, 
            READ_ONLY_ROUTING_URL = 'TCP://COMPUTER02:1433' ),
         PRIMARY_ROLE (ALLOW_CONNECTIONS = READ_WRITE, 
            READ_ONLY_ROUTING_LIST = (COMPUTER03) ),
         SESSION_TIMEOUT = 10
         ), 
         
      'COMPUTER03' WITH 
         (
         ENDPOINT_URL = 'TCP://COMPUTER03:5022',
         AVAILABILITY_MODE = ASYNCHRONOUS_COMMIT,
         FAILOVER_MODE =  MANUAL,
         BACKUP_PRIORITY = 90,
         SECONDARY_ROLE (ALLOW_CONNECTIONS = READ_ONLY, 
            READ_ONLY_ROUTING_URL = 'TCP://COMPUTER03:1433' ),
         PRIMARY_ROLE (ALLOW_CONNECTIONS = READ_WRITE, 
            READ_ONLY_ROUTING_LIST = NONE ),
         SESSION_TIMEOUT = 10
         )

LISTENER ‘MyAgListenerIvP6’ ( WITH IP ( ('2001:db88:f0:f00f::cf3c'),('2001:4898:e0:f213::4ce2') ) , PORT = 60173 )");
            /*CodeGenerator.GenerateSystemViews(
                "Data Source=.\\SQLEXPRESS;Initial Catalog=\"New Database\";Integrated Security=True;",
                "RazorMarkup.Database.SqlServer.System.Views",
                @"C:\Users\beavon\Documents\Visual Studio 2013\Projects\RazorMarkup\RazorMarkup.Database.SqlServer\System\Views");*/
        }
    }
}
