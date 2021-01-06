using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodeKata.MarsRover
{
    //Red(Fail) > Documentation
    //Green(Pass) Make It
    //Fake Ir. 
    //Refactor(Remove Duplication) Right It

        //C.I
    public class MarsRoverTests
    {
        private readonly Rover rover;
        public MarsRoverTests()
        {
            rover = new Rover();
        }

        //Parameteruzed Tests
        [Theory]
        [InlineData("R", "0:0:E")]
        [InlineData("RR", "0:0:S")]
        [InlineData("RRR", "0:0:W")]
        [InlineData("RRRR", "0:0:N")]
        public void Rover_Should_Rotate_Right(string commands, string expectedResult)
        {
            //Context -Fixture Setup (Precondition)
            //Excersice > Action
            //Assert Verify
            //Teardown

            //Arrange
            //Act
            //Assert

            var result = rover.Execute(commands);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("A")]
        [InlineData("LA")]
        [InlineData("l")]
        [InlineData("r")]
        public void Given_CommandsHasInvalidCharachter_When_ExcecuteCommand_Then_ExceptionThrown(string commands)
        {
            //metaphore
            //($5 + 10 CHF) = $10 if()
            Assert.Throws<InvalidRowerCommandException>(() => rover.Execute(commands));
        }

        [Theory]
        [InlineData("L", "0:0:W")]
        [InlineData("LL", "0:0:S")]
        [InlineData("LLL", "0:0:E")]
        [InlineData("LLLL", "0:0:N")]
        public void Rover_Should_Rotate_Left(string commands, string expectedResult)
        {
            //Program to abstarction
            
            var result = rover.Execute(commands);
            Assert.Equal(expectedResult, result);
        }
    }
}
