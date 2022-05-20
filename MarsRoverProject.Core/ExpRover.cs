using System;
namespace MarsRoverProject.Core
{
    public class ExpRover :Rover
    {
       
        public Position Coords;
        public string direction;
        public PlateauSize pSize;
        public Plateau plateau;

      
     
       // public OrientationsEnum RoverOrientation { get; set; }


        public ExpRover(Position Coords,string direction,Plateau plateau): base(Coords,direction,plateau) {

            this.Coords = Coords;
            this.direction = direction;
            this.plateau = plateau;
            this.pSize = plateau.GetSize();
       
       
             
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
                if (plateau.IsValid(Coords))
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
  

        public void SetPlateauSurfaceSize(string toSize)
        {
            var sizeArguments = toSize.Split(' ');
            var width = int.Parse(sizeArguments[0]);
            var height = int.Parse(sizeArguments[1]);

            pSize = new PlateauSize(width, height);
            plateau.SetSize(pSize);   
         
        }

  

        public void Deploy(Plateau p, Position aPoint)
        {
            if (p.IsValid(aPoint))
            {
                Coords = aPoint;
                return;
            }

            throwDeployException(p, aPoint);
        }

        private static void throwDeployException(Plateau plateau, Position point)
        {
            var size = plateau.GetSize();
            var exceptionMessage = String.Format("Deploy failed for point ({0},{1}). Landing surface size is {2} x {3}.",
                point.X, point.Y, size.PlateauWidth, size.PlateauHeight);
            throw new Exception(exceptionMessage);
        }
    }
}
