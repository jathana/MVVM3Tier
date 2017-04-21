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
   public class CustomersVM: VMBase, IPageViewModel
   {
      public ObservableCollection<CustomerVM> Customers { get; set; }

      public string Name
      {
         get
         {
            return "Customers";
         }
      }

      protected async override void GetData()
      {
         ObservableCollection<CustomerVM> customersVMs = new ObservableCollection<CustomerVM>();

         
         var custresults = await (from c in db.Customers
                                orderby c.LastName
                                select c).ToListAsync();
         foreach(Customer customer in custresults)
         {
            customersVMs.Add(new CustomerVM { TheCustomer = customer });
         }
         Customers = customersVMs;
         RaisePropertyChanged("Customers");

      }
   }
}
