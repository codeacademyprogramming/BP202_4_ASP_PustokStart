using System;
using System.Collections.Generic;

namespace Eterna.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string Desc { get; set; }

        public Category Category { get; set; }

        public List<PortfolioImage> PortfolioImages { get; set; }
    }
}
