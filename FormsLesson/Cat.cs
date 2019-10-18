using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    class Cat:Animal
    {
        private int harmfulness;
        public string food;
        public string command;
        public int star;
        public int speed;
        public string place;
        public int time;

        public Cat (string name, int age, string owner, int harmfulness)
            : base (name, age, owner)
        {
            this.harmfulness = harmfulness;
        }


    }
}
