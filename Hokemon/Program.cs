﻿using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Hokemon!\n\n");

            Hokemon HokeObject01 = new Hokemon(); // INSTANTIATING our first object

            HokeObject01.get_details();

            System.Threading.Thread.Sleep(1000); // Sleep for 1 second

            // Create a second Hokemon
            Hokemon Hoke02 = new Hokemon();
            Hoke02.get_details();

            HokeObject01.about();
            Hoke02.about();

            /*
            Halor halorHoke01 = new Halor();
            halorHoke01.get_details();
            // Example of POLYMORPHISM with the about method in following objects
            Hoke02.about();
            halorHoke01.about();
            */

            Battle_Arena firstArena = new Battle_Arena(); // Instiating the object firstArena
                                                          // from the Battle_Arena CLASS


            firstArena.RequestAChallenger(HokeObject01); // ARGUMENT HokeObject01
                                                         // passed into the 
                                                         // firstArena object
                                                         // method Req....
            firstArena.AcceptingTheBattle(HokeObject01, Hoke02);

            firstArena.Battle(HokeObject01, Hoke02); // Starts the Battle

        }
    }
}