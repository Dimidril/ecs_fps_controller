using System;

namespace Code.CustomData
{
    public struct Vector2
    {
        public static Vector2 Zero => new ();
        public static Vector2 Up => new(z: 1);
        public static Vector2 Left => new(z: -1);
        
        public float X, Y;

        public Vector2 Normalized => Normalize(this);
        public Vector2 CheckedNormalized => Normalize(this, true);
        public float Length => (float)Math.Sqrt(X * X + Y * Y);
        
        public Vector2(float x = 0, float y = 0, float z = 0)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"<{X}, {Y}>";
        }

        public static Vector2 Normalize(Vector2 vector, bool checkLength = false)
        {
            var length = vector.Length;
            if (!checkLength || length > 1)
            {
                vector.X /= length;
                vector.Y /= length;
            }
            return vector;
        }
        
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return !(a == b);
        }

        public static Vector2 operator *(Vector2 a, float scalar)
        {
            return new Vector2(a.X * scalar, a.Y * scalar);
        }
        
        public static Vector3 operator -(Vector2 a, Vector2 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y);
        }
    }
}