using System;
namespace MarsRoverProject.Core.States
{
    public class SState:Rover
    {
        public SState(Position Coordinates,string d) : base(Coordinates,d) { }

        public override void MoveForward()
        {
            Coordinates.Y--;
        }
    }
}
