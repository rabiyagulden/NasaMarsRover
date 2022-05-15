using System;
namespace MarsRoverProject.Core.States
{
    public class EState:Rover
    {
        public EState(Position Coordinates) : base(Coordinates) { }

        public override void MoveForward()
        {
            Coordinates.X++;
        }
    }
}
