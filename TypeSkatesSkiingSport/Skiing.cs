using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store.TypeSkatesSkiingSport
{
    class Skiing : KindSport.SkatesSkiingSport //Лыжи
    {
        public int SkiingLength { get; set; }
        public Skiing(int id, string name, string kindSport, int skiingLength, string skatesSkiingSportType) : base(id, name, kindSport, skatesSkiingSportType)
        {
            SkiingLength = skiingLength;
        }
        public override string ShowElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ShowElement());
            sb.Append("Длина лыж: " + SkiingLength);
            return sb.ToString();
        }
    }
}
