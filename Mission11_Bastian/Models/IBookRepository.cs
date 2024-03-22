namespace Mission11_Bastian.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
