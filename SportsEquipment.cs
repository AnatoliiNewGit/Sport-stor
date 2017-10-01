using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store
{
    class SportsEquipment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string KindSport { get; set; } //вид спорта
        public SportsEquipment(int id, string name, string kindSport)
        {
            ID = id;
            Name = name;
            KindSport = kindSport;
        }
        public virtual string ShowElement()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id: " + ID);
            sb.AppendLine("Название: " + Name);
            sb.Append("Вид спорта: " + KindSport);
            return sb.ToString();
        }
        public virtual string ShowParentInfo()
        {
            return GetType().Name;
        }
    }
}
