﻿


namespace TSD.AccountingSoft.Model.BusinessObjects.Dictionary
{
    public class VendorModel
    {
        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string ContactName { get; set; }
        public string ContactRegency { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string TaxCode { get; set; }
        public string Website { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Area { get; set; }
        public string Country { get; set; }
        public string BankNumber { get; set; }
        public string BankName { get; set; }
        public int? BankId { get; set; }
        public bool IsActive { get; set; }
    }
}
