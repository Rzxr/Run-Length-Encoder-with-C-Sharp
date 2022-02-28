using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE
{
    class Program
    {
        static void Main(string[] args)
        {
            String enteredString;
            String compressedString = "";
            int count = 1;

            Console.WriteLine("Run Length Encoder");
            Console.WriteLine("Enter a String");
            enteredString = Console.ReadLine();

            Console.WriteLine("You Entered: " + enteredString);
            enteredString = enteredString + " ";

            //Compress Using Run Length Encoding 
            for (int i = 0; i < enteredString.Length - 1; i++)
            {
                if (enteredString[i] == enteredString[i + 1]) //When same increment counter
                {      
                    count++;
                }
                else
                {
                    compressedString += enteredString[i];
                    compressedString += count;
                    count = 1;
                }
            }
            Console.WriteLine("Output" + "\n" + compressedString);

            Console.ReadLine();
        }
    }
}
