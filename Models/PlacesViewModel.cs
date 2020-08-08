using System;

namespace ConvocaApp.Models
{
    public class PlacesViewModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string cellphone { get; set; }
        public string address { get; set; }
        public string addressStreet { get; set; }
        public int addressNumber1 { get; set; }
        public int addressNumber2 { get; set; }
        public int addressNumber3 { get; set; }
        public string addressLocation { get; set; }
    }
}
