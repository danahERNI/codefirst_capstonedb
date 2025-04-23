namespace LO_DB_CF.Entities
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
