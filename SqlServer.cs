using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace ShawarmaManagementSystem
{
    internal class SqlServer
    {
        private SqlConnection _connection;

        public SqlServer()
        {
            _connection = DatabaseConnectionManager.Instance.GetConnection();
        }

        public bool Validation(string query)
        {
            _connection.Open();
            SqlCommand cmd = new(query, _connection);
            SqlDataReader dr = cmd.ExecuteReader();
            bool result = dr.Read();
            _connection.Close();
            return result;
        }

        public string Execution(string query)
        {
            _connection.Open();
            SqlCommand cmd = new(query, _connection);
            int a = cmd.ExecuteNonQuery();
            _connection.Close();
            return a > 0 ? "Executed Successfully" : "Not Executed";
        }

        public DataTable SearchDataTable(string query)
        {
            _connection.Open();
            DataTable dt = new();
            SqlDataAdapter da = new(query, _connection);
            da.Fill(dt);
            _connection.Close();
            return dt;
        }

        public List<string> SearchList(string query)
        {
            List<string> items = new();
            _connection.Open();
            SqlCommand cmd = new(query, _connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                items.Add(dr[0].ToString()!);
            }
            _connection.Close();
            return items;
        }

        public string SearchText(string query)
        {
            string item = string.Empty;
            _connection.Open();
            SqlCommand cmd = new(query, _connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                item = dr[0].ToString()!;
            }
            _connection.Close();
            return item;
        }

        public string? ExecuteScalarToString(string query)
        {
            try
            {
                _connection.Open();
                using SqlCommand cmd = new SqlCommand(query, _connection);
                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                _connection.Open();
                using SqlCommand cmd = new SqlCommand(query, _connection);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public string ExecuteSingleQuery(string query)
        {
            Dictionary<string, object>? result = null;

            try
            {
                _connection.Open();

                using SqlCommand cmd = new(query, _connection);
                using SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = [];
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        result[dr.GetName(i)] = dr.GetValue(i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }

            return JsonConvert.SerializeObject(result);
        }

        public List<string> ExecuteSelectQuery(string query)
        {
            List<string> results = new();

            try
            {
                _connection.Open();

                using SqlCommand cmd = new(query, _connection);
                using SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Dictionary<string, object> row = new();
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        row[dr.GetName(i)] = dr.GetValue(i);
                    }
                    results.Add(JsonConvert.SerializeObject(row));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }

            return results;
        }
    }
}
