namespace WebApiPerson.Models.DTO
{
    public class CreateOrderDto
    {
        public required string ProductName { get; set; }
        public required decimal Price { get; set; }
        public required DateTime OrderDate { get; set; }
        public required int PersonId { get; set; }
    }
}
