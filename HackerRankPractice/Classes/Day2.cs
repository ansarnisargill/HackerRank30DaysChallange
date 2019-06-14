
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace HackerRankPractice.Classes
{
    public class SolutionDay2
    {

        // Complete the solve function below.
        public void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            var tip = meal_cost * (tip_percent / 100.0);
            var tax = meal_cost * (tax_percent / 100.0);
            var total_cost = Math.Round(meal_cost + tip + tax, 0);
            Console.WriteLine(total_cost);
            Console.Read();

        }


        public SolutionDay2()
        {
            Console.WriteLine("Enter Meal Cost");
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter tip percentage");
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tax percentage");
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}


