using System.Data;
using System.Data.SqlClient;

namespace InfinityDataService.Dal
{
    public class DataConnection : IDataConnection
    {
        readonly static string ConnString = @"Data Source=tcp:s15.winhost.com;Initial Catalog=DB_115782_blog;User ID=DB_115782_blog_user;Password=admin123$;Integrated Security=False;";

        public IDbConnection GetConnection() => new SqlConnection(ConnString);
    }
}