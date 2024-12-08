using System.Data;

namespace ShawarmaManagementSystem
{
    public class DatabaseAdapter : IDatabaseAdapter
    {
        private readonly SqlServer _sqlServer;
        public DatabaseAdapter()
        {
            _sqlServer = new SqlServer();
        }

        public bool ValidateUser(string query)
        {
            return _sqlServer.Validation(query);
        }

        public string Executecmd(string query)
        {
            return _sqlServer.Execution(query);
        }

        public DataTable GetInDataTable(string query)
        {
            return _sqlServer.SearchDataTable(query);
        }

        public DataTable GetShawarmaList(string query)
        {
            var dataTable = _sqlServer.SearchDataTable(query);
            return dataTable;
        }

        public List<string> GetInList(string query)
        {
            return _sqlServer.SearchList(query);
        }

        public string GetInText(string query)
        {
            return _sqlServer.SearchText(query);
        }

        public object ExecuteScalar(string query)
        {
            return _sqlServer.ExecuteScalar(query);
        }

        public string ExecuteSingleQuery(string query)
        {
            return _sqlServer.ExecuteSingleQuery(query);
        }

        public List<string> ExecuteSelectQuery(string query)
        {
            return _sqlServer.ExecuteSelectQuery(query);
        }

        private static ShawarmaType? GetShawarmaType(string? shawarmaType)
        {
            if (shawarmaType == "0")
                return ShawarmaType.Chicken;
            else if (shawarmaType == "1")
                return ShawarmaType.Beef;
            else if (shawarmaType == "2")
                return ShawarmaType.Veg;

            return null;
        }
    }
}
