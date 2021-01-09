using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace POS.Domain.Model
{
   public class PartyAddressTable
    {
        [Key]
        public int PartyAddressID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }

        [ForeignKey(nameof(PartyTable.PartyID))] 
        public PartyTable Party { get; set; }
    }
}
