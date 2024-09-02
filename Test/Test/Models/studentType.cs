namespace Test.Models
{
    public class studentType
    {
        public int studentTypeId { get; set; }
        public required string Name { get; set; }
        public int id { get; set; }
        public Teacher Teacher { get; set; }
    }
}
