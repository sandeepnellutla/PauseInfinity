using System.Data;

namespace InfinityDataService.Dal
{
    public interface IDataConnection
    {
        IDbConnection GetConnection();
    }
}
