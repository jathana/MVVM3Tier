using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM3Tier.Model
{
   [Table("AT_CUSTOMERS")]
    public class Customer
    {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [Column("CUST_CODE"), Key]
      public int Code { get; set; }

      [Column("CUST_FIRST_NAME"), MaxLength(15)]
      public string FirstName { get; set; }

      [Column("CUST_LAST_NAME"), MaxLength(25)]
      public string LastName { get; set; }

      public ICollection<Address> Addresses { get; set; }
   }
}
