using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store.TypeSkatesSkiingSport
{
    class Skates : KindSport.SkatesSkiingSport //Коньки
    {
        public int SkatesSize { get; set; }
        public Skates(int id, string name, string kindSport, string skatesSkiingSportType, int skatesSize) : base(id, name, kindSport, skatesSkiingSportType)
        {
            SkatesSize = skatesSize;
        }
        public override string ShowElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ShowElement());
            sb.Append("Размер коньков: " + SkatesSize);
            return sb.ToString();
        }
    }
}
