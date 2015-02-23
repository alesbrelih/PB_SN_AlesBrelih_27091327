using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Oseba()
        {
            
        }
        public Oseba(OsebaView osebaView)
        {
            Ime = osebaView.Ime;
            Priimek = osebaView.Priimek;
            Telefon = osebaView.Telephone;
            Email = osebaView.EMail;
        }

    }
}
