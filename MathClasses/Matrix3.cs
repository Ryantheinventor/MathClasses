using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3;
            this.m4 = m4; this.m5 = m5; this.m6 = m6;
            this.m7 = m7; this.m8 = m8; this.m9 = m9;
        }

        public void Set(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3;
            this.m4 = m4; this.m5 = m5; this.m6 = m6;
            this.m7 = m7; this.m8 = m8; this.m9 = m9;
        }

        public void Set(Matrix3 setTo)
        {
            this.m1 = setTo.m1; this.m2 = setTo.m2; this.m3 = setTo.m3;
            this.m4 = setTo.m4; this.m5 = setTo.m5; this.m6 = setTo.m6;
            this.m7 = setTo.m7; this.m8 = setTo.m8; this.m9 = setTo.m9;
        }
        public static Vector3 operator *(Matrix3 left, Vector3 right)
            => new Vector3(left.m1 * right.x + left.m4 * right.y + left.m7 * right.z,
                left.m2 * right.x + left.m5 * right.y + left.m8 * right.z,
                left.m3 * right.x + left.m6 * right.y + left.m9 * right.z);

        public static Matrix3 operator *(Matrix3 left, Matrix3 right)
            => new Matrix3(
                left.m1 * right.m1 + left.m4 * right.m2 + left.m7 * right.m3,//1
                left.m2 * right.m1 + left.m5 * right.m2 + left.m8 * right.m3,//2
                left.m3 * right.m1 + left.m6 * right.m2 + left.m9 * right.m3,//3
                left.m1 * right.m4 + left.m4 * right.m5 + left.m7 * right.m6,//4
                left.m2 * right.m4 + left.m5 * right.m5 + left.m8 * right.m6,//5
                left.m3 * right.m4 + left.m6 * right.m5 + left.m9 * right.m6,//6
                left.m1 * right.m7 + left.m4 * right.m8 + left.m7 * right.m9,//7
                left.m2 * right.m7 + left.m5 * right.m8 + left.m8 * right.m9,//8
                left.m3 * right.m7 + left.m6 * right.m8 + left.m9 * right.m9 //9
                );

        public void SetRotateX(float amount)
        {
            Set(this * new Matrix3(1, 0, 0,
                 0, (float)Math.Cos(amount), (float)-Math.Sin(amount),
                 0, (float)Math.Sin(amount), (float)Math.Cos(amount)));
        }

        public void SetRotateY(float amount)
        {
            Set(this * new Matrix3((float)Math.Cos(amount), 0, (float)Math.Sin(amount),
                0, 1, 0,
                (float)-Math.Sin(amount), 0, (float)Math.Cos(amount)));
        }

        public void SetRotateZ(float amount)
        {
            Set(this * new Matrix3((float)Math.Cos(amount), (float)-Math.Sin(amount), 0,
                (float)Math.Sin(amount), (float)Math.Cos(amount), 0,
                0, 0, 1));
        }
        /// <summary>
        /// For console printing
        /// </summary>
        public void PrintMatrixToConsole() 
        {
            Console.WriteLine("---------------------------------");
            Console.Write($"{m1}");
            Console.CursorLeft = 11;
            Console.Write($"{m2}");
            Console.CursorLeft = 22;
            Console.WriteLine($"{m3}");
            Console.Write($"{m4}");
            Console.CursorLeft = 11;
            Console.Write($"{m5}");
            Console.CursorLeft = 22;
            Console.WriteLine($"{m6}");
            Console.Write($"{m7}");
            Console.CursorLeft = 11;
            Console.Write($"{m8}");
            Console.CursorLeft = 22;
            Console.WriteLine($"{m9}");
            Console.WriteLine("---------------------------------");
        }

    }
}