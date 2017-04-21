using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.Model
{
   public class DataContext: DbContext
   {
      public DbSet<Customer> Customers { get; set; }
      public DbSet<Country> Countries { get; set; }
      public DbSet<Address> Addresses { get; set; }

      public DataContext():base("DataContext")
      {
         Database.SetInitializer<DataContext>(new DataContextInitializer());
      }
   }
}
