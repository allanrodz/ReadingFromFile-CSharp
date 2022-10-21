using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PSAA_CA3_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //VARIABLES
            char[] array = new char[200];
            int totalA = 0, totalE = 0, totalI = 0, totalO = 0, totalU = 0, index = 0;
           
            //READING TEXT FILE
            StreamReader reader = new StreamReader(@"S:\Allan\projects\c#\PSAA CA3 FINAL\PSAA CA3 FINAL\textFilePSAA.txt");

            //COUNTING OCCURRANCES OF VOWELS A,E,I,O,U IN THE FIRST 200 CHARACTERS
            while (reader.Peek() > -1 && index < 200)
            {
                int j = reader.Read();
                array[index] = (char)j;

                if (array[index].ToString().ToLower() == "a")
                    totalA += 1;
                if (array[index].ToString().ToLower() == "e")
                    totalE += 1;
                if (array[index].ToString().ToLower() == "i")
                    totalI += 1;
                if (array[index].ToString().ToLower() == "o")
                    totalO += 1;
                if (array[index].ToString().ToLower() == "u")
                    totalU += 1;

                index++;
            }

            //DISPLAYING OCCURRANCES OF VOWELS
            Console.WriteLine($"Amount of times letter 'a' appeared in the text file: {totalA}, 'e': {totalE}, 'i': {totalI}, 'o': {totalO}, 'u': {totalU}");
            Console.ReadLine();
        }
    }
}
