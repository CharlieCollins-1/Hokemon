using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hokemon
    {
        //Members - all attributes, methods and properties are members of this class

        //Variables - attributes
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;
        
        //Properties
        //Properties are a combination of a field and method

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        
        //Methods
        public Hokemon() //Constructor
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
        }
    
        public void get_details()
        {
            Console.WriteLine("\n\n************\nName: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefense: {5} ", name, Health, max_health, attack, speed, defense);
        }

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }

        public int random_int_generator(int min_value, int max_value) //Parameters
        {
            Random rnd = new Random(); //Instantiating

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

        public void about() //provides information
        {
            Console.WriteLine("I am a mystical species known as a Hokemon");
        }
    
    
    }
}
