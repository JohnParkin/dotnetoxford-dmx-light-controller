using System;

namespace DNOLights.API.Models
{
    public class SliderRequest
    {
        public Guid UserId { get; set; }
        public string SliderType { get; set; }
        public int Value { get; set; }
    }
}