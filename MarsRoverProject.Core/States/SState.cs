using System;
namespace MarsRoverProject.Core.States
{
    public class SState:Rover
    {
        public SState(Position Coordinates) : base(Coordinates) { }

        public override void MoveForward()
        {
            Coordinates.Y--;
        }
    }
}
