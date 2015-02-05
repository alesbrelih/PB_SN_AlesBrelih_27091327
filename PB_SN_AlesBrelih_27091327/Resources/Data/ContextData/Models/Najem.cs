using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models
{
    public class Najem
    {

        public int NajemID { get; set; }

        public virtual Podjetje Podjetje { get; set; }

        
        public virtual PoslovniProstor PoslovniProstor { get; set; }

        public DateTime ZacetekNajema { get; set; }

        public DateTime KonecNajema { get; set; }
    }
}
