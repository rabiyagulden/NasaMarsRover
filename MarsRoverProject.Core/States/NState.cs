using System;
namespace MarsRoverProject.Core.States
{
    public class NState:Rover
    {
        public NState(Position Coordinates,string d): base(Coordinates,d) { }
       

        public override void MoveForward()
        {
            Coordinates.Y++;
        }

        
    }
}
