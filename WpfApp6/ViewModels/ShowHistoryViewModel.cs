using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp6.Commands;
using WpfApp6.Models;

namespace WpfApp6.ViewModels
{
    public class ShowHistoryViewModel
    {
		private ObservableCollection<Drink> purchased;

		public ObservableCollection<Drink> ShowPurchased
		{
			get { return purchased; }
			set { purchased = value; }
		}
		public ShowHistoryViewModel()
		{
            ShowPurchased = new ObservableCollection<Drink>();
        }
	}
}
