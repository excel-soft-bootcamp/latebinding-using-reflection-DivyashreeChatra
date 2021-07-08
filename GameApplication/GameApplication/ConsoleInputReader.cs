using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApplication
{
    class ConsoleInputReader
    {
        public Options InputReader()
            {

            string message = $"Enter Your Choice {(int)Options.BASIC}->Basic,{(int)Options.INTERMEDIATE}->Intermediate,{(int)Options.ADVANCED}->Advanced";
            Console.WriteLine(message);

            Options _choice = (Options)Int32.Parse(Console.ReadLine());
            return _choice;
        }
    }
}
