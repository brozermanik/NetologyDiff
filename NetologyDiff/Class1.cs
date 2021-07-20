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
        }
    }
}