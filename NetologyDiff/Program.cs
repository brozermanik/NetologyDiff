using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace NetologyDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegates lesson
            var r = new Class1();
            Console.WriteLine(r.CallBackMethod());
            r.CreateBinds();
            Console.WriteLine(r.CallBackMethod());
            
            //LINQ Lesson
            var array = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var strings = new List<string>();
            
            foreach (var el in array)
            {
                strings.Add(el.ToString());
            }
            
            var strings2 = new List<string>(array.Select(element=>element.ToString()));
            
            var min = array.Min();
            var max = array.Max();
            
            var MoreThanFive = array.First(t=>t>5);
            var LessThanFive = array.Last(t => t < 5);
            var MoreThanFive2 = array.FirstOrDefault(t=>t>50);
            var LessThanFive2 = array.LastOrDefault(t => t < 50);
            
            var t1 = new List<int>(array.Where(t => t > 5));

            var testLinq = new List<TestLinq>();
            for (int i =1; i<=10; i++)
            {
                testLinq.Add(new TestLinq {Value = i});
            }
            var MoreThanFiveInLinq = testLinq.First(t=>t.Value>5);
            var LessThanFiveInLinq = testLinq.Last(t => t.Value < 5);
            
            var array2 = new List<object>() {1, 2, 3, 4, 5, "dfg", 7, 8, 9, 10};
            var t2 = array2.Where(t => (int)t > 5);
        }

        public class TestLinq
        {
            public int Value;
        }
    }
}