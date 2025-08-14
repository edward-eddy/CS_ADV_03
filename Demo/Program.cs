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
        public static void PrintArray<T>(T[] values)
        {
            Console.WriteLine();
            foreach (T item in values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
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




        }
    }
}
