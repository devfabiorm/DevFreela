namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int ClientId { get; set; }
        public int FreelancerId { get; set; }
        public decimal TotalCost { get; set; }
    }
}
