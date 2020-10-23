using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;

        ///public static implicit 
        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator System.Numerics.Vector3(Vector3 v)
        {
            return new System.Numerics.Vector3(v.x, v.y, v.z);
        }

        public static implicit operator Vector3(System.Numerics.Vector3 v)
        {
            return new System.Numerics.Vector3(v.X, v.Y, v.Z);
        }

        public static Vector3 operator +(Vector3 left, Vector3 right)
            => new Vector3(left.x + right.x, left.y + right.y, left.z + right.z);

        public static Vector3 operator -(Vector3 left, Vector3 right)
            => new Vector3(left.x - right.x, left.y - right.y, left.z - right.z);
        public static Vector3 operator *(float left, Vector3 right)
            => new Vector3(left * right.x, left * right.y, left * right.z);
        public static Vector3 operator *(Vector3 left, float right)
            => new Vector3(right * left.x, right * left.y, right * left.z);

        public float Dot(Vector3 other)
            => x * other.x + y * other.y + z * other.z;

        public Vector3 Cross(Vector3 other)
            => new Vector3(y * other.z - z * other.y, z * other.x - x * other.z, x * other.y - y * other.x);

        public float Magnitude()
            => (float)Math.Sqrt(x * x + y * y + z * z);
        

        public void Normalize()
        {
            float mag = Magnitude();
            x /= mag;
            y /= mag;
            z /= mag;

        }

    }
}
