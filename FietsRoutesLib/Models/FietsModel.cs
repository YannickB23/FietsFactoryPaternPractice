using FietsRoutesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FietsRoutesLib.Models
{
    public class FietsModel : IFietsModel
    {
        public string Merk { get; set; }
        public string SoortFiets { get; set; }
        public string FietsMateriaal { get; set; }
        public int AantalVersnellingen { get; set; }
        public string TypeRem { get; set; }
        public string Wielset { get; set; }
    }
}
