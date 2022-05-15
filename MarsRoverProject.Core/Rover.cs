using System;
namespace MarsRoverProject.Core
{
    public abstract class Rover
    {
        public Position Coordinates { get; set; }
        public OrientationsEnum RoverOrientation { get; set; }
        public string direction;

        public Rover(Position Coordinates)

        {
            this.Coordinates = Coordinates;
        }
        public abstract void MoveForward();
        public void TurnRight()
        {
            RoverOrientation = (RoverOrientation + 1) > OrientationsEnum.W ? OrientationsEnum.N : RoverOrientation + 1;
            direction = ((OrientationsEnum)RoverOrientation).ToString();
        }
        public void TurnLeft()
        {

            RoverOrientation = (RoverOrientation - 1) < OrientationsEnum.N ? OrientationsEnum.W : RoverOrientation - 1;
            direction = ((OrientationsEnum)RoverOrientation).ToString();

        }

    }
}
