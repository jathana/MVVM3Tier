using MVVM3Tier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.UI.Support
{
   public class VMBase: NotifyUIBase
   {
      protected DataContext db = new DataContext();


      protected VMBase()
      {
         GetData();
      }

      protected virtual void GetData()
      {

      }
   }
}
