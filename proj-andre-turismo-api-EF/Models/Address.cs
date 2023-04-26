namespace proj_andre_turismo_api_EF.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string PostalCode { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
        public DateTime DtRegistration { get; set; }
    }
}
