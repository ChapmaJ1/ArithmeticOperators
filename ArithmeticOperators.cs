using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    public class ArithmeticOperators
    {
        public static double circleCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            Math.Round(circumference, 2);
            return circumference;
        }
        public static double circleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Math.Round(area, 2);
            return area;
        }
        public static bool isDivisible(double num1, double num2)
        {
            if (num1 % num2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double calcHypotenuse(double length1, double length2)
        {
            double hypotenuseSquared = Math.Pow(length1, 2) + Math.Pow(length2, 2);
            double hypotenuse = Math.Sqrt(hypotenuseSquared);

            return hypotenuse;
        }
        public static void studentBooks()
        {
            Console.WriteLine("How many books are there?");
            int numBooks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many students are there?");
            int numStudents = Convert.ToInt32(Console.ReadLine());

            int booksPerStudent = numBooks / numStudents;
            int booksRemaining = numBooks % numStudents;

            Console.WriteLine("Each student will get " + booksPerStudent + " books");
            Console.WriteLine("There will be " + booksRemaining + " books left over");
        }
        public static int fileBlocks(int kibibytes)
        {
            double bytes = kibibytes * 1024;
            double blocksRequired = Math.Ceiling(bytes / 512);
            int finalBlocks = Convert.ToInt32(blocksRequired);
            return finalBlocks;
        }
        public static void pocketMoney()
        {
            Console.WriteLine("How much pocket money do you get per week?");
            double moneyPerWeek = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What percentage of this money do you want to save?");
            double percentage = Convert.ToDouble(Console.ReadLine());

            double savedWeekly = Math.Round((moneyPerWeek * percentage / 100), 2);
            double savedForYear = Math.Round((savedWeekly * 52), 2);

            Console.WriteLine("You will save £" + savedWeekly + " per week");
            Console.WriteLine("After 1 year you will have £" + savedForYear);
        }
    }
}
