using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Kata2
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new Source();
            Console.WriteLine("sorted file :\n" + file);
            Console.WriteLine(@"Your destination file will be written here: C:\Destination\Output.txt");
            Console.WriteLine("output file: \n" + file.OutputFile());
            Console.ReadKey();
        }
    }
}
/*

Using Name, Phone, and EyeColor as unique fields:
-	Produce an output grouped on the unique fields
-	Uniquely umber each different position for a user from 1 to N
-	Only print Name, Phone, EyeColo fo the first record for a user

Remember to write it assuming it will be used on a regular basis to produce the shown 
 * output as a file.  The output file can be delimited, doesn’t need to be spaced as 
 * shown.   In 2 weeks when we discuss our implementations we will evaluate how 
 * flexible the designs are because I will introduce some new elements to the problem 
 * that make it a tad more involved.  

Input

 Name       Phone       EyeColor        PositionID      Title
 Franklin   1212        Blue            123             General Manager
 Franklin   1212        Blue            67              Salesman
 Pierce     1313        Blue            234             Digger
 Pierce     1313        Blue            456             Porter
 Hoolihan   1414        Green           123             General Manager
 Bob        1515        Blue            86              Maid
 Bob        1515        Blue            90              Electrician
 
Output
  
 Name       Phone       EyeColor        PositionID      Title               PositionCount
 Franklin   1212        Blue            123             General Manager     1
                                        67              Salesman            2
 Pierce     1313        Blue            234             Digger              1
                                        456             Porter              2
 Hoolihan   1414        Green           123             General Manager     1
 Bob        1515        Blue            86              Maid                1
                                        90              Electrician         2

*/ 
