using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected3_8_
{
    class Program
    {
        static void InputArray(ref int[] someArray)
        {
            Console.WriteLine("Enter your array: ");
            for (int i = 0; i < someArray.Length; i++)
            {
                Console.Write($"[{i}] = ");
                while (int.TryParse(Console.ReadLine(), out someArray[i]) == false)
                {
                    Console.WriteLine("Wrong input! Try again! ");
                    Console.Write($"[{i}] = ");
                }
            }
        }

        static void GetNewArray(int[] someArray)
        {
            int indexOfLastNegativeElement = new int();
            for (int i = 0; i < someArray.Length; i++)
            {
                if(someArray[i] < 0)
                {
                    indexOfLastNegativeElement = Array.LastIndexOf(someArray, someArray[i]);
                }
            }

            int[] newArray = new int[indexOfLastNegativeElement];
            int newArrayIndex = new int();

            for (int i = 0; i < indexOfLastNegativeElement; i++)
            {
                int temp = someArray[i];
                int counter = 0;

                if (newArrayIndex == indexOfLastNegativeElement)
                    break;

                for (int j = i; j < indexOfLastNegativeElement; j++)
                {
                 if(someArray[j] == temp)
                    {
                        counter++;
                    }
                }

                if (counter > 1)
                {
                    for (int z = 0; z < counter; z++)
                    {
                        newArray[newArrayIndex] = temp;
                        newArrayIndex++;
                    }
                }
            }
            Console.WriteLine("Here is array B");
            PrintArray(newArray);
        }

        static void PrintArray(int[] someArray)
        {
            Console.WriteLine("--------------------------------");
            foreach (int element in someArray)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            InputArray(ref myArray);
            GetNewArray(myArray);

        }
    }
}
