using System;

namespace Hokemon
{
    class About
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello welcome to Hokeworld  home of Hokemon!"); //Instantiation of new Hokemon

            Hokemon hoke01 = new Hokemon();
            Hokemon hoke02 = new Hokemon();

            hoke01.get_details();

            hoke01.about(); //Invoking the about method for hoke01
            
            
            hoke02.about();

            Halor halorHoke01 = new Halor(); //Inherited
            halorHoke01.get_details();
            halorHoke01.about();



        }
    }
}



