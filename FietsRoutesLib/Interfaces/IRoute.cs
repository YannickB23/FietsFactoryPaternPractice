using System;

namespace FietsRoutesLib.Models
{
    public interface IRoute
    {
        double Afstand { get; set; }
        DateTime DuurRit { get; set; }
        int Hoogtemeters { get; set; }
        string SoortOndergrond { get; set; }
        bool ErkendeRoute { get; set; }
        double GemiddeldeSnelheid();
        void GetRouteInfo();
    }
}