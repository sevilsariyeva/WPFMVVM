using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp6.Models;

namespace WpfApp6.Repositories
{
    public class FakeRepo
    {
        public List<Drink> GetAll()
        {
            return new List<Drink>
            {
                new Drink{Id=1,DrinkName="Coke",DrinkPrice=3.5M,DrinkVolume=330,ImagePath="/images/cola.png"},
                new Drink{Id=2,DrinkName="Fanta",DrinkPrice=2.5M,DrinkVolume=500,ImagePath="/images/fanta.png"},
                new Drink{Id=3,DrinkName="Sprite",DrinkPrice=3,DrinkVolume=330,ImagePath="/images/sprite.png"},
                new Drink{Id=4,DrinkName="Cappy Pulpy Orange",DrinkPrice=4.5M,DrinkVolume=1000,ImagePath="/images/cappy.png"},
                new Drink{Id=5,DrinkName="Fuse Tea Ice Tea",DrinkPrice=4.7M,DrinkVolume=1000,ImagePath="/images/fusetea.png"}
            };
        }
    }
}
