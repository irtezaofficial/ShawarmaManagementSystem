using System.Data;

namespace ShawarmaManagementSystem
{
    public class DatabaseAdaptee : IDatabaseAdapter
    {
        private readonly SqlServerAdapter _sqlServer;
        public DatabaseAdaptee()
        {
            _sqlServer = new SqlServerAdapter();
        }

        public string Executecmd(string query)
        {
            return _sqlServer.Execution(query);
        }

        public DataTable GetShawarmaList(string query)
        {
            var dataTable = _sqlServer.SearchDataTable(query);
            return dataTable;
        }

        public List<string> GetShawarmaNameList(string query)
        {
            return _sqlServer.SearchList(query);
        }

        public string GetInText(string query)
        {
            return _sqlServer.SearchText(query);
        }

        public string ExecuteSingleQuery(string query)
        {
            return _sqlServer.ExecuteSingleQuery(query);
        }
    }
}
