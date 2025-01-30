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
                    Console.WriteLine("Connexion fermée.");
                }
            }
            return list;
        }
    }
}