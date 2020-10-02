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

        public static Vector4 operator +(Vector4 left, Vector4 right)
            => new Vector4(left.x + right.x, left.y + right.y, left.z + right.z, left.w+right.w);

        public static Vector4 operator -(Vector4 left, Vector4 right)
            => new Vector4();
        public static Vector4 operator *(Vector4 left, Vector4 right)
            => new Vector4();
        public static Vector4 operator /(Vector4 left, Vector4 right)
            => new Vector4();
        public static Vector4 operator *(float left, Vector4 right)
            => new Vector4();
        public static Vector4 operator *(Vector4 left, float right)
            => new Vector4();

        public float Dot(Vector4 other)
        {
            return 0f;
        }

        public Vector4 Cross(Vector4 other)
        {
            return new Vector4();
        }

        public float Magnitude()
        {
            return 0f;
        }

        public void Normalize()
        {

        }


    }
}
