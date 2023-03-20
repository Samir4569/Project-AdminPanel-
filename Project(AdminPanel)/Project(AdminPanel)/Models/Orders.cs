namespace Project_AdminPanel_.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int Price { get; set; }
        public string ProjectName { get; set; }
        public string startdate { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentStatus { get; set; }

    }
}
