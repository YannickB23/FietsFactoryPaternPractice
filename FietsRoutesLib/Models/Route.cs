using System;
using System.Collections.Generic;
using System.Text;

namespace FietsRoutesLib.Models
{
    public class Route : IRoute
    {
        public double Afstand { get; set; }
        public DateTime DuurRit { get; set; }
        public int Hoogtemeters { get; set; }
        public string SoortOndergrond { get; set; }
        public bool ErkendeRoute { get; set; }

        public Route(double afstand, DateTime duurRit)
        {
            Afstand = afstand;
            DuurRit = duurRit;
        }
        public Route()
        {
        }
        public override string ToString()
        {
            return "Gegevens rit:".ToUpper() +
                $"\nAfstand: {Afstand}\nDuur rit: {DuurRit}" +
                $"\n\nTechnische gegevens:".ToUpper() +
                $"\nHoogtemeters: {Hoogtemeters}\nSoort(en) ondergrond: {SoortOndergrond}\nErknde route: {ErkendeRoute}";
        }
        public double GemiddeldeSnelheid()
        {
            return Afstand / TimeSpan.Parse(DuurRit.ToString("H:mm")).TotalHours;
        }
        public void GetRouteInfo()
        {
            throw new NotImplementedException();
        }
    }
}
