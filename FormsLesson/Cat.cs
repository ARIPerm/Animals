using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    class Cat : Animal
    {
        private int harmfulness;

        public Cat(string name, int age, string owner, int harmfulness)
            : base(name, age, owner)
        {
            this.harmfulness = harmfulness;
        }

        public new int GetUniq()
        {
            return harmfulness;
        }
    }
}
