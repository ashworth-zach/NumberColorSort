using System;
using System.Collections.Generic;
namespace SaltusTechAssignment.Models
{
    public class numberColor
    {
        public int number { get; set; }
        public string color { get; set; }
        public numberColor()
        {
            var rng = new Random();
            this.number = rng.Next(1, 100);
            this.color = "";
        }
    }
}