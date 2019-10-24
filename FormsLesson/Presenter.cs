using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    class Presenter
    {
        MainView view;
        IAnimal animalAction;

        public void AttachView(MainView view)
        {
            this.view = view;
        }
        
        public Presenter(IAnimal animalAction)
        {
            this.animalAction = animalAction;
        }

        public void Feed(Animal animal, string food)
        {
            if(animalAction.Feed(animal, food))
            {
            }
            else
            {
                view.ErrorDo();
            }
        }

        public void Walk(Animal animal, int speed, string place, int time)
        {
            animalAction.Walk(animal, speed, place, time);
        }

        public void Training(Animal animal, string command, int star)
        {
            animalAction.Training(animal, command, star);
        }

        public void Sleep(Animal animal, int hours)
        {
            animalAction.Sleep(animal, hours);
        }
    }
}
