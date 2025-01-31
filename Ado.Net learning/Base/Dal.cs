using Ado.Net_learning.Models;
using Ado.Net_learning.SqlDefinition;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Ado.Net_learning.Base
{
    public static class Dal
    {
        public static List<T1> GetData<T1, T2>(string query, string connectionString) where T1 : IModel where T2 : BaseSqlDefinition<T1>
        {
            List<T1> list = new List<T1>();
            var objSqlDefinition = (T2)Activator.CreateInstance(typeof(T2), null);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                objSqlDefinition.SetSqlData(list, reader);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur : {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Connexion Réussie.");
                }
                connection.Close();
            }
            return list;
        }
        public static void ExecuteSql(string connectionString, Game game, string query )
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;


                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erreur : {ex.Message}");
                    }

                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

    }
}
