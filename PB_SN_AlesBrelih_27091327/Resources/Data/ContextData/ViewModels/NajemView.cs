using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.ViewModels
{
    public class NajemViewMain
    {


        public int NajemId { get; set; }
        
        

        public string ImePodjetja { get; set; }
        public string KontaktnaOseba { get; set; }
        public DateTime ZacetekNajema { get; set; }
        public DateTime KonecNajema { get; set; }
        public string ImeProstora { get; set; }

        public NajemViewMain(Najem najem)
        {
            NajemId = najem.NajemID;
            ImePodjetja = najem.Podjetje.ImePodjetja;
            KontaktnaOseba = najem.Podjetje.KontaktnaOseba.Ime + " " + najem.Podjetje.KontaktnaOseba.Priimek;
            ZacetekNajema = najem.ZacetekNajema;
            KonecNajema = najem.KonecNajema;
            ImeProstora = najem.PoslovniProstor.ImeProstora;
        }
    }
}
