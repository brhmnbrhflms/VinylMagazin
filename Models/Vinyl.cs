using System;
using System.Collections.Generic;

namespace Vinyl.Models
{
    public partial class Vinyl
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Year { get; set; }
        public string Photo { get; set; } = null!;
        public string Genre { get; set; } = null!;
    }
}
