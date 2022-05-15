using System;
namespace MarsRoverProject.Core
{
    public class ExpRover
    {
        public int x;
        public int y;
        public string direction;
        public Position position;

       // private Rover roverState;
      //  DirectionFactory factory = new DirectionFactory();

        public OrientationsEnum RoverOrientation { get; set; }

 


        public ExpRover(string location)
        {
        
            Int32.TryParse(location.Split(" ")[0],out x);
            Int32.TryParse(location.Split(" ")[1], out y);

            position.X = x;
            position.Y = y;

            direction = location.Split(" ")[2];

            RoverOrientation = Enum.Parse<OrientationsEnum>(direction);

           

            //roverState.direction = direction;
            //roverState.RoverOrientation = RoverOrientation;
            

          
        }

        public void TurnLeft() {



            RoverOrientation = (RoverOrientation - 1) < OrientationsEnum.N ? OrientationsEnum.W : RoverOrientation - 1;
            direction = ((OrientationsEnum)RoverOrientation).ToString();

        }
        public void TurnRight()
        {
            RoverOrientation = (RoverOrientation + 1) > OrientationsEnum.W ? OrientationsEnum.N : RoverOrientation + 1;
            direction = ((OrientationsEnum)RoverOrientation).ToString();
        }

        public void MoveF()
        {

         //   factory.Create(direction);
        }

        public void Move()
        {
            if (direction == "N")
            {             
                position.Y++;
            }
            if (direction == "S")
            {
                position.Y--;
            }
            if (direction == "W")
            {
                position.X--;
            }
            if (direction == "E")
            {
                position.X++;
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


     

    }
}
