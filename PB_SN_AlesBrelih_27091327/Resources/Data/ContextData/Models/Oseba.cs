using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models
{
    public class Oseba
    {

        public int OsebaID { get; set; }

        public string Ime { get; set; }

        public string Priimek { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public ICollection<Podjetje> VsaPodjetja { get; set; }


    }
}
