namespace TestAPI.Models
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Name name { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
    }

    public class Name
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
    }

    public class Address
    {
        public string city { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public string zipcode { get; set; }
        public Geolocation geolocation { get; set; }
    }

    public class Geolocation
    {
        public string lat { get; set; }
        public string _long { get; set; }
    }

}