using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> students = new Dictionary<int, string>()
            //{
            //    {15,"Sam" },
            //    {12, "Amit" },
            //    {53,"Raj" }
            //};
            //Console.WriteLine("Number of students are: "+students.Count);
            //Console.WriteLine("Roll \t Name");
            //foreach(var k in students.Keys) 
            //{
            //    Console.WriteLine(k + "\t" + students[k]);
            //}
            //students.Add(32, "Deep");
            //Console.WriteLine("Updated Students List");
            //Console.WriteLine("Number of students are: " + students.Count);

            //Console.WriteLine("Roll \t Name");
            //foreach(var k in students.Keys)
            //{
            //    Console.WriteLine(k+"\t" + students[k]);
            //}

            //Find & replace ctrl+H, comment ctr+k+c, Uncomment: ctr+k+U

            //sortedList example

            //SortedList<int, string> students = new SortedList<int, string>()
            //{
            //    {15,"Sam" },
            //    {12, "Amit" },
            //    {53,"Raj" }
            //};
            //Console.WriteLine("Number of students are: " + students.Count);
            //Console.WriteLine("Roll \t Name");
            //foreach (var k in students.Keys)
            //{
            //    Console.WriteLine(k + "\t" + students[k]);
            //}
            //students.Add(32, "Deep");
            //Console.WriteLine("Updated Students List");
            //Console.WriteLine("Number of students are: " + students.Count);

            //Console.WriteLine("Roll \t Name");
            //foreach (var k in students.Keys)
            //{
            //    Console.WriteLine(k + "\t" + students[k]);
            //}
            //Console.ReadKey();

            SortedList<string, string>hardwareList = new SortedList<string, string>()
            {
                {"CD","Compact Disc"},
                {"FDD", "Floppy Disc" },
                { "HDD", "Hard Disc"},
                {"RAM", "Random Access Memory" }
            };
            Console.WriteLine("Short Form  \t Full form");
            foreach (var k in hardwareList.Keys)
            {
                Console.WriteLine(k + "\t" + hardwareList[k]);
            }
            Console.ReadKey();
        }
    }
}
