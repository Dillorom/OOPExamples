using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Laptop : Computer, ISleep
    {

        public Display display { get; private set; }

        private ISleep sleepControl;

        public bool isSleeping
        {
            get
            {
                return sleepControl.isSleeping;
            }
        }

        public Laptop(string name, int width, int height) : base(name)
        {
            display = new Display(width, height);
            sleepControl = new sleepControl();
        }

        public void ToggleSleep()
        {
            sleepControl.ToggleSleep();
        }
    }
}
