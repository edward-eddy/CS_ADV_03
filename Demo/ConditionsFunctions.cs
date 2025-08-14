namespace Demo
{
    public delegate bool ConditionFuncDelegate(int A);
    internal class ConditionsFunctions
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool CheckDivisableBy3(int X) { return X % 3 == 0; }
        public static bool CheckDivisableBy4(int X) { return X % 4 == 0; }

    }
}
