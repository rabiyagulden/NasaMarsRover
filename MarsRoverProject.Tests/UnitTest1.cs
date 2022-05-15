using System;
using Xunit;
using MarsRoverProject.Core;

namespace MarsRoverProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TurnLeft()
        {
         
            ExpRover rover = new ExpRover("1 2 N");

            rover.TurnLeft();     

            Assert.Equal("W",rover.direction);
        }

        [Fact]
        public void TurnRight()
        {
            ExpRover rover = new ExpRover("1 2 N");

            rover.TurnRight();

            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void Execute()
        {
            ExpRover rover = new ExpRover("3 3 E");

            rover.Execute("MMRMMRMRRM");

            Assert.Equal("5 1 E", rover.position.X + " " + rover.position.Y + " " + rover.direction);
        }
    }
}
