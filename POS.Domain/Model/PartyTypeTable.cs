using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace POS.Domain.Model
{
    public class PartyTypeTable
    {
        [Key]
        public int PartyTypeID { get; set; }
        public string PartyType { get; set; }
    }
}
