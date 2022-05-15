using System;
namespace MarsRoverProject.Core.States
{
    public class NState:Rover
    {
        public NState(Position Coordinates): base(Coordinates) { }
       

        public override void MoveForward()
        {
            Coordinates.Y++;
        }

        
    }
}
