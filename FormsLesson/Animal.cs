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
        private int pep;
        private int satiety;
        private int mood;
        private int intelligence;
        public static int Id = 0;

        public int Pep { get { return pep; } set { pep = value; } }
        public int Satiety { get { return satiety; } set { satiety = value; } }
        public int Mood { get { return mood; } set { mood = value; } }
        public int Intelligence { get { return intelligence; } set { intelligence = value; } }

        public int GetId()
        {
            return Id;
        }

        public int GetUniq()
        {
            return 0;
        }
        Random rnd = new Random();
        public Animal(string name, int age, string owner)
        {
            this.name = name;
            this.age = age;
            this.owner = owner;
            Id++;
        }

        public void NeedsPet()
        {
            pep = rnd.Next(35,65);
            satiety = rnd.Next(30,60);
            mood = rnd.Next(10,60);
            intelligence = rnd.Next(0,50);
        }

        public void NeedsPet(int _pep, int _satiety, int _mood, int _intel)
        {
            pep += _pep;
            satiety += _satiety;
            mood += _mood;
            intelligence += _intel;
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
