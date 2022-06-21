using System;
public class Median
{
    public static void Main()

    {
        Console.WriteLine("Enter the size of your array1");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] num1 = new int[x];

        Console.Write("Input " + x + " numbers in the array1 :\n");
        for (int i = 0; i < x; i++)
        {
            Console.Write("index - {0} : ", i);
            num1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\n");
        Console.WriteLine("Enter the size of your array2");
        int y = Convert.ToInt32(Console.ReadLine());
        int[] num2 = new int[y];
        Console.Write("Input " + y + " numbers in the array2 \n");


        for (int i = 0; i < y; i++)
        {
            Console.Write("index - {0} : ", i);
            num2[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("\nElements in array1  : ");

        for (int i = 0; i < x; i++)
        {
            Console.Write("{0}  ", num1[i]);

        }


        Console.Write("\nElements in array2  : ");
        for (int i = 0; i < y; i++)
        {

            Console.Write("{0}  ", num2[i]);
        }
        Console.Write("\n\n");
        //merging array
        Console.Write("Merge arr1 and arr2 :");
        num1 = num1.Concat(num2).ToArray();


        for (int i = 0; i < x + y; i++)
        {


            Console.Write(" " + num1[i]);

        }
        Console.Write("\n");
        int size = num1.Length;
        Console.WriteLine("Merged array size   : " + size);
        Console.Write("\n");

        Console.Write("Sorted array        : ");
        Array.Sort(num1);




        foreach (int i in num1)
        {
            Console.Write(i + " ");
        }
        Console.Write("\n");
        if (size % 2 != 0)
        {
            Console.WriteLine("The median is        :" + num1[size / 2]);
        }
        else
        {

            double result = ((num1[(size / 2)] + num1[(size - 1) / 2]) / 2.0);
            Console.Write("\n");
            Console.WriteLine("The median is       : " + result);
        }
    }

}