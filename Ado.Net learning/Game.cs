namespace Ado.Net_learning
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool RankingType { get; set; }

        public Game(int id, string name, bool rankingType)
        {
            Id = id;
            Name = name;
            RankingType = rankingType;
        }
    }
}