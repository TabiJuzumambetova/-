using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        class Class
        {
            //8.	удваивает каждое вхождение заданного символа x;
            static void Main()
            {
                string originalString = Console.ReadLine();
                char x = char.Parse(Console.ReadLine());

                string doubledString = originalString.Replace(x.ToString(), x.ToString() + x.ToString());

                Console.WriteLine(doubledString);





            }


        }

    }
    class Class
    {

        static void Main()
        {

            string inputString = Console.ReadLine();
            int stringLength = inputString.Length;

            if (stringLength % 2 == 0)
            {

                int middleIndex = stringLength / 2;
                inputString = inputString.Remove(middleIndex - 1, 2);
            }
            else
            {

                int middleIndex = stringLength / 2;
                inputString = inputString.Remove(middleIndex, 1);
            }

            Console.WriteLine(inputString);




        }


    }
    class Classs
    {

        static void Main()
        {

            string inputString = Console.ReadLine();
            int stringLength = inputString.Length;

            if (stringLength % 2 == 0)
            {

                int middleIndex = stringLength / 2;
                inputString = inputString.Remove(middleIndex - 1, 2);
            }
            else
            {

                int middleIndex = stringLength / 2;
                inputString = inputString.Remove(middleIndex, 1);
            }

            Console.WriteLine(inputString);




        }


    }

}

