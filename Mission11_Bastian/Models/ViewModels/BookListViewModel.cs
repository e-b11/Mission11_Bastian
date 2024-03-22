namespace Mission11_Bastian.Models.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;}
    }
}
