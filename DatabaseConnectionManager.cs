using Microsoft.Data.SqlClient;
using System.Data;

namespace ShawarmaManagementSystem
{
    public class DatabaseConnectionManager
    {
        private static DatabaseConnectionManager? _instance;
        private static readonly object _lock = new object();
        private readonly SqlConnection _connection;

        // Private constructor to prevent instantiation from outside
        private DatabaseConnectionManager()
        {
            // Initialize the connection
            _connection = new SqlConnection(@"Data Source=(local);Initial Catalog=ShawarmaManagmentSystem;Integrated Security=True;TrustServerCertificate=True");
        }

        // Public method to provide access to the instance
        public static DatabaseConnectionManager Instance
        {
            get
            {
                lock (_lock)
                {
                    _instance ??= new DatabaseConnectionManager();
                    return _instance;
                }
            }
        }

        // Method to get the connection
        public SqlConnection GetConnection()
        {
            return _connection;
        }

        // Optional: Method to open the connection
        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        // Optional: Method to close the connection
        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

    }
}
