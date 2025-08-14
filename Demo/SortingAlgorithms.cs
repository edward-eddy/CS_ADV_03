﻿namespace Demo
{
    //public delegate bool SortingFuncDelegate(int A, int B);
    //public delegate bool SortingFuncDelegateV02(string A, string B);

    // Generic Delegate
    public delegate bool SortingFuncDelegate<T>(T A, T B);
    internal class SortingAlgorithms
    {

        public static void BubbleSort<T>(T[] Arr, SortingFuncDelegate<T> reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)

                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                        {
                            SWAP(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
            }
        }


        //public static void BubbleSort(int[] Arr, SortingFuncDelegate reference)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (reference.Invoke(Arr[j], Arr[j + 1]))
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //    }
        //}

        //public static void BubbleSort(string[] Arr, SortingFuncDelegateV02 reference)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (reference.Invoke(Arr[j], Arr[j + 1]))
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //    }
        //}
        // -----------------------------------------------------------------

        //public static void BubbleSortAsc(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingAlgorithms.CompareGtr(Arr[j], Arr[j + 1]))
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //    }
        //}

        //public static void BubbleSortDesc(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingAlgorithms.CompareLess(Arr[j], Arr[j + 1]))
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //    }
        //}


        //public static void BubbleSortAsc(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] > Arr[j + 1])
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //    }
        //}

        //public static void BubbleSortDesc(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)

        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] < Arr[j + 1])
        //                {
        //                    SWAP(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //    }
        //}


        // =========================SWAP=========================
        private static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }


        //private static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //private static void SWAP(ref string X, ref string Y)
        //{
        //    string Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
    }
}
