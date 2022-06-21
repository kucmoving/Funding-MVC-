namespace Funding_MVC_.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateEdited { get; set; }
    }
}
