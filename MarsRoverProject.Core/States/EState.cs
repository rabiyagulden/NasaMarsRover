using System;
namespace MarsRoverProject.Core.States
{
    public class EState:Rover
    {
        public EState(Position Coordinates,string d) : base(Coordinates,d) { }

        public override void MoveForward()
        {
            Coordinates.X++;
        }
    }
}
