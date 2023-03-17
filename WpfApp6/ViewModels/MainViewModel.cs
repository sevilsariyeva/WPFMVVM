using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using WpfApp6.Commands;
using WpfApp6.Models;
using WpfApp6.Repositories;

namespace WpfApp6.ViewModels
{
    public class MainViewModel : BaseViewModel
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
        private ObservableCollection<Drink> purchased;

        public ObservableCollection<Drink> Purchased
        {
            get { return purchased; }
            set { purchased = value; OnPropertyChanged(); }
        }

        public RelayCommand SelectedCommand { get; set; }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public RelayCommand BuyCommand { get; set; }
        public RelayCommand ResetCommand { get; set; }
        public RelayCommand ShowCommand { get; set; }
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            DrinkRepository = new FakeRepo();
            AllDrinks = new ObservableCollection<Drink>(DrinkRepository.GetAll());
            Drink = new Drink();
            Purchased = new ObservableCollection<Drink>();
            SelectedCommand = new RelayCommand((obj) =>
            {
                var item = obj as Drink;
                Drink = item;
            }
            );
            AddCommand = new RelayCommand((o) =>
            {
                count++;
                Count = count;
            }, (pred) =>
            {
                if(Drink==null || Drink.Id < 1)
                {
                    return false;
                }
                return true;
            });
            RemoveCommand = new RelayCommand((o) =>
            {
                if (count != 0)
                {
                    count--;
                }
                Count = count;
            }, (pred) =>
            {
                if (Drink == null || Drink.Id < 1)
                {
                    return false;
                }
                return true;
            });
            BuyCommand = new RelayCommand((obj) =>
            {
                if (Count > 0)
                {
                    Drink.DrinkCount = Count;
                    Drink.TotalPrice = Drink.DrinkCount * Drink.DrinkPrice;
                    purchased.Add(Drink);
                    MessageBox.Show("You've bought the drink");
                    Count = 0;
                }
                else
                {
                    MessageBox.Show("You have to add count of drink");
                }
            }, (pred) =>
            {
                if (Drink == null || Drink.Id < 1)
                {
                    return false;
                }
                return true;
            });
            ResetCommand = new RelayCommand((obj) =>
            {
                Drink = null;
                Count = 0;
            }, (pred) =>
            {
                if (Drink == null || Drink.Id < 1)
                {
                    return false;
                }
                return true;
            });
            ShowCommand = new RelayCommand((obj) =>
            {
                    ShowHistoryViewModel vm = new ShowHistoryViewModel();
                    vm.ShowPurchased = Purchased;

                    ShowHistoryWindow window = new ShowHistoryWindow();
                    window.DataContext = vm;
                    window.ShowDialog();
            }, (pred) =>
            {
                if (Drink == null || Drink.Id < 1)
                {
                    return false;
                }
                return true;
            });
        }
    }
}
