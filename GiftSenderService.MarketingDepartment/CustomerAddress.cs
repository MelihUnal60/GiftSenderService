namespace GiftSenderProject.Domain
{
    public class CustomerAddress
    {
        public CustomerAddress(string city, string country, string street)
        {
            City = city;
            Country = country;
            Street = street;
        }

        public string City { get; set; }

        public string Country { get; set; }

        public string Street { get; set; }
    }

    

    
}