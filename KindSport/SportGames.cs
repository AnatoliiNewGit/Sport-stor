using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store.KindSport
{
    class SportGames : SportsEquipment //Спортивные игры
    {
        public string SportGameType { get; set; }
        public SportGames(int id, string name, string kindSport, string sportGameType) : base(id, name, kindSport)
        {
            SportGameType = sportGameType;
        }
        public override string ShowElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ShowElement());
            sb.Append("Тип: " + SportGameType);
            return sb.ToString();
        }
        public override string ShowParentInfo()
        {
            return "Тип родительского класса: " + base.ShowParentInfo();
        }
    }
}
