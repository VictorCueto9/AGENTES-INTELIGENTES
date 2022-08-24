using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_Process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x, x_copy;
            string[] positive, negative;
            char[]  simbols = new char[] {' ', '+', '-'}; //simbols before x in all cases
            
            x = Console.ReadLine();
            x = x.ToLower();
            //x = x.Replace(' ', ''); trying remove blanck spaces

            if (x[0] == 'x')
            {
                x = x.Insert(0, "1"); // if first character is x, add a 1 before x
            }

            for (int i = 1; i < x.Length; i++)
            {
                for(int sim = 0; sim < 3;sim++)
                {
                    if (x[i] == 'x' && x[i - 1] == simbols[sim])
                    {
                        x = x.Insert(i, "1"); //add a 1 before x due to x
                        i += 1;
                    }
                }
            }

            Console.WriteLine(x);

            x_copy = x; //save the same string
            
            positive = x.Split('+'); //save positive numbers
            negative = x.Split('-'); //save negative numbers

            

            /*foreach (var num in positive){
                Console.WriteLine(num);
            }

            foreach (var num in negative)
            {
                Console.WriteLine(num);
            }*/


            Console.ReadLine();
        }
    }
}
