using System;
/*
 Author: Karly Lamm
Lindenwood University - C# class
November 7th, 2020
 */

public class Program
{

    public static void Main()
    {
        //Array to hold names
        string[] salesPersons = new string[3];
        //Array to hold sales
        double[] sales = new double[3];
        double totalSales = 0;


        for (int i = 0; i < 3; i++)
        {

            Console.Write("\nEnter Sales Person first initial: ");
            salesPersons[i] = Console.ReadLine();


            Console.Write("Enter amount of sales: ");
            sales[i] = Convert.ToDouble(Console.ReadLine());
        }

         Console.WriteLine(""
        + "\nDanielle's Amount:{0}"
        + "\nEdward's Amount: {1}"
        + "\nFrancis' Amount: {2}", sales[0].ToString("C"), sales[1].ToString("C"), sales[2].ToString("C"));

 
            totalSales= sales[0]+ sales[1]+ sales[2];
       // }

        Console.WriteLine("\n\n Total Sales were " + totalSales.ToString("C"));
        Console.ReadLine();
    }

}