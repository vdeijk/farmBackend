﻿namespace Models.ViewModels
{
    public class LocationItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

