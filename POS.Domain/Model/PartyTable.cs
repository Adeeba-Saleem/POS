using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POS.Domain.Model
{
   public class PartyTable
    {
        [Key]
        public int PartyID { get; set; }
        public string PartyName { get; set; }
        public decimal CreditLimit { get; set; }
        public int AccountNo { get; set; }
        public PartyAddressTable Address { get; set; }
        public int PartyTypeID { get; set; }
    }
}
