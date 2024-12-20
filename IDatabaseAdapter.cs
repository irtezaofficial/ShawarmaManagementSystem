using System.Data;

namespace ShawarmaManagementSystem
{
    public interface IDatabaseAdapter
    {
        string Executecmd(string query);
        DataTable GetShawarmaList(string query);
        List<string> GetShawarmaNameList(string query);
        string GetInText(string query);
        string ExecuteSingleQuery(string query);
    }
}
