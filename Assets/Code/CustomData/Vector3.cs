using System;

namespace Code.CustomData
{
    public struct Vector3
    {
        public static Vector3 Zero => new ();
        public static Vector3 Forward => new(z: 1);
        public static Vector3 Backward => new(z: -1);
        
        public float X, Y, Z;

        public Vector3 Normalized => Normalize(this);
        public Vector3 CheckedNormalized => Normalize(this, true);
        public float Length => (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        
        public Vector3(float x = 0, float y = 0, float z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }

        
        public static Vector3 Normalize(Vector3 vector, bool checkLength = false)
        {
            var length = vector.Length;
            if (!checkLength || length > 1)
            {
                vector.X /= length;
                vector.Y /= length;
                vector.Z /= length;
            }
            return vector;
        }
        
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return !(a == b);
        }

        public static Vector3 operator *(Vector3 a, float scalar)
        {
            return new Vector3(a.X * scalar, a.Y * scalar, a.Z * scalar);
        }
        
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
    }
}