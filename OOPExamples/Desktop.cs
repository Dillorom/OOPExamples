using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    internal class Desktop : Computer, ISleep
    {
        private ISleep sleepControl;

        public enum CaseType
        {
            Tower,
            MiniTower,
        }
        public override string name { get
            {
                return base.name + " " + caseType;
            }
        }
        public bool isSleeping
        {
            get
            {
                return sleepControl.isSleeping;
            }
        }

        public CaseType caseType { get; private set; }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
            sleepControl = new sleepControl();
        }
       
        public void ToggleSleep()
        {
            if(!isSleeping)
            {
                return;
            }
            sleepControl.ToggleSleep();
        }

        public override void TogglePower()
        {
            if(isSleeping)
            {
                return;
            }

            base.TogglePower();
        }
    }
}
