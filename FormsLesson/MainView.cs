using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLesson
{
    interface MainView
    {
        void OnSuccessFeed(Animal animal, string food);

        void OnSuccessWalk(Animal animal, int speed, string place, int time);

        void OnSuccessTraining(Animal animal, string command, int star);

        void OnSuccessSleep(Animal animal, int hours);

        void ErrorMessageNull();

        void ErrorCheckPet();

        void ErrorFormat();

        void ErrorDo();

    }
}
