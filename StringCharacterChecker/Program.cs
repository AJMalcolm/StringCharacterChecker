using System;

namespace StringCharacterChecker
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class StringChecker
    {
        public char[] GetRepeatedCharacters(string input)
        {
            char[] referenceArray = new char[input.Length];
            char[] inputAsArray = input.ToCharArray();
            List<char> result = new List<char>();

            for (int i = 0; i < inputAsArray.Length; i++)
            {
                if (referenceArray.Contains(inputAsArray[i]))
                {
                    if (!inputAsArray[i].Equals(' '))
                    {
                        if (!result.Contains(inputAsArray[i]))
                        {
                            result.Add(inputAsArray[i]);
                        }
                    }
                }
                referenceArray[i] = inputAsArray[i];
            }

            return result.ToArray();
        }
    }
}