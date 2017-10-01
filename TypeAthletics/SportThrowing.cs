using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_Store.TypeAthletics
{
    class SportThrowing : KindSport.Athletics //Спортивное метание
    {
        public SportThrowing(int id, string name, string kindSport, string athleticsType) : base(id, name, kindSport, athleticsType)
        {
        }
        public override string ShowElement()
        {
            return base.ShowElement();
        }
    }
}
