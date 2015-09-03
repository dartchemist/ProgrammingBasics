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

            for (var i = 0; i < inputSequence.Length; ++i)
            {
                
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
