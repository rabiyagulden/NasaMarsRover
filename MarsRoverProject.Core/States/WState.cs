using System;
namespace MarsRoverProject.Core.States
{
    public class WState:Rover
    {
        public WState(Position Coordinates) : base(Coordinates) { }
      

        public override void MoveForward()
        {
            Coordinates.X--;
        }
    }
}
