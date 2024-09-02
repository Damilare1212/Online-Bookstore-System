namespace Online_Bookstore_System.Context
{
    public interface ISoftDelete
    {
        DateTime? DeletedOn { get; set; }
        int? DeletedBy { get; set; }
        bool IsDeleted { get; set; }
    }
}
