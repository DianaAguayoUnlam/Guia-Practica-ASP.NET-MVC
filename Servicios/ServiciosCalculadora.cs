using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServiciosCalculadora
    {
        public static double Resolver(int operando1, int operando2, int operador)
        {
            double resultado=0;
            switch (operador)
            {
                case 1: resultado = operando1 + operando2;
                    break;
                case 2: resultado = operando1 - operando2;
                    break;
                case 3: resultado = operando1 * operando2;
                    break;
                case 4: resultado = operando1 / operando2;
                    break;
                default:
                    break;
            }
            return resultado;
        }
    }
}
