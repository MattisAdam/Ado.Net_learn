using Ado.Net_learning.Base;

namespace Ado.Net_learning.Models
{
    public class Game : IModel
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
        public Game(string name, bool rankingType) : this(0, name, rankingType)
        {
        }
    }
}