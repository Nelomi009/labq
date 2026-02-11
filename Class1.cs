/**************************
* Автор: Черненко Никита. *
* Дата: 05.02.2026        *
* Вариант -               *
***************************/


using System;

namespace lab1
{

    class Program
    {
        static void Main()
        {

            int numA;
            int numN;
            int answer = 1;
            string numX;
            char num1;

            Console.WriteLine("enter a:");
            numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter n:");
            numN = Convert.ToInt32(Console.ReadLine());

            for (int indexI = 0; indexI < numN; ++indexI)
            {
                answer = answer * numA;
            }
            Console.WriteLine(answer);

            Console.WriteLine(" enter X >=100 ");
            numX = Console.ReadLine();

            if (numX.Length > 2)
            {

                num1 = numX[1];
                numX = numX.Remove(1, 1);
                numX = numX + num1;

                Console.WriteLine(numX);
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
        }
    }
}