#region System namespaces
using System;
#endregion

#region Solution namespaces
using Exercise1.Domain.Abstract;
#endregion


namespace Exercise1.Domain.Concrete
{
    public class IntermediateFormulas : IIntermediateFormulas
    {
        private readonly int p;

        public double AreaOfTriangle(double a, double b, double c)
        {
            // TODO - 4 - Calculate the area of a triangle using Heron's formula
            double p = ((a + b + c) / 2);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
