using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static int CalcularPorcentaje(this int totalParticular, int totalGeneral)
        {
            return (totalParticular * 100) / totalGeneral;
        }
    }
}
