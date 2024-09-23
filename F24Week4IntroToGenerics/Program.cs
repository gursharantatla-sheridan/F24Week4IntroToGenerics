namespace F24Week4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing
            int i = 123;
            object obj = i;


            // unboxing
            if (obj is int)
                i = (int)obj;
        }

        static bool AreEqual(object a, object b)
        {
            return a.Equals(b);
        }
    }
}
