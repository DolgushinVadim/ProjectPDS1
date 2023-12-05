using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DataService
    {
        public double Calculate(double k, double h, double u, double Pp, double Pz, double Rk, double r, double p)
        {
            double res = ((Math.Round(Math.PI, 2) * k * h) / (u * p)) * ((Math.Pow(Pp, 2) - Math.Pow(Pz, 2)) / Math.Log(Rk / r));
            return Math.Round(res, 3);
        }
    }
}
