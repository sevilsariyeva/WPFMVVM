using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Models
{
    public class Drink : Entity
    {
        public string DrinkName { get; set; }
        public decimal DrinkPrice { get; set; }
        public decimal DrinkVolume { get; set; }
        public decimal DrinkCount{ get; set; }
        public decimal TotalPrice{ get; set; }
        public string ImagePath { get; set; }
    }
}
