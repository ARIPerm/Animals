using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    class AnimalAction : IAnimal
    {
        public bool Feed(Animal animal, string food)
        {
            if (animal is Cat)
            {
                Cat cat = (Cat)animal;
                switch(food)
                {
                    case "Milk":
                        cat.Satiety += 10;
                        cat.Pep -= 7;
                        cat.Mood += 2;
                        cat.Intelligence += 1;
                        break;
                    case "Bread":
                        cat.Satiety += 3;
                        cat.Pep -= 17;
                        cat.Mood -= 4;
                        cat.Intelligence += 1;
                        break;
                    case "Bamboo":
                        cat.Satiety -= 4;
                        cat.Pep -= 20;
                        cat.Mood -= 14;
                        cat.Intelligence += 1;
                        break;
                }
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Training(Animal animal, string command, int star)
        {
            if (animal is Cat)
            {
                Cat cat = (Cat)animal;
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Walk(Animal animal, int speed, string place, int time)
        {
            if (animal is Cat)
            {
                Cat cat = (Cat)animal;
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon= (Raccoon)animal;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Sleep(Animal animal, int hours)
        {
            if (animal is Cat)
            {
                Cat cat = (Cat)animal;
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
