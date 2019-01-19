using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPExamples;


class Program
{
    static void Main(string[] args)
    {
       // var comp = new Desktop("Dell", Desktop.CaseType.Tower);
       var comp = new Laptop("ThinkPad", 1054, 750);
        

        var isComputer = comp is Computer;
        Console.WriteLine("The computer type " + comp.GetType());
        Console.WriteLine("Computer's name is " + comp.name);
        Console.WriteLine("Is computer " + isComputer);
        //Console.WriteLine("Is computer's type is  " + comp.caseType);

        comp.TogglePower();
        Console.WriteLine("The computer is on - " + comp.isOn);

        var sleepingComp = comp as ISleep;

        if(sleepingComp != null)
        {
            sleepingComp.ToggleSleep();
            Console.WriteLine("The computer is sleeping - " + sleepingComp.isSleeping);

            comp.TogglePower();
            Console.WriteLine("The computer is on - " + comp.isOn);
        }
        

        Console.ReadKey();
    }
}
   

