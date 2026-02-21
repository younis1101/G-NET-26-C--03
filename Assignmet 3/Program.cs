using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Security.Claims;
using System.Text;

namespace Assignmet_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            /// (b)Rewrite this code using StringBuilder to be more efficient.



            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append(i);
            //    if (i < 5000) sb.Append(",");
            //}
            //string result = sb.ToString();
            //Console.WriteLine(result);

            /// (c)Add timing code(using Stopwatch) to both versions and report
            ///the time difference.
            //Stopwatch sw1 = new Stopwatch();
            //sw1.Start();

            //string result1 = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    result1 += i;
            //    if (i < 5000)
            //        result1 += ",";
            //}
            //sw1.Stop();
            //Console.WriteLine("String Time: " + sw1.ElapsedMilliseconds + " ms");


            // StringBuilder
            //Stopwatch sw2 = new Stopwatch();
            //sw2.Start();

            //StringBuilder sb = new StringBuilder();
            //for (int i = 1; i <= 5000; i++)
            //{
            //    sb.Append(i);
            //    if (i < 5000)
            //        sb.Append(",");
            //}

            //string result2 = sb.ToString();

            //sw2.Stop();
            //Console.WriteLine("StringBuilder Time: " + sw2.ElapsedMilliseconds + " ms");


            #endregion

            #region Question 2
            ///Ticket Pricing System

            //Console.Write("Enter age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Enter day (1-7, 6=Fri, 7=Sat): ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Student? (yes/no): ");
            //bool isStudent = Console.ReadLine().ToLower() == "yes";

            //int price = 0;
            //bool isFree = false;
            //string breakdown = "";

            //if (age < 5)
            //{
            //    price = 0;
            //    isFree = true;
            //    breakdown = "Free (under 5)";
            //}
            //else if (age >= 5 && age <= 12)
            //{
            //    price = 30;
            //    breakdown = "30 LE (Child)";
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    price = 50;
            //    breakdown = "50 LE (Adult)";
            //}
            //else if (age >= 60)
            //{
            //    price = 25;
            //    breakdown = "25 LE (Senior)";
            //}

            //if (!isFree && (day == 6 || day == 7))
            //{
            //    price += 10;
            //    breakdown += " + 10 LE weekend";
            //}

            //if (isStudent && !isFree)
            //{
            //    int discount = (int)(price * 0.2);
            //    price -= discount;
            //    breakdown += $" - {discount} LE student discount";
            //}

            //Console.WriteLine($"Final price: {price} LE");
            //Console.WriteLine($"Breakdown: {breakdown}");



            #endregion

            #region Question 3
            /// Convert the following if-else chain to:
            /// (a)A traditional switch statement
            /// 

            //int grade = int.Parse(Console.ReadLine());

            //switch (grade)
            //{
            //    case 90:
            //    case 91:
            //    case 92:
            //    case 93:
            //    case 94:
            //    case 95:
            //    case 96:
            //    case 97:
            //    case 98:
            //    case 99:
            //    case 100:
            //        Console.WriteLine("A");
            //        break;

            //    case 80:
            //    case 81:
            //    case 82:
            //    case 83:
            //    case 84:
            //    case 85:
            //    case 86:
            //    case 87:
            //    case 88:
            //    case 89:
            //        Console.WriteLine("B");
            //        break;

            //    case 70:
            //    case 71:
            //    case 72:
            //    case 73:
            //    case 74:
            //    case 75:
            //    case 76:
            //    case 77:
            //    case 78:
            //    case 79:
            //        Console.WriteLine("C");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid Grade");
            //        break;
            //}
            /// (b)A switch expression
            //    int grade = int.Parse(Console.ReadLine());

            //    string result = grade switch
            //    {
            //        >= 90 and <= 100 => "A",
            //        >= 80 and < 90 => "B",
            //        >= 70 and < 80 => "C",
            //        _ => "Invalid Grade"
            //    };

            //    Console.WriteLine(result);
            /// }











            #endregion

            #region Question 4
            /// Ternary Operator
            ///Rewrite the following using only ternary operators(no if statements):

            int age = int.Parse(Console.ReadLine());

            string result = age < 5 ? "Free" :
                            age <= 12 ? "30 LE" :
                            age <= 59 ? "50 LE" :
                            "25 LE";

            Console.WriteLine(result);








            #endregion
        }
    }
}

