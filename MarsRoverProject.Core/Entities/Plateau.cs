using System;
namespace MarsRoverProject.Core
{
    public class Plateau
    {
        
        private PlateauSize plateauArea { get; set; }

        public Plateau() {

           

        }

        public void SetPlateauSurfaceSize(string toSize)
        {
            var sizeArguments = toSize.Split(' ');
            var width = int.Parse(sizeArguments[0]);
            var height = int.Parse(sizeArguments[1]);
            plateauArea.PlateauWidth = width;
            plateauArea.PlateauHeight = height;

        }



        public void SetSize(PlateauSize plateauSize)
        {
            plateauArea = plateauSize;
        }

        public PlateauSize GetSize()
        {
            return plateauArea;
        }

        public bool IsValid(Position position)
        {
            var isValidX = position.X >= 0 && position.X <= plateauArea.PlateauWidth;
            var isValidY = position.Y >= 0 && position.Y <= plateauArea.PlateauWidth;
            return isValidX && isValidY;
        }
    }
}
