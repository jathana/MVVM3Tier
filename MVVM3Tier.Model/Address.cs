using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.Model
{
   [Table("AT_ADDRESSES")]
   public class Address
   {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [Column("ADDR_CODE"), Key]
      public int Code { get; set; }

      /// <summary>
      /// Street & Number
      /// </summary>
      [Column("ADDR_DESC"), MaxLength(45)]
      public string Description { get; set; }

      [Column("ADDR_CITY"), MaxLength(15)]
      public string City { get; set; }

      [Column("ADDR_ZIP"), MaxLength(10)]
      public string Zip { get; set; }

      [Column("CNTR_CODE"), MaxLength(3)]
      public string CountryCode { get; set; }

      [ForeignKey("CountryCode")]
      public Country Country { get; set; }

   }
}
