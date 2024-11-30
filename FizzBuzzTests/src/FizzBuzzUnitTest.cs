using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzTddExample.src;

namespace FizzBuzzTests.src
{
    public class FizzBuzzUnitTest
    {
        [Fact]
        public void FizzBuzzGetWordPassingNumberMultipleByThreeShouldReturnFizz()
        {
            var input = 3;

            var fizzBuzz = new FizzBuzz();
            var output = fizzBuzz.GetWord(input);

            Assert.Equal("Fizz", output);
        }

        [Fact]
        public void FizzBuzzGetWordPassingNumberMultipleByFiveShouldReturnBuzz()
        {

            var input = 5;

            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.GetWord(input);

            Assert.Equal("Buzz", output);
        }

        [Fact]
        public void FizzBuzzGetWordPassingNumberMultipleByThreeAndFiveShouldReturnFizzBuzz()
        {
            var input = 15;

            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.GetWord(input);

            Assert.Equal("FizzBuzz", output);
        }

        [Fact]
        public void FizzBuzzGetWordPassingNumberNotMultipleByThreeOrFiveShouldReturnInputNumberAsString()
        {
            var input = 16;

            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.GetWord(input);

            Assert.Equal("16", output);
        }

        [Fact]
        public void FizzBuzzGetWordPassingNumberZeroShouldReturnInputNumberAsString()
        {
            var input = 0;

            var fizzBuzz = new FizzBuzz();

            var output = fizzBuzz.GetWord(input);

            Assert.Equal("0", output);
        }


        [Fact]
        public void FizzBuzzGetWordsShouldReturnSameSizeArrayOfInput()
        {

            var input = 3;
            string[] expectedOutput = { "1", "2", "Fizz" };


            var fizzBuzz = new FizzBuzz();

            var outputA = fizzBuzz.GetWords(input);

            Assert.Equal(expectedOutput.Length, outputA.Count);

        }


        [Theory]
        [InlineData(3)]
        public void FizzBuzzGetWordsShouldReturnArrayOfCorrectStringsBasedOnFizzBuzzMultipleByThreeRules(int input)
        {

            string[] expectedOutput = { "1", "2", "Fizz" };


            var fizzBuzz = new FizzBuzz();

            var outputA = fizzBuzz.GetWords(input);


            Assert.Equal(expectedOutput.Length, outputA.Count);

            for (var i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], outputA[i]);
            }

        }

        [Theory]
        [InlineData(5)]
        public void FizzBuzzGetWordsShouldReturnArrayOfCorrectStringsBasedOnFizzBuzzMultipleByFiveRulesExampleInputOne(int input)
        {

            string[] expectedOutput = { "1", "2", "Fizz", "4", "Buzz" };


            var fizzBuzz = new FizzBuzz();

            var outputA = fizzBuzz.GetWords(input);


            Assert.Equal(expectedOutput.Length, outputA.Count);

            for (var i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], outputA[i]);
            }

        }
        [Theory]
        [InlineData(15)]
        public void FizzBuzzGetWordsShouldReturnArrayOfCorrectStringsBasedOnFizzBuzzMultipleByFiveRulesExampleInputTwo(int input)
        {

            string[] expectedOutput = ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"];


            var fizzBuzz = new FizzBuzz();

            var outputA = fizzBuzz.GetWords(input);


            Assert.Equal(expectedOutput.Length, outputA.Count);

            for (var i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], outputA[i]);
            }

        }


    }
}