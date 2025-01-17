using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Ado.Net_learning
{
    public static class Dal
    {
        public static List<Game> GetData(string query, string connectionString)
        {
            List<Game> list = new List<Game>();
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
                                var id = (int)reader["Id"];
                                var name = (string)reader["Name"];
                                var rankingType = (bool)reader["RankingType"];
                                var tempGame = new Game(id, name, rankingType);
                                list.Add(tempGame);
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
        public static List<Game> Toto()
        {
            List<Game> list = new List<Game>();
            string connectionString = "Server=tcp:inoksch.database.windows.net,1433;Initial Catalog=mattis.dev;Persist Security Info=False;User ID=it;Password=2Thehouseistallandred!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.Exo2_Game WHERE Name LIKE '%le%'";
                    SqlCommand command = new(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var id = (int)reader["Id"];
                        var name = reader["Name"].ToString();
                        var rankingType = (bool)reader["RankingType"];
                        //Console.WriteLine($"Données récupérées : {name} ");
                        var game = new Game(id, name, rankingType);
                        list.Add(game);
                    }
                    //for(int i = 0; i <= list.Count - 1; i++)
                    //{
                    //    Console.WriteLine(list[i]);
                    //}
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //Console.ReadLine();
            }
            return list;
        }
    }
}
