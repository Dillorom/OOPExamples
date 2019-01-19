using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Computer
    {
        protected string _name;
        public string name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        public bool isOn { get; private set; }

        public Computer(string name)
        {
            this.name = name;
        }

        protected void TurnOn()
        {
            isOn = true;
        }

        protected void TurnOff()
        {
            isOn = false;
        }

        public void TogglePower()
        {
            if(isOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}
