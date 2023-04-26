namespace proj_andre_turismo_api_EF.Models
{
    public class Package
    {
        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public Ticket Ticket { get; set; }
        public DateTime DtRegistration { get; set; }
        public decimal Cost { get; set; }
        public Customer Customer { get; set; }
    }
}
