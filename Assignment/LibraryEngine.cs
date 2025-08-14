using static Assignment.Program;

namespace Assignment
{
    public class LibraryEngine
    {
        //public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        public static void ProcessBooks(List<Book> bList, BookFunctionsDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
