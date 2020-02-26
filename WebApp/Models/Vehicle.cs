using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Vehicle
    {
        [Key]
        public string Id { get; set; }
        public string Make { get; set; }
        public string FuelType { get; set; }
        public string Aspiration { get; set; }
        public string NumDoors { get; set; }
        public string BodyStyle { get; set; }
        public string DriveWheels { get; set; }
        public string EngineLocation { get; set; }
        public float WheelBase { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float CurbWeight { get; set; }
        public string EngineType { get; set; }
        public string NumCylinders { get; set; }
        public float EngineSize { get; set; }
        public string FuelSystem { get; set; }
        public float Bore { get; set; }
        public float Stroke { get; set; }
        public float CompressionRatio { get; set; }
        public float Horsepower { get; set; }
        public float PeakRpm { get; set; }
        public float CityMpg { get; set; }
        public float HighwayMpg { get; set; }
        public float Price { get; set; }
    }
}
