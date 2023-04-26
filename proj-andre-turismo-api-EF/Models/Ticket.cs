namespace proj_andre_turismo_api_EF.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Address Origin { get; set; }
        public Address Destination { get; set; }
        public DateTime DtRegistration { get; set; }
        public decimal CostTicket { get; set; }
    }
}
