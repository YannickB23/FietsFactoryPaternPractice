using FietsRoutesLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FietsRoutesLib.Models
{
    public static class Factory
    {
        public static IFietsModel GetFietsModel()
        {
            return new FietsModel();
        }
        public static IRoute GetRoute()
        {
            return new Route();
        }
    }
}
