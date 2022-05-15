using System;
using MarsRoverProject.Core.States;

namespace MarsRoverProject.Core
{
    public class DirectionFactory
    {
        public string direction;
        public Position position;

        public Rover Create(string d)
        {
            Rover rover = null;
            switch (d)
            {
                case "W":
                    rover = new WState(position);
                    break;
                case "S":
                    rover = new SState(position);
                    break;
                case "N":
                    rover = new NState(position);
                    break;
                case "E":
                    rover = new EState(position);
                    break;

            }
            return rover;

        }
    }
}
