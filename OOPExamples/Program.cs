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
        var comp = new Computer("Dell");
        

        var isComputer = comp is Computer;

        Console.WriteLine("Computer's name is " + comp.name);
        Console.WriteLine("Is computer " + isComputer);
        comp.TogglePower();
        Console.WriteLine("The computer is on - " + comp.isOn);
        
        Console.ReadKey();
    }
}
   

