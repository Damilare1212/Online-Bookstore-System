namespace Online_Bookstore_System.Dtos
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }

    public class UpdateAuthorRequestModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
