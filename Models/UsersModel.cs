using System;
using System.ComponentModel.DataAnnotations;

namespace ConvocaApp.Models
{
    public class UsersModel
    {
        
        public string name { get; set; }
        public int age { get; set; }               
        public string email { get; set; }
        public string sex { get; set; }        
        public string password { get; set; }        
        public string cellphone { get; set; }
        public int Id { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string addressStreet { get; set; }
        public int addressNumber1 { get; set; }
        public int addressNumber2 { get; set; }
        public int addressNumber3 { get; set; }
        public string addressLocation { get; set; }



    }
}
