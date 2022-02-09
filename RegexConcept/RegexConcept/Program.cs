using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidateThreeConsequativeCharacter();
            Console.ReadLine();

        }
        public static void ValidateThreeConsequativeCharacter()
        {
            Console.WriteLine("ValidateThreeConsequativeCharacters");
            string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a111b", "bbb23a" };
            string Pattern = "^[0-9]*[a-zA-Z]{3,}[0-9a-zA-Z]*$";
            IterativeOverLoop(inputs, Pattern);



        }
        public static void IterativeOverLoop(string[] inputs, string Pattern)
        {
            foreach (string s in inputs)
            {
                bool res = Regex.IsMatch(s, Pattern);
                if (res)
                {
                    Console.WriteLine("{0} is valid", s);

                }
                else
                    Console.WriteLine("{0} is Invalid", s);
            }

        }
    }
}
