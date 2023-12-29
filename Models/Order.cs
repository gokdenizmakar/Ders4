namespace Ders4.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int TotalPrice { get; set; }
        public List<WebUser> WebUsers { get; set; }
    }
}
