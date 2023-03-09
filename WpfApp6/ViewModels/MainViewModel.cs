using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp6.Models;
using WpfApp6.Repositories;

namespace WpfApp6.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public FakeRepo DrinkRepository { get; set; }
		private ObservableCollection<Drink> allDrinks;

		public ObservableCollection<Drink> AllDrinks
        {
			get { return allDrinks; }
			set { allDrinks = value; OnPropertyChanged(); }
		}
		private Drink drink;

		public Drink Drink
		{
			get { return drink; }
			set { drink = value; OnPropertyChanged(); }
		}

	}
}
