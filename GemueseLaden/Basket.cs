using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemueseLaden
{
    //
    class Basket
    {
        public ObservableCollection<Veggi> Veggies = new ObservableCollection<Veggi>();
        public float TotalPrice
        {
            get
            {
                float gesamtpreis = 0.0f;
                foreach (var item in Veggies)
                {
                    gesamtpreis += item.Price;
                }
                return gesamtpreis;
            }
        }
        
        public void Add(Veggi veggi)
        {
            Veggies.Add(veggi);
            TotalPriceChanged();
        }
        public event TotalPriceChangedEventHandler TotalPriceChanged;
    }
}
