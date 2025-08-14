namespace Assignment
{
    public class Program
    {
        // a) Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
        public delegate string BookFunctionsDelegate(Book book);

        static void Main(string[] args)
        {
            // b) Use the Proper build in delegate. 
            Func<Book, String> func = BookFunctions.GetTitle;

            // C) Anonymous Method (GetISBN).
            Func<Book, String> GetISBN = delegate (Book book) { return book.ISBN; };

            // D) Lambda Expression (GetPublicationDate)
            Func<Book, DateTime> GetPublicationDate = book => book.PublicationDate;

        }
    }
}
