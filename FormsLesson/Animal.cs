using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    public class Animal
    {
        private string name;
        private int age;
        private string owner;
        private int pep = 50;
        private int satiety = 50;
        private int mood = 50;
        private int intelligence = 50;
        public static int Id = 0;

        public int Pep { get { return pep; } set { pep = value; } }
        public int Satiety { get { return satiety; } set { satiety = value; } }
        public int Mood { get { return mood; } set { mood = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        public Animal(string name, int age, string owner)
        {
            this.name = name;
            this.age = age;
            this.owner = owner;
            Id++;
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
