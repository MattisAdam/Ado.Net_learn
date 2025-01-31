using Ado.Net.Learning.Data.Base;

namespace Ado.Net.Learning.Data.Models
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
        public Game(string name, bool rankingType) : this( 9, name, rankingType)
        {
        }
        public Game(int id)
        {
            Id = id;
        }
        public Game(string name) { name = Name; }
    }
}