namespace identity_custom.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public CustomUser Author { get; set; }
    }
}
