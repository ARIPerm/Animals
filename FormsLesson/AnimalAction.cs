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
                        cat.NeedsPet(-1, 4, 1, 2);
                        break;
                    case "Bread":
                        cat.NeedsPet(-2, 2, 0, 1);
                        break;
                    case "Bamboo":
                        cat.NeedsPet(-5, -3,-2, -1);
                        break;
                }
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                switch (food)
                {
                    case "Milk":
                        dog.NeedsPet(-1, 4, 1, 2);
                        break;
                    case "Bread":
                        dog.NeedsPet(-2, 2, 0, 1);
                        break;
                    case "Bamboo":
                        dog.NeedsPet(-5, -3, -2, -1);
                        break;
                }
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                switch (food)
                {
                    case "Milk":
                        raccoon.NeedsPet(-1, 4, 1, 2);
                        break;
                    case "Bread":
                        raccoon.NeedsPet(-2, 2, 0, 1);
                        break;
                    case "Bamboo":
                        raccoon.NeedsPet(-5, -3, -2, -1);
                        break;
                }
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
                switch (command)
                {
                    case "Run":
                        cat.NeedsPet(-1, -2, 3, 2*star);
                        break;
                    case "Jump":
                        cat.NeedsPet(-3, -4, 2, 1*star);
                        break;
                    case "Swim":
                        cat.NeedsPet(-5, -3, 5, 4*star);
                        break;
                }
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                switch (command)
                {
                    case "Run":
                        dog.NeedsPet(-1, -2, 3, 2 * star);
                        break;
                    case "Jump":
                        dog.NeedsPet(-3, -4, 2, 1 * star);
                        break;
                    case "Swim":
                        dog.NeedsPet(-5, -3, 5, 4 * star);
                        break;
                }
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                switch (command)
                {
                    case "Run":
                        raccoon.NeedsPet(-1, -2, 3, 2 * star);
                        break;
                    case "Jump":
                        raccoon.NeedsPet(-3, -4, 2, 1 * star);
                        break;
                    case "Swim":
                        raccoon.NeedsPet(-5, -3, 5, 4 * star);
                        break;
                }
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
                switch (place)
                {
                    case "Home":
                        cat.NeedsPet(-1, -2, 3, 2);
                        break;
                    case "Park":
                        cat.NeedsPet(-3, -4, 2, 1);
                        break;
                    case "Forest":
                        cat.NeedsPet(-5, -3, 5, 4);
                        break;
                }
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                switch (place)
                {
                    case "Home":
                        dog.NeedsPet(-1, -2, 3, 2);
                        break;
                    case "Park":
                        dog.NeedsPet(-3, -4, 2, 1);
                        break;
                    case "Forest":
                        dog.NeedsPet(-5, -3, 5, 4);
                        break;
                }
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon= (Raccoon)animal;
                switch (place)
                {
                    case "Home":
                        raccoon.NeedsPet(-1, -2, 3, 2);
                        break;
                    case "Park":
                        raccoon.NeedsPet(-3, -4, 2, 1);
                        break;
                    case "Forest":
                        raccoon.NeedsPet(-5, -3, 5, 4);
                        break;
                }
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
                cat.NeedsPet(2*hours, -2*hours, -1*hours, 0);
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                dog.NeedsPet(2 * hours, -2 * hours, -1 * hours, 0);
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                raccoon.NeedsPet(2 * hours, -2 * hours, -1 * hours, 0);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
