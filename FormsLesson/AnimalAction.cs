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
                cat.food = "Milk";
                GetFeed(cat.food);
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                dog.food = "Bone";
                GetFeed(dog.food);
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                raccoon.food = "Bamboo";
                GetFeed(raccoon.food);
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
                cat.command = "Sit";
                cat.star = 3;
                GetTraining(cat.command, cat.star);
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                dog.command = "Paw";
                dog.star = 3;
                GetTraining(dog.command, dog.star);
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon = (Raccoon)animal;
                raccoon.command = "Rinse";
                raccoon.star = 10;
                GetTraining(raccoon.command, raccoon.star);
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
                cat.speed = 10;
                cat.place = "House";
                cat.time = 24;
                GetWalk(cat.speed, cat.place, cat.time);
                return true;
            }
            else if (animal is Dog)
            {
                Dog dog = (Dog)animal;
                dog.speed = 30;
                dog.place = "Street";
                dog.time = 12;
                GetWalk(dog.speed, dog.place, dog.time);
                return true;
            }
            else if (animal is Raccoon)
            {
                Raccoon raccoon= (Raccoon)animal;
                raccoon.speed = 99;
                raccoon.place = "Wood";
                raccoon.time = 5;
                GetWalk(raccoon.speed, raccoon.place, raccoon.time);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
