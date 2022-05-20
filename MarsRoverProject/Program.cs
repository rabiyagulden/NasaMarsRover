using System;
using MarsRoverProject.Core;

namespace MarsRoverProject
{
    class Program
    {
       
        static void Main(string[] args)
        {
           

        /// Plateau Size Setup
        Console.WriteLine("Type a rover line size, and then press Enter");
            string PlataeuSize = Console.ReadLine();
            
            Plateau p = new Plateau();
        
            /// Rover 1 Input Setup

            Console.WriteLine("Type a rover input line 1, and then press Enter");
            string rover1Line1 = Console.ReadLine();

            Console.WriteLine("Type a rover input line 2, and then press Enter");
            string rover1Line2 = Console.ReadLine();

            /// Rover 2 Input Setup

            // Console.WriteLine("Type a rover input line 1, and then press Enter");
            //string rover2Line1 = Console.ReadLine();

            // Console.WriteLine("Type a rover input line 2, and then press Enter");
            // string rover2Line2 = Console.ReadLine();

            string location = rover1Line1;
            int x;
            int y;
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            string direction=location.Split(" ")[2];
            Position coordinates = new Position(x, y);
           

            ExpRover kasifArac1 = new ExpRover(coordinates,direction,p);

            kasifArac1.SetPlateauSurfaceSize(PlataeuSize);

            kasifArac1.Deploy(p, coordinates);


            kasifArac1.Execute(rover1Line2);
            string outString = kasifArac1.Coords.X + " " + kasifArac1.Coords.Y+ " " + kasifArac1.RoverDirection;
            Output(rover1Line1, outString);




        }

        private static void Output(string commandString, string OutputStrings)
        {
            Console.WriteLine("Input:");
            Console.WriteLine(commandString);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Output:");
            Console.WriteLine(OutputStrings);
            Console.Write(Environment.NewLine);
            Console.Write("Press <enter> to exit...");
            Console.ReadLine();
            Console.WriteLine();

        }
    }
}
