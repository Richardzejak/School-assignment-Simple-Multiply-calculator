﻿using System;


class Program
{
    static void Main()
    {
        int term1, term2, term3;
        string operator1;
        string operator2;

        Console.WriteLine("Enter first operator: ");
        operator1 = Console.ReadLine();
        Console.WriteLine("Enter second operator: ");
        operator2 = Console.ReadLine();
        Console.WriteLine("Enter first term: ");
        term1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second term: ");
        term2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third term: ");
        term3 = Convert.ToInt32(Console.ReadLine());

        if (operator1.Equals("+"))
        {
            if (operator2.Equals("+"))
            {
                Console.WriteLine("{0} + {1} + {2} = {3}", term1, term2, term3, term1 + term2 + term3);
            }
        }
        if (operator1.Equals("+"))
        {
            if (operator2.Equals("-"))
                {
                Console.WriteLine("{0} + {1} - {2} = {3}", term1, term2, term3, term1 + term2 - term3);
            }
        }
        if (operator1.Equals("+"))
        {
            if (operator2.Equals("*"))
                {
                Console.WriteLine("{0} + {1} * {2} = {3}", term1, term2, term3, term1 + term2 * term3);
            }
        }
        if (operator1.Equals("+"))
        {
            if (operator2.Equals("/"))
                {
                Console.WriteLine("{0} + {1} / {2} = {3}", term1, term2, term3, term1 + term2 / term3);
            }
        }

        if (operator1.Equals("-"))
        {
            if (operator2.Equals("+"))
            {
                Console.WriteLine("{0} - {1} + {2} = {3}", term1, term2, term3, term1 - term2 + term3);
            }
        }
        if (operator1.Equals("-"))
        {
            if (operator2.Equals("-"))
            {
                Console.WriteLine("{0} - {1} - {2} = {3}", term1, term2, term3, term1 - term2 - term3);
            }
        }
        if (operator1.Equals("-"))
        {
            if (operator2.Equals("*"))
            {
                Console.WriteLine("{0} - {1} * {2} = {3}", term1, term2, term3, term1 - term2 * term3);
            }
        }
        if (operator1.Equals("-"))
        {
            if (operator2.Equals("/"))
            {
                Console.WriteLine("{0} - {1} / {2} = {3}", term1, term2, term3, term1 - term2 / term3);
            }
        }

        if (operator1.Equals("*"))
        {
            if (operator2.Equals("+"))
            {
                Console.WriteLine("{0} * {1} + {2} = {3}", term1, term2, term3, term1 * term2 + term3);
            }
        }
        if (operator1.Equals("*"))
        {
            if (operator2.Equals("-"))
            {
                Console.WriteLine("{0} * {1} - {2} = {3}", term1, term2, term3, term1 * term2 - term3);
            }
        }
        if (operator1.Equals("*"))
        {
            if (operator2.Equals("*"))
            {
                Console.WriteLine("{0} * {1} * {2} = {3}", term1, term2, term3, term1 * term2 * term3);
            }
        }
        if (operator1.Equals("*"))
        {
            if (operator2.Equals("/"))
            {
                Console.WriteLine("{0} * {1} / {2} = {3}", term1, term2, term3, term1 * term2 / term3);
            }
        }

        if (operator1.Equals("/"))
        {
            if (operator2.Equals("+"))
            {
                Console.WriteLine("{0} / {1} + {2} = {3}", term1, term2, term3, term1 / term2 + term3);
            }
        }
        if (operator1.Equals("/"))
        {
            if (operator2.Equals("-"))
            {
                Console.WriteLine("{0} / {1} - {2} = {3}", term1, term2, term3, term1 / term2 - term3);
            }
        }
        if (operator1.Equals("/"))
        {
            if (operator2.Equals("*"))
            {
                Console.WriteLine("{0} / {1} * {2} = {3}", term1, term2, term3, term1 / term2 * term3);
            }
        }
        if (operator1.Equals("/"))
        {
            if (operator2.Equals("/"))
            {
                Console.WriteLine("{0} / {1} / {2} = {3}", term1, term2, term3, term1 / term2 / term3);
            }
        }
    }
}
