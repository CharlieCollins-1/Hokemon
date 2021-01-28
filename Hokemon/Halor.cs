using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : Hokemon
    {
        private string team = "Halor";

        public void about()
        {
            Console.WriteLine("I am {0} part of the {1} team!!\n\n", Name, team);
        }
    }
}

