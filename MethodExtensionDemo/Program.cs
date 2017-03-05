using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "sumit";
            string outputString = stringHelper.changeFirstLetterCase(str);
            Console.WriteLine(outputString);
            
            //but we want to call changeFirstLetterCase() method with string class i.e
            // string outputstring = str.changeFirstLetterCase();
            // To achive this we need to do two things:
            // a) make the stringHelper class static
            // b) change the signature of method from changeFirstLetterCase(string str) TO changeFirstLetterCase(this string str)
            outputString = str.changeFirstLetterCase();
        
            Console.WriteLine(outputString);


            //Enumerable is wrapper class for Collection

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };

            //IEnumerable<int> output = numbers.Where(n => n % 2 == 0);

            //this could also be written as follow:- (Because Enumerable is the wrapper class for collection )

            //Syntax - WrapperClassName.MethodName(SourceName,Condition/parameters)

            IEnumerable<int> output = Enumerable.Where(numbers, n => n % 2 == 0);

            foreach (int n in output)
            {
                Console.WriteLine(n);
            }
        }
    }
}
