using System;
namespace MarsRoverProject.Core
{
    public class ExpRover :Rover
    {
       
        public Position Coords;
        public string direction;

        private Rover roverState;
        DirectionFactory factory = new DirectionFactory();
       // public OrientationsEnum RoverOrientation { get; set; }


        public ExpRover(Position Coords,string direction): base(Coords,direction) {

            this.Coords = Coords;
            this.direction = direction;
        }
     
        public void GetCoorddinates(string location)
        {
                 
            // roverState.direction = direction;
            // roverState.RoverOrientation = RoverOrientation;
        }

        public void Move()
        {
            if (RoverDirection == "N")
            {
                Coords.Y++;
            }
            if (RoverDirection == "S")
            {
                Coords.Y--;
            }
            if (RoverDirection == "W")
            {
                Coords.X--;
            }
            if (RoverDirection == "E")
            {
                Coords.X++;
            }

        }

        public void Execute(string command)
        {
            char[] inputs = command.ToCharArray();


            foreach (int element in inputs)
            {
                switch (element)
                {
                    case 'L':
                        TurnLeft();              
                        break;
                    case 'R':
                       TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                    default: throw new Exception();

                }
            }

          
        }

        public override void MoveForward()
        {
           
            factory.Create(RoverDirection);
        }
    }
}
