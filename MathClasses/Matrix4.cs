using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

        public Matrix4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, 
            float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3; this.m4 = m4;
            this.m5 = m5; this.m6 = m6; this.m7 = m7; this.m8 = m8;
            this.m9 = m9; this.m10 = m10; this.m11 = m11; this.m12 = m12;
            this.m13 = m13; this.m14 = m14; this.m15 = m15; this.m16 = m16;
        }
        public void Set(Matrix4 setTo)
        {
            this.m1 = setTo.m1; this.m2 = setTo.m2; this.m3 = setTo.m3; this.m4 = setTo.m4;
            this.m5 = setTo.m5; this.m6 = setTo.m6; this.m7 = setTo.m7; this.m8 = setTo.m8;
            this.m9 = setTo.m9; this.m10 = setTo.m10; this.m11 = setTo.m11; this.m12 = setTo.m12;
            this.m13 = setTo.m13; this.m14 = setTo.m14; this.m15 = setTo.m15; this.m16 = setTo.m16;
        }
        public static Matrix4 operator *(Matrix4 left, Matrix4 right)
            => new Matrix4(
                left.m1 * right.m1 + left.m5 * right.m2 + left.m9 * right.m3 + left.m13 * right.m4,
                left.m2 * right.m1 + left.m6 * right.m2 + left.m10 * right.m3 + left.m14 * right.m4,
                left.m3 * right.m1 + left.m7 * right.m2 + left.m11 * right.m3 + left.m15 * right.m4,
                left.m4 * right.m1 + left.m8 * right.m2 + left.m12 * right.m3 + left.m16 * right.m4,
                left.m1 * right.m5 + left.m5 * right.m6 + left.m9 * right.m7 + left.m13 * right.m8,
                left.m2 * right.m5 + left.m6 * right.m6 + left.m10 * right.m7 + left.m14 * right.m8,
                left.m3 * right.m5 + left.m7 * right.m6 + left.m11 * right.m7 + left.m15 * right.m8,
                left.m4 * right.m5 + left.m8 * right.m6 + left.m12 * right.m7 + left.m16 * right.m8,
                left.m1 * right.m9 + left.m5 * right.m10 + left.m9 * right.m11 + left.m13 * right.m12,
                left.m2 * right.m9 + left.m6 * right.m10 + left.m10 * right.m11 + left.m14 * right.m12,
                left.m3 * right.m9 + left.m7 * right.m10 + left.m11 * right.m11 + left.m15 * right.m12,
                left.m4 * right.m9 + left.m8 * right.m10 + left.m12 * right.m11 + left.m16 * right.m12,
                left.m1 * right.m13 + left.m5 * right.m14 + left.m9 * right.m15 + left.m13 * right.m16,
                left.m2 * right.m13 + left.m6 * right.m14 + left.m10 * right.m15 + left.m14 * right.m16,
                left.m3 * right.m13 + left.m7 * right.m14 + left.m11 * right.m15 + left.m15 * right.m16,
                left.m4 * right.m13 + left.m8 * right.m14 + left.m12 * right.m15 + left.m16 * right.m16
                );

        public static Vector4 operator *(Matrix4 left, Vector4 right)
            => new Vector4(
                left.m1 * right.x + left.m5 * right.y + left.m9 * right.z + left.m13 * right.w,
                left.m2 * right.x + left.m6 * right.y + left.m10 * right.z + left.m14 * right.w,
                left.m3 * right.x + left.m7 * right.y + left.m11 * right.z + left.m15 * right.w,
                left.m4 * right.x + left.m8 * right.y + left.m12 * right.z + left.m16 * right.w
                );

        public void SetRotateX(float amount)
        {
            Set(this * new Matrix4(1, 0, 0, 0,
                 0, (float)Math.Cos(amount), (float)Math.Sin(amount), 0,
                 0, (float)-Math.Sin(amount), (float)Math.Cos(amount), 0,
                 0, 0, 0, 1));
        }

        public void SetRotateY(float amount)
        {
            Set(this * new Matrix4((float)Math.Cos(amount), 0, (float)-Math.Sin(amount), 0,
                0, 1, 0, 0,
                (float)Math.Sin(amount), 0, (float)Math.Cos(amount), 0,
                0, 0, 0, 1));
        }

        public void SetRotateZ(float amount)
        {
            Set(this * new Matrix4((float)Math.Cos(amount), (float)Math.Sin(amount), 0, 0,
                (float)-Math.Sin(amount), (float)Math.Cos(amount), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1));
        }

        /// <summary>
        /// For console printing
        /// </summary>
        public void PrintMatrixToConsole()
        {
            Console.WriteLine("--------------------------------------------");
            Console.Write($"{m1}");
            Console.CursorLeft = 11;
            Console.Write($"{m2}");
            Console.CursorLeft = 22;
            Console.Write($"{m3}");
            Console.CursorLeft = 33;
            Console.WriteLine($"{m4}");
            Console.Write($"{m5}");
            Console.CursorLeft = 11;
            Console.Write($"{m6}");
            Console.CursorLeft = 22;
            Console.Write($"{m7}");
            Console.CursorLeft = 33;
            Console.WriteLine($"{m8}");
            Console.Write($"{m9}");
            Console.CursorLeft = 11;
            Console.Write($"{m10}");
            Console.CursorLeft = 22;
            Console.Write($"{m11}");
            Console.CursorLeft = 33;
            Console.WriteLine($"{m12}");
            Console.Write($"{m13}");
            Console.CursorLeft = 11;
            Console.Write($"{m14}");
            Console.CursorLeft = 22;
            Console.Write($"{m15}");
            Console.CursorLeft = 33;
            Console.WriteLine($"{m16}");
            Console.WriteLine("--------------------------------------------");
        }

    }
}
