namespace Online_Bookstore_System.Dtos
{
    public class BookDto
    {
        public bool IsAproved { get; }
        public int? Id { get; set; }
        public decimal price { get; set; }
        public bool? IsDownloaded { get; set; }
    }

    public class UpdateBookDto
    {
        public decimal price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
    public class BookResponseModel : BaseResponse
    {
        public BookDto Data { get; set; }
    }
}
