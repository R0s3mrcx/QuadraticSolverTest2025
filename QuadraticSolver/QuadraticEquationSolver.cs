using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticSolver
{
   public class QuadraticEquationSolver
    {
        public static double[] Solve(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (a == 0)
                throw new ArgumentException("Coefficient 'a' cannot be 0.");

            if (discriminant < 0)
                return new double[0];

            if (discriminant == 0)
                return new double[] { -b / (2 * a) };

            double sqrtDisc = Math.Sqrt(discriminant);
            return new double[]
            {
            (-b + sqrtDisc) / (2 * a),
            (-b - sqrtDisc) / (2 * a)
            };
        }
    }
}
