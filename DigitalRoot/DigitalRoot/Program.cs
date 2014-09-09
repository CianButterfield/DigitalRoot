using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("31337");
            DigitalRoot("45734");

            Console.ReadKey();
        }

        //Function for digital root
        static void DigitalRoot(string input)
        {
            //save the original input
            string inputOriginal = input;
            //declare the ouput variable
            int output = 0;
            //loop until the output is one character long
            while (input.Length > 1)
            {
                //set the output to 0 at the begining of each loop
                output = 0;
                //add the digets
                for (int i = 0; i < input.Length; i++)
                {
                    output += int.Parse(input[i].ToString());
                }
                //convert the output to string and put it in to input for the next time through the loop
                input = output.ToString();
            }
            //print the output
            Console.WriteLine("Input: " + inputOriginal);
            Console.WriteLine("Output: " + input);
        }
    }
}
