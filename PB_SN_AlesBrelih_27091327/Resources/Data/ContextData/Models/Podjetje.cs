using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

namespace PB_SN_AlesBrelih_27091327.Resources.Data.ContextData.Models
{
    public class Podjetje
    {
        [Key]
        public int PodjetjeId { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string ImePodjetja { get; set; }

        public virtual Oseba KontaktnaOseba { get; set; }

        public virtual ICollection<Najem> NajemiPodjetja { get; set; } 
    }
}
