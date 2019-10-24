using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    class Raccoon : Animal
    {
        private int fluff;

        public Raccoon(string name, int age, string owner, int fluff)
            : base(name, age, owner)
        {
            this.fluff = fluff;
        }

        public new int GetUniq()
        {
            return fluff;
        }

    }
}
