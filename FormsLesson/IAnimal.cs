using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    interface IAnimal
    {
        bool Feed(Animal animal,string food);
        bool Walk(Animal animal,int speed, string place, int time);
        bool Training(Animal animal, string command, int star);
        bool Sleep(Animal animal, int hours);
    }
}
