namespace Mission11_Bastian.Models.ViewModels
{
    //Model for models needed so multiple models can be sent to view
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;}
    }
}
