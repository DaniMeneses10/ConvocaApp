using System;
using System.ComponentModel.DataAnnotations;

namespace ConvocaApp.Models
{
    public class MyEventsViewModel
    {
        public string category { get; set; }
        public string sex { get; set; }
        public string reserve { get; set; }        

        [Display(Name = "Date Edit")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:D}")]
        public DateTime? date { get; set; }
        //public int hour { get; set; }
        public int cost { get; set; }
        public string paymment { get; set; }
        public int Id { get; set; }
        public string place_name { get; set; }
        public string sport_name { get; set; }
        public int place_id { get; set; }
        public int sport_id { get; set; }
        public string time { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }
        public string meridian { get; set; }
        public string picture_url { get; set; }
    }
}
