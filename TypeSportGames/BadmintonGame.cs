using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store.TypeSportGames
{
    class BadmintonGame : KindSport.SportGames //Игра в бадминтон
    {
        public string Material { get; set; }
        public int NumberInKit { get; set; }
        public BadmintonGame(int id, string name, string kindSport, string typeSportGame, string material, int numberInKit) : base(id, name, kindSport, typeSportGame)
        {
            Material = material;
            NumberInKit = numberInKit;
        }
        public override string ShowElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ShowElement());
            sb.AppendLine("Материал: " + Material);
            sb.Append("Количество штук в наборе: " + NumberInKit);
            return sb.ToString();
        }
    }
}
