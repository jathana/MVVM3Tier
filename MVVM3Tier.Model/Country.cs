using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.Model
{
   /// <summary>
   /// Countries ISO Alpha-2, Alpha-3, and Numeric Country Codes
   /// </summary>
   [Table("AT_COUNTRIES")]
    public class Country
    {
      /// <summary>
      /// ISO Alpha-3
      /// </summary>
      [Column("CNTR_CODE"), Key, MaxLength(3)]
      public string Code { get; set; }

      [Column("CNTR_NAME"), MaxLength(60)]
      public string Name { get; set; }

      [Column("CNTR_ISO_ALPHA2"), MaxLength(2)]
      public string IsoAlpha2 { get; set; }

      [Column("CNTR_ISO_NUM_CODE"), MaxLength(3)]
      public string NumericCode { get; set; }


   }
}
