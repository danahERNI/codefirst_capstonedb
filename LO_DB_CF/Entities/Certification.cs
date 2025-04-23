namespace LO_DB_CF.Entities
{
    public class Certification
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateOnly Expiration { get; set; }
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
