using System;
using System.ComponentModel.DataAnnotations;

namespace ConvocaApp.Models
{
    public class UsersViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre y Apellido es necesario")]
        public string name { get; set; }
        public int age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email es necesario")]
        public string email { get; set; }
        public string sex { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password es necesario")]
        [DataType(DataType.Password)]

        public string password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Celular es necesario")]
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
