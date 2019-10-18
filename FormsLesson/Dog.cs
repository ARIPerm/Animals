using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    class Dog:Animal
    {
        private int danger;
        public string food;
        public string command;
        public int star;
        public int speed;
        public string place;
        public int time;

        public Dog(string name, int age, string owner, int danger)
            : base (name, age, owner)
        {
            this.danger = danger;
        }
    }
}
