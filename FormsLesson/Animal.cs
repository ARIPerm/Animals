using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    class Animal
    {
        private string name;
        private int age;
        private string owner;

        public Animal(string name, int age, string owner)
        {
            this.name = name;
            this.age = age;
            this.owner = owner;
        }
        public string Name
        {
            get
            {
                return name;
            } 

            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }
    }
}
