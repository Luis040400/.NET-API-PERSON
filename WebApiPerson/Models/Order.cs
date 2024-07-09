namespace WebApiPerson.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public required decimal Price { get; set; }
        public required DateTime OrderDate { get; set; }

        public int PersonId { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public Person Person { get; set; }
    }
}
