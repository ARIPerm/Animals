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

        public Dog(string name, int age, string owner, int danger)
            : base (name, age, owner)
        {
            this.danger = danger;
        }

        public new int GetUniq()
        {
            return danger;
        }
    }
}
