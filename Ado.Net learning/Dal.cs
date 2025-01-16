using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Ado.Net_learning
{
    public static class Dal
    {
        public static void blabla()
        {
            string connectionString = "Server=tcp:inoksch.database.windows.net,1433;Initial Catalog=mattis.dev;Persist Security Info=False;User ID=it;Password=2Thehouseistallandred!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connexion réussie à la base de données.");
                    string query = "SELECT * FROM dbo.Exo2_Game";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var id = reader["Id"];
                                var name = reader["Name"];
                                var rankingType = reader["RankingType"];
                                Console.WriteLine($"Données récupérées : {id} - {name} - {rankingType}");
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
        }
        public static void toto()
        {
            string connectionString = "Server=tcp:inoksch.database.windows.net,1433;Initial Catalog=mattis.dev;Persist Security Info=False;User ID=it;Password=2Thehouseistallandred!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.Exo2_Game";
                    SqlCommand command = new(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var id = reader["Id"];
                        var name = reader["Name"];
                        var rankingType = reader["RankingType"];
                        Console.WriteLine($"Données récupérées : {name} ");
                       
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }   
        }
    }
}
