using MVVM3Tier.Model;
using MVVM3Tier.UI.Support;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.UI.ViewModels
{
   public class CountriesVM: VMBase, IPageViewModel
   {
      public ObservableCollection<CountryVM> Countries { get; set; }

      public string Name
      {
         get
         {
            return "Countries";
         }
      }

      protected async override void GetData()
      {
         ObservableCollection<CountryVM> countriesVMs = new ObservableCollection<CountryVM>();

         var results = await (from c in db.Countries
                                orderby c.Name
                                select c).ToListAsync();
         foreach(Country country in results)
         {
            countriesVMs.Add(new CountryVM { TheCountry = country });
         }
         Countries = countriesVMs;
         RaisePropertyChanged("Countries");

      }
   }
}
