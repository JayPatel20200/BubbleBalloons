using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BubbleBalloons.Models
{
    public class Balloon
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Rating { get; set; }
        public decimal Price { get; set; }
    }
}
