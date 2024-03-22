namespace Mission11_Bastian.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        //Calculate the number of pages needed depending on the number of items and items per page
        public int TotalNumPages => (int)(Math.Ceiling((decimal) TotalItems / ItemsPerPage));
    }
}
