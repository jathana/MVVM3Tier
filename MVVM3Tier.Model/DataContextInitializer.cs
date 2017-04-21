using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.Model
{
   public class DataContextInitializer: CreateDatabaseIfNotExists<DataContext>
   {
      protected override void Seed(DataContext context)
      {
         // add countries
         IList<Country> countries = new List<Country>();
         try
         {
            StreamReader sr = new StreamReader("countries.csv");
            while (!sr.EndOfStream)
            {
               string line=sr.ReadLine();
               string[] arr = line.Split(';');
               countries.Add(new Country() { Code = arr[2], Name = arr[0], IsoAlpha2 = arr[1], NumericCode=arr[3]});
            }
            context.Countries.AddRange(countries);
            context.SaveChanges();
         }
         catch(Exception ex)
         {

         }


         base.Seed(context);
      }
   }
}
