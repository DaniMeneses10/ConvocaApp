using System;

namespace ConvocaApp.Models
{
    public class EventsModel
    {
        public string category { get; set; }
        public string sex { get; set; }
        public string reserve { get; set; }
        public string date { get; set; }
        public int hour { get; set; }
        public int cost { get; set; }
        public string paymment { get; set; }
        public int Id { get; set; }
        public int place_id { get; set; }
        public int sport_id { get; set; }
    }
}
