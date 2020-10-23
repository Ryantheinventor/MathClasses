using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static implicit operator System.Numerics.Vector4(Vector4 v)
        {
            return new System.Numerics.Vector4(v.x, v.y, v.z, v.w);
        }

        public static implicit operator Vector4(System.Numerics.Vector4 v)
        {
            return new System.Numerics.Vector4(v.X, v.Y, v.Z, v.W);
        }


        public static Vector4 operator +(Vector4 left, Vector4 right)
            => new Vector4(left.x + right.x, left.y + right.y, left.z + right.z, left.w+right.w);

        public static Vector4 operator -(Vector4 left, Vector4 right)
            => new Vector4(left.x - right.x, left.y - right.y, left.z - right.z, left.w - right.w);
        public static Vector4 operator *(float left, Vector4 right)
            => new Vector4(left * right.x, left * right.y, left * right.z, left * right.w);
        public static Vector4 operator *(Vector4 left, float right)
            => new Vector4(right * left.x, right * left.y, right * left.z, right * left.w);

        public float Dot(Vector4 other)
            => x * other.x + y * other.y + z * other.z + w * other.w;

        public Vector4 Cross(Vector4 other)
            => new Vector4(y * other.z - z * other.y, z * other.x - x * other.z, x * other.y - y * other.x, 0);

        public float Magnitude()
            => (float)Math.Sqrt(x * x + y * y + z * z + w * w);

        public void Normalize()
        {
            float mag = Magnitude();
            x /= mag;
            y /= mag;
            z /= mag;
            w /= mag;
        }


    }
}
