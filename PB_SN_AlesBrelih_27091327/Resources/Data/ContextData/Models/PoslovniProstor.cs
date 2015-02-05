using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models
{
    public class PoslovniProstor
    {
        [Key]
        public int PoslovniProstorID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string ImeProstora { get; set; }

        [Required]
        public int DnevnaCena { get; set; }
    }
}
