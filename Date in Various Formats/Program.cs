﻿/*
 * C# Program to Display the Date in Various Formats 
 */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_in_Various_Formats
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2013, 6, 23);
            Console.WriteLine("Some Date Formats : ");
            Console.WriteLine("Date and Time:  {0}", date);
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            Console.WriteLine(date.ToString("dd-MMM-yy"));
            Console.WriteLine(date.ToString("M/d/yyyy"));
            Console.WriteLine(date.ToString("M/d/yy"));
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("MM/dd/yy"));
            Console.WriteLine(date.ToString("yy/MM/dd"));
            Console.Read();
            return;
        }
    }
}
