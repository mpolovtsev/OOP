using ExeptionsLibrary;

namespace VectorLibrary
{
    public class Vector
    {
        public double x, y, z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static double operator *(Vector vector1, Vector vector2)
        {
            double productOfX = vector1.x * vector2.x;
            double productOfY = vector1.y * vector2.y;
            double productOfZ = vector1.z * vector2.z;
            double productOfVectors = productOfX + productOfY + productOfZ;

            return productOfVectors;
        }

        public static Vector operator *(Vector vector, double num)
        {
            double x = vector.x * num;
            double y = vector.y * num;
            double z = vector.z * num;

            return new Vector(x, y, z);
        }

        public static Vector operator ^(Vector vector1, Vector vector2)
        {
            if (vector1.x == vector2.x && vector1.y == vector2.y &&
                vector1.z == vector2.z)
            {
                throw new VectorException("Одинаковые векторы.");
            }

            double x = vector1.y * vector2.z - vector1.z * vector2.y;
            double y = vector1.z * vector2.x - vector1.x * vector2.z;
            double z = vector1.x * vector2.y - vector1.y * vector2.x;

            return new Vector(x, y, z);
        }
    }
}