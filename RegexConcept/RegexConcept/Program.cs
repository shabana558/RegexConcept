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
            Console.WriteLine();
            ValidatePinCode();
            Console.ReadLine();

        }
        public static void ValidatePinCode()
        {
            Console.WriteLine("ValidatePinCode");
            string[] inputs = { "400088", "9342 387", "A834  784", "632  787B", "A83 4784", "A400088", "400088B", "400 088" };
            string Pattern = "^[0-9]{3}[  ][0-9]{3}$";
            IterativeOverLoop(inputs, Pattern);
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
