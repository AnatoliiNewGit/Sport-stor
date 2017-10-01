using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store.KindSport
{
    class Athletics : SportsEquipment //легкая атлетика
    {
        public string AthleticsType { get; set; }
        public Athletics(int id, string name, string kindSport, string athleticsType) : base(id, name, kindSport)
        {
            AthleticsType = athleticsType;
        }
        public override string ShowElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ShowElement());
            sb.Append("Тип легкой атлетики: " + AthleticsType);
            return sb.ToString();
        }
        public override string ShowParentInfo()
        {
            return "Тип родительского класса: " + GetType().Name;
        }
    }
}
