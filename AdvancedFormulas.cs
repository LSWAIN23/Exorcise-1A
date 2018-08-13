#region System namespaces
using System;
using System.Collections.Generic;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class AdvancedFormulas : IAdvancedFormulas
    {
        public double[] QuadraticEquation(double a, double b, double c)
        {
            // TODO - 5 - Calculate real results for the quadratic equation
            double top = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            double bottom = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            double[] result = new double[2];

            result[0] = top;
            result[1] = bottom;
            return result;
        }
    }
}
