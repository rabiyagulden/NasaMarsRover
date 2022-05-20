using System;
namespace MarsRoverProject.Core
{
    public abstract class Rover
    {
        public Position Coordinates { get; set; }
        public OrientationsEnum RoverOrientation { get; set; }
        public string RoverDirection;
        public Plateau PlateauArea;

        public Rover(Position coordinates,string direction,Plateau plateau)
        {
            this.RoverDirection = direction;
            this.Coordinates = Coordinates;
            this.PlateauArea = plateau;

            RoverOrientation = Enum.Parse<OrientationsEnum>(RoverDirection);
        }
       // public abstract void MoveForward();
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
