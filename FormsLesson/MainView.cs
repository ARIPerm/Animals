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

        void OnSuccessWalk(string animal, int speed, string place, int time);

        void OnSuccessTraining(string animal, string command, int star);

        void OnSuccessSleep(string animal, int hours);

        void ErrorMessageNull();

        void ErrorCheckPet();

        void ErrorFormat();

        void ErrorDo();

    }
}
