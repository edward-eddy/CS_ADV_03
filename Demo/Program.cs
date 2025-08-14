namespace Demo
{
    // Class
    // interface
    // enum
    // struct
    // delegate

    // Step 01 : Create New Datatype (Delegate)
    public delegate int StringFuncDelegate(string s);
    // NEW Delegate(Class): Reference (Pointer) Can Refer To Function or More (Pointer of Function)
    // These Function Must Be Have The Same Signature Of The Delegate: int(string)
    // Regardless Function Name, Parameters Names Or, Access Modifiers

    internal class Program
    {
        #region Delegate Ex02
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Delegate Ex03

        //public static List<T> FindElements<T>(List<T> list, ConditionFuncDelegate<T> reference)
        public static List<T> FindElements<T>(List<T> list, Predicate<T> reference)
        {
            List<T> Result = new List<T>();
            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                    {
                        Result.Add(list[i]);
                    }
                }
            }
            return Result;
        }

        //public static List<int> FindElements(List<int> list, ConditionFuncDelegate reference)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}
        //public static List<string> FindElements(List<string> list, ConditionFuncDelegateV02 reference)
        //{
        //    List<string> Result = new List<string>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference.Invoke(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        // ===============================================================================

        //public static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckOdd(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckEven(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindDivisibleBy3Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckDivisableBy3(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindDivisibleBy4Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionsFunctions.CheckDivisableBy4(list[i]))
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindOddNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 != 0)
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0)
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindDivisibleBy3Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 3 == 0)
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        //public static List<int> FindDivisibleBy4Numbers(List<int> list)
        //{
        //    List<int> Result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 4 == 0)
        //            {
        //                Result.Add(list[i]);
        //            }
        //        }
        //    }
        //    return Result;
        //}

        public static void PrintList<T>(List<T> values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        #endregion


        static void Main(string[] args)
        {
            #region Delegate Overview
            // Delegate : C# Feature

            // C# Pure OOP

            // Functional Programming
            // Event-Driven Programming

            // Java : Pure OOP
            // DP: Design Patterns 
            #endregion

            #region Delegate Ex01
            //// Step 02: Use Delegate
            ////StringFuncDelegate X;
            ////X = StringFunctions.GetCountOfUpperCaseChars;
            ////X.

            ////StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpperCaseChars);

            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars; // Syntax Sugar
            ////X = StringFunctions.GetCountOfLowerCaseChars; // GetCountOfLowerCaseChars
            //X += StringFunctions.GetCountOfLowerCaseChars; // GetCountOfUpperCaseChars + GetCountOfLowerCaseChars



            ////int Count = X.Invoke("Hello, World!");
            //int Count = X("Hello, World!"); // Syntax Sugar
            //Console.WriteLine(Count); 
            #endregion

            #region Delegate Ex02
            //int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };

            //PrintArray(Numbers);

            //SortingAlgorithms.BubbleSortAscending(Numbers); // Sorting Ascending
            ////SortingAlgorithms.BubbleSortDescending(Numbers); // Sorting Descending

            //SortingFuncDelegate X = SortingConditions.CompareGtr;
            //SortingFuncDelegate X = SortingConditions.CompareLess;

            //SortingAlgorithms.BubbleSort(Numbers, X); // Sorting Ascending
            //SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareGtr); // Sorting Ascending

            //SortingAlgorithms.BubbleSort(Numbers, X); // Sorting Descending
            //SortingAlgorithms.BubbleSort(Numbers, SortingConditions.CompareLess); // Sorting Descending

            //PrintArray(Numbers);

            //string[] Names = { "Ahmed", "Ali", "Maraim", "Mahmoud", "Amr", "Mona", "Khaled" };

            //PrintArray(Names);

            //SortingAlgorithms.BubbleSort(Names, SortingConditions.CompareGtr);
            //SortingAlgorithms.BubbleSort(Names, SortingConditions.CompareLess);

            //PrintArray(Names) 
            #endregion

            #region Delegate Ex03
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            ////List<int> OddNumbers = FindOddNumbers(Numbers);
            ////List<int> EvenNumbers = FindEvenNumbers(Numbers);
            ////List<int> DivisableBy3Numbers = FindDividableBy3Numbers(Numbers);
            ////List<int> DivisableBy4Numbers = FindDividableBy4Numbers(Numbers);

            //List<int> OddNumbers = FindElements(Numbers, ConditionsFunctions.CheckOdd);
            //List<int> EvenNumbers = FindElements(Numbers, ConditionsFunctions.CheckEven);
            //List<int> DivisableBy3Numbers = FindElements(Numbers, ConditionsFunctions.CheckDivisableBy3);
            //List<int> DivisableBy4Numbers = FindElements(Numbers, ConditionsFunctions.CheckDivisableBy4);


            //PrintList(DivisableBy4Numbers); 


            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Maraim", "Mahmoud", "Amr", "Mona", "Khaled" };

            //List<string> Result = FindElements(Names, ConditionsFunctions.CheckLengthLessThan4);

            //PrintList(Result); 
            #endregion

            #region Built-in Delegates
            //// Built-in Delegate

            //// Predicate, Func, Action

            //// ConditionFuncDelegate<int> X = ConditionsFunctions.CheckEven;

            ////Predicate<int> predicate = ConditionsFunctions.CheckEven;

            ////bool r = predicate.Invoke(1);
            ////Console.WriteLine(r);

            //Func<int> func1 = Fun01;
            //Func<int, string> func2 = Fun02;
            //// Func<>

            //Func<int, bool> func = ConditionsFunctions.CheckEven;



            //Action<string> action = Print;

            ////action.Invoke();
            ////action(); 
            #endregion

            #region Anonymous Method & Lambda Expression
            ////Func<int, bool> func = ConditionsFunctions.CheckEven;

            ////func(1);



            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9, 10 };

            //// Anonymous Method
            //// C# 2.0 2005

            ////Func<int, bool> func = delegate (int X) { return X % 2 == 0; }; // Anonymous Method

            //////FindElements(Numbers, func);
            ////FindElements(Numbers, delegate (int X) { return X % 2 == 0; });


            //// Lambda Expression [Recommended]
            //// C# 3.0 2007

            //Func<int, bool> func = X => X % 2 == 0;  // Lambda Expression

            ////FindElements(Numbers, func);
            ////FindElements(Numbers, delegate (int X) { return X % 2 == 0; });
            //FindElements(Numbers, N => N % 2 == 0);
            //FindElements(Numbers, N => N % 2 != 0);

            //Enumerable.Where(Numbers, ConditionsFunctions.CheckOdd);
            //Enumerable.Where(Numbers, delegate (int N) { return N % 2 != 0; });


            //Enumerable.Where(Numbers, (N) => N % 2 != 0); // ======> 
            #endregion
        }

        public static void Print(string S)
        {
            Console.WriteLine("Hello");
        }
        public static int Fun01()
        {
            return 1;
        }
        public static string Fun02(int X)
        {
            return $"{X}";
        }
    }
}
