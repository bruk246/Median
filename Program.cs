using System;

public class Median
{
    public static void Main()

    {
        //read array1 size
        Console.WriteLine("Enter the size of your array1 ");
        int x = Convert.ToInt32(Console.ReadLine());
        int[] num1 = new int[x];

        Console.Write("Input " + x + " numbers in the array1 :\n");
        for (int i = 0; i < x; i++)
        {
            Console.Write("index - {0} : ", i);
            num1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\n");
        //read arry2 size
        Console.WriteLine("Enter the size of your array2");
        int y = Convert.ToInt32(Console.ReadLine());
        int[] num2 = new int[y];
        Console.Write("Input " + y + " numbers in the array2 \n");


        // read array1 elemnts
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
        Console.Write("\n");

        // read array2 elemnts
        Console.Write("Elements in array2  : ");
        for (int i = 0; i < y; i++)
        {

            Console.Write("{0}  ", num2[i]);
        }
        Console.Write("\n\n");

        // merge array1 and array2
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

      
        //Sort merged array
        Console.Write("Sorted array        : ");
        Array.Sort(num1);


        foreach (int i in num1)
        {
            Console.Write(i + " ");
        }
        Console.Write("\n");

        //calcuate the median
        if (size % 2 != 0)
        {
            Console.WriteLine("The median is        :" + num1[size / 2]);
        }
        else
        {

            double median= ((num1[(size / 2)] + num1[(size - 1) / 2]) / 2.0);
            Console.Write("\n");
            Console.WriteLine("The median is       : " + median);
        }
    }

}