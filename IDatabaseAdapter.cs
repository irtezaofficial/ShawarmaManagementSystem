using System.Data;

namespace ShawarmaManagementSystem
{
    public interface IDatabaseAdapter
    {
        bool ValidateUser(string query);
        string Executecmd(string query);
        DataTable GetInDataTable(string query);
        DataTable GetShawarmaList(string query);
        List<string> GetInList(string query);
        string GetInText(string query);
        object ExecuteScalar(string query);
        string ExecuteSingleQuery(string query);
        List<string> ExecuteSelectQuery(string query);
    }
}
