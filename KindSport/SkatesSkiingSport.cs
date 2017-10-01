using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store.KindSport
{
    class SkatesSkiingSport : SportsEquipment //коньколыжный спорт
    {
        public string SkatesSkiingSportType { get; set; }
        public SkatesSkiingSport(int id, string name, string kindSport, string skatesSkiingSportType) : base(id, name, kindSport)
        {
            SkatesSkiingSportType = skatesSkiingSportType;
        }
        public override string ShowElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ShowElement());
            sb.Append("Тип: " + SkatesSkiingSportType);
            return sb.ToString();
        }
        public override string ShowParentInfo()
        {
            return "Тип родительского класса: " + base.ShowParentInfo(); ;
        }
    }
}
