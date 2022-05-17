using System;
namespace MarsRoverProject.Core
{
    public abstract class Rover
    {
        public Position Coordinates { get; set; }
        public OrientationsEnum RoverOrientation { get; set; }
        public string RoverDirection;

        public Rover(Position Coordinates,string direction)
        {
            this.RoverDirection = direction;
            this.Coordinates = Coordinates;

            RoverOrientation = Enum.Parse<OrientationsEnum>(RoverDirection);
        }
        public abstract void MoveForward();
        public void TurnRight()
        {
            RoverOrientation = (RoverOrientation + 1) > OrientationsEnum.W ? OrientationsEnum.N : RoverOrientation + 1;
            RoverDirection = ((OrientationsEnum)RoverOrientation).ToString();
        }
        public void TurnLeft()
        {

            RoverOrientation = (RoverOrientation - 1) < OrientationsEnum.N ? OrientationsEnum.W : RoverOrientation - 1;
            RoverDirection = ((OrientationsEnum)RoverOrientation).ToString();

        }

    }
}
