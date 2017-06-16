using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoolStringChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //int charMin = char.MinValue;
            //int charMax = char.MaxValue;

            //char myVar = 'G';
            //int myVarValue = 'G';

            //char myVarValue2 = Convert.ToChar(71);

            //Console.WriteLine("The Min Value is: {0} The Max Value Is: {1} My Char is: {2} My Variable Number Is {3}" , charMin, charMax, myVar, myVarValue2);

            //Console.ReadLine();


            char myChar = 'A';
            int myCharValue = Convert.ToInt32(myChar);
            Console.WriteLine("My Char Is: {0}, And My Char Value Is: {1}", myChar, myCharValue);

            char smallChar = 'a';
            int mySmallCharValue = Convert.ToInt32(smallChar);
            
            Console.WriteLine("My Small Char is: {0} And My Small Char Value Is: {1}", smallChar, mySmallCharValue);

            Console.ReadLine();
        }
    }
}
