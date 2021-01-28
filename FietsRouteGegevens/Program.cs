using FietsRoutesLib.Interfaces;
using FietsRoutesLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FietsRouteGegevens
{
    class Program
    {
        static void Main(string[] args)
        {
            IFietsModel fietsModel = Factory.GetFietsModel();
            fietsModel.SoortFiets = "racefiets";
            fietsModel.Merk = "Cervelo";
            fietsModel.FietsMateriaal = "carbon";
            fietsModel.AantalVersnellingen = 11;
            fietsModel.Wielset = "Forza Vardar DB";
            fietsModel.TypeRem = "schijfrem";


            IRoute route = Factory.GetRoute();
            route.Afstand = 75.5;
            route.DuurRit = new DateTime(3);
            route.Hoogtemeters = 610;
            route.SoortOndergrond = "weg";
            route.GemiddeldeSnelheid();


            Console.ReadLine();
        }
    }
}
