using System;
namespace MarsRoverProject.Core.States
{
    public class WState:Rover
    {
        public WState(Position Coordinates,string d) : base(Coordinates,d) { }
      

        public override void MoveForward()
        {
            Coordinates.X--;
        }
    }
}
