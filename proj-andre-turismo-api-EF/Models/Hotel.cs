namespace proj_andre_turismo_api_EF.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string NameHotel { get; set; }
        public Address Address { get; set; }
        public decimal CostHotel { get; set; }
        public DateTime DtRegistration { get; set; }
    }
}
