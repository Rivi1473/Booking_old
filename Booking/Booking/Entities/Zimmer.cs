﻿namespace Booking.Entities
{
    public class Zimmer
    {
        public int codeZimmer { get; set; }
        public string? name { get; set; }
        public string? city { get; set; }
        public string? address { get; set; }
        public int renterCode { get; set; }
        public string? description { get; set; }
        public int price { get; set; }
    }
}
