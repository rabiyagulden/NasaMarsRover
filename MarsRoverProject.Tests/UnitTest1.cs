using System;
using Xunit;
using MarsRoverProject.Core;

namespace MarsRoverProject.Tests
{
    public class UnitTest1
    {
        public string TestInputString;
        int x; int y;
        [Fact]
        public void TurnLeft()
        {

            TestInputString = "1 2 N";

            Int32.TryParse(TestInputString.Split(" ")[0], out x);
            Int32.TryParse(TestInputString.Split(" ")[1], out y);
           string directionTest = TestInputString.Split(" ")[2];
            Position coordinates = new Position(x, y);

            ExpRover rover = new ExpRover(coordinates,directionTest);

            rover.TurnLeft();     

            Assert.Equal("W",rover.RoverDirection);
        }

        [Fact]
        public void TurnRight()
        {
            TestInputString = "1 2 N";
            Int32.TryParse(TestInputString.Split(" ")[0], out x);
            Int32.TryParse(TestInputString.Split(" ")[1], out y);
            string directionTest = TestInputString.Split(" ")[2];
            Position coordinates = new Position(x, y);

            ExpRover rover = new ExpRover(coordinates, directionTest);
           // ExpRover rover = new ExpRover("1 2 N");

            rover.TurnRight();

            Assert.Equal("E", rover.RoverDirection);
        }

        [Fact]
        public void Execute_1_2_N()
        {
            TestInputString = "1 2 N";
            Int32.TryParse(TestInputString.Split(" ")[0], out x);
            Int32.TryParse(TestInputString.Split(" ")[1], out y);
            string directionTest = TestInputString.Split(" ")[2];
            Position coordinates = new Position(x, y);

            ExpRover rover = new ExpRover(coordinates, directionTest);

            rover.Execute("LMLMLMLMM");
            
            Assert.Equal("1 3 N", rover.Coords.X + " " + rover.Coords.Y + " " + rover.RoverDirection);
        }

        [Fact]
        public void Execute_3_3_E()
        {
            TestInputString = "3 3 E";
            Int32.TryParse(TestInputString.Split(" ")[0], out x);
            Int32.TryParse(TestInputString.Split(" ")[1], out y);
            string directionTest = TestInputString.Split(" ")[2];
            Position coordinates = new Position(x, y);

            ExpRover rover = new ExpRover(coordinates, directionTest);

            rover.Execute("MMRMMRMRRM");

            Assert.Equal("5 1 E", rover.Coords.X + " " + rover.Coords.Y + " " + rover.RoverDirection);
        }
    }
}
