using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
   
        public class DatabaseHelper
        {
            private string serverName = "127.0.0.1";
            private string port = "3306";
            private string databaseName = "bismillah";
            private string databaseUser = "root";
            private string databasePassword = " ";

            private DatabaseHelper() { }

            private static DatabaseHelper _instance;

            public static DatabaseHelper Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new DatabaseHelper();
                    return _instance;
                }
            }


        public int Update(string query, params MySqlParameter[] parameters)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteNonQuery();
                }
            }
        }
        public object ExecuteScalar(string query)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    return command.ExecuteScalar();
                }
            }
        }

        // Add this overload for parameterized queries
        public object ExecuteScalar(string query, params MySqlParameter[] parameters)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteScalar();
                }
            }
        }
        public static string FormatAsPKR(decimal amount)
        {
            return string.Format("Rs. {0:#,##0.00}", amount);
        }
        public MySqlConnection getConnection()
            {
                string connectionString = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Required;";
                return new MySqlConnection(connectionString);
            }

            public MySqlDataReader GetDataReader(string query)
            {
                var connection = getConnection();
                connection.Open();
                var command = new MySqlCommand(query, connection);
                return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }

        // Add this method to your DatabaseHelper class
       
        public System.Data.DataTable GetDataTable(string query)
            {
                using (var connection = getConnection())
                {
                    connection.Open();
                    var da = new MySqlDataAdapter(query, connection);
                    var dt = new System.Data.DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

            public int Update(string query)
            {
                using (var connection = getConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        return command.ExecuteNonQuery();
                    }
                }
            }
            public DataTable ExecuteQuery(string query)
            {
                using (var connection = getConnection())
                {
                    using (var command = new MySqlCommand(query, connection))
                    {
                        using (var adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            public int Scaler(string query)
            {
                using (var connection = getConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result == null ? 0 : Convert.ToInt32(result);
                    }
                }
            }
        }

    }

