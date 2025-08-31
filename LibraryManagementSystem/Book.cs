

namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public DateTime CollectionDate { get; set; }
        private int AvailableBooks { get; set; }

        public Book(DateTime collectionDate, int count )
        {
            CollectionDate = collectionDate;
            AvailableBooks = count;
        }


        public void Borrow()
        {
            Console.WriteLine("Borrow the book");
            AvailableBooks--;
        }

        public void bookCount()
        {
            Console.WriteLine("Available book: " + AvailableBooks);
        }
    }
}
