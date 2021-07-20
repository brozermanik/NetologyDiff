using System;

namespace NetologyDiff
{
    public class Class1
    {
        public delegate string ExampleDelegate(int arg1, long arg2);

        public event ExampleDelegate ExampleEventHandler;

        public void CreateBinds()
        {
            ExampleEventHandler += (i, l) =>
            {
                if (i > l)
                {
                    return "Greater";
                }
                else return "Less";
            };

            ExampleEventHandler += Print;
            ExampleEventHandler -= Print;
        }

        public string Print(int arg1, long l)
        {
            Console.WriteLine("call");
            return string.Empty;
        }

        public string CallBackMethod()
        {
            return ExampleEventHandler?.Invoke(10,20);
        }
    }
}