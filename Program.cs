/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchstatemnt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation (+, -, *, /):");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            Console.WriteLine("the resilt is "+result);
        }
    }
}*/

// unique elements from 2 array 

/*using System;

namespace demo
{
    public class UniqueArray
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int[] arr1 = { 4, 5, 3, 6, 1, 5, 8 };
            int[] arr2 = { 4, 8, 2, 77, 5, 4, 3 };

            int resiz = 10;
            int[] res = new int[resiz];

            // Check elements of arr1
            for (int i = 0; i < arr1.Length; i++)
            {
                bool found = false;

                // Check if the current element of arr1 exists in arr2
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        found = true;
                        break;
                    }
                }

                // If the element is not found in arr2, add it to res
                if (!found)
                {
                    res[count++] = arr1[i];
                }
            }

            // Check elements of arr2
            for (int i = 0; i < arr2.Length; i++)
            {
                bool found = false;

                // Check if the current element of arr2 exists in arr1
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        found = true;
                        break;
                    }
                }

                // If the element is not found in arr1, add it to res
                if (!found)
                {
                    res[count++] = arr2[i];
                }
            }

            // Print the result
            foreach (var value in res)
            {
                if (value != 0)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}
*/

// frequency of the string

using System;

public class Frequency
{
    public static void Main()
    {
        string S = "shashank";

        for (int i = 0; i < S.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < S.Length; j++)
            {
                if (S[i] == S[j])
                {
                    count++;
                }
            }

            // Check if this character has been printed before
            bool printed = false;
            for (int k = 0; k < i; k++)
            {
                if (S[i] == S[k])
                {
                    printed = true;
                    break;
                }
            }

            if (!printed)
            {
                Console.WriteLine(S[i] + " " + count);
            }
        }
    }
}
