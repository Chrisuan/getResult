using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getResult {
    class Program {
        static void Main(string[] args) {
            string[] CommandLineArgs = Environment.GetCommandLineArgs();

            if(CommandLineArgs.Length < 2) {
                Console.WriteLine("Bitte Parameter angeben");
            }

            else if(CommandLineArgs.Length > 1) {
                switch (CommandLineArgs[1].ToLower()) {
                    case "yes": Console.WriteLine("Ja gedrückt");
                        break;
                    case "no": Console.WriteLine("Nein gedrückt");
                        break;
                    default: Console.WriteLine("Ungültiger Parameter");
                        break;
                }                
            }
            Console.ReadLine();
        }
    }
}
