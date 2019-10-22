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
        public string food;
        public string command;
        public int star;
        public int speed;
        public string place;
        public int time;

        public Raccoon(string name, int age, string owner, int fluff)
            : base(name, age, owner)
        {
            this.fluff = fluff;
        }

    }
}
