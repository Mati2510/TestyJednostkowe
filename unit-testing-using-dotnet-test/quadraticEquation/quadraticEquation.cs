using System;

public class QuadraticEquation
{
    public static Tuple<double, double> Solve(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            return null; 
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            return Tuple.Create(root, root); 
        }
        else
        {
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double root1 = (-b + sqrtDiscriminant) / (2 * a);
            double root2 = (-b - sqrtDiscriminant) / (2 * a);
            return Tuple.Create(root1, root2);
        }
    }
}

