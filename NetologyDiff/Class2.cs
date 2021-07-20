using System;

namespace NetologyDiff
{
    public class Class2
    {
        //Delegates2
        public event EventHandler<Class2> ExampleEventHandler;

        public void CreateBinds()
        {
            var func = new Func<int, int>((t) =>
            {
                return t * t;
            });

            var r=func.Invoke(14);
            CallbackMethod(func);

            Func<int, long, string> func2 = Print;
            Action<int, long, string> func3 = Print2;

            func3(10, 20, "yo");
        }

        public string Print(int arg1, long arg2)
        {
            Console.WriteLine("call");
            return string.Empty;
        }
        public void Print2(int arg1, long arg2, string arg3)
        {
            Console.WriteLine("call");
        }

        public string CallbackMethod(Func<int, int> func)
        {
            ExampleEventHandler?.Invoke(this, new Class2());
            return null;
        }
    }
}