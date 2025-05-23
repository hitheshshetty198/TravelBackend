﻿namespace TravelBackend.Models
{
    public class Itinerary
    {
        public int Id { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Place> Places { get; set; }
    }

}
