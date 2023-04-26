﻿namespace proj_andre_turismo_api_EF.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public DateTime DtRegistration { get; set; }
    }
}
