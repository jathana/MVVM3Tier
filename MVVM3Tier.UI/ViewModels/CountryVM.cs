﻿using MVVM3Tier.Model;
using MVVM3Tier.UI.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.UI.ViewModels
{
   public class CountryVM : NotifyUIBase
   {
      public Country TheCountry { get; set; }
   }
}
