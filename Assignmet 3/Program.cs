using System;
using System.Diagnostics;
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


        }
    }
}
