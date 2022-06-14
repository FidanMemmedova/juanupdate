using Juan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.ViewModels
{
    public class HomeViewModel
    {
        public List<Slide> Slides { get; set; }
        public List<Card> Cards { get; set; }
        public List<ShoesCard> ShoesCards { get; set; }
        public List<Discount> Discounts { get; set; }
    }
}
