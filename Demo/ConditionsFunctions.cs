namespace Demo
{
    //public delegate bool ConditionFuncDelegate(int A);
    //public delegate bool ConditionFuncDelegateV02(string A);
    public delegate bool ConditionFuncDelegate<T>(T A);
    internal class ConditionsFunctions
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool CheckDivisableBy3(int X) { return X % 3 == 0; }
        public static bool CheckDivisableBy4(int X) { return X % 4 == 0; }
        public static bool CheckLengthGtrThan4(string X) { return X.Length > 4; }
        public static bool CheckLengthLessThan4(string X) { return X.Length > 4; }
        public static bool CheckLengthEqual4(string X) { return X.Length == 4; }

    }
}
