namespace ETicaretAPI.Application.DTOs.Order
{
    public class CompletedOrderDTO
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
