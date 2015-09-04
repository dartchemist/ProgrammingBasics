using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAreaInArray
{
    public static class LongestSequenceInArray
    {
        static void Main(string[] args)
        {
            var inputStringSequence = ReadInputSequence(Console.In);
            var longestSequenceOfEqualElements = FindLongestSequnceOfEqualElements(inputStringSequence);
            PrintOutput(longestSequenceOfEqualElements, Console.Out);
        }

        private static string[] ReadInputSequence(TextReader inputReader)
        {
            var numberOfElements = int.Parse(inputReader.ReadLine());
            var stringSequence = new string[numberOfElements];
            InitStringSequence(stringSequence, inputReader);
            return stringSequence;
        }
        private static void InitStringSequence(string[] stringSequence, TextReader inputReader)
        {
            for (var i = 0; i < stringSequence.Length; ++i)
            {
                stringSequence[i] = inputReader.ReadLine();
            }
        }

        private static string[] FindLongestSequnceOfEqualElements(string[] inputSequence)
        {
            var longestSequenceLength = 1;
            var longestSequenceStartIndex = 0;
            var currentLongestSequenceLength = longestSequenceLength;
            var currentLongestSequenceStartIndex = longestSequenceStartIndex;
            var hasIndexChanged = false;

            for (var i = 0; i < inputSequence.Length - 1; ++i)
            {
                if (inputSequence[i] == inputSequence[i + 1])
                {
                    if (!hasIndexChanged)
                    {
                        currentLongestSequenceStartIndex = i;
                    }
                    ++currentLongestSequenceLength;
                }
                else if (longestSequenceLength < currentLongestSequenceLength)
                {
                    longestSequenceLength = currentLongestSequenceLength;
                    longestSequenceStartIndex = currentLongestSequenceStartIndex;   
                }
                currentLongestSequenceLength = 1;
                currentLongestSequenceStartIndex = i;
                hasIndexChanged = false;
            }
            return null;
        }

        private static void PrintOutput(string[] longestSequenceOfEqualElements, TextWriter outputWriter)
        {
            outputWriter.WriteLine(longestSequenceOfEqualElements.Length);
            for (var i = 0; i < longestSequenceOfEqualElements.Length; ++i)
            {
                outputWriter.WriteLine(longestSequenceOfEqualElements[i]);
            }
        }
    }
}
