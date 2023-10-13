using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BubbleBalloons.Models
{
    public class BalloonTypeViewModel
    {
        public List<Balloon> Balloons { get; set; }
        public SelectList Type { get; set; }
        public string BalloonType { get; set; }
        public string SearchString { get; set; }
    }
}
